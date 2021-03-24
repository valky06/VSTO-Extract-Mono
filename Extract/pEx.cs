using System;
using System.Data.OleDb;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using System.Collections;
using System.Collections.Generic;
namespace Extract
{
    public partial class pEx : UserControl

   {

     

        private OleDbConnection LaConnect = new OleDbConnection();

        private  void AfficheVue()
        {
            OleDbDataReader LeRs;
            ArrayList LaListe = new ArrayList();
            string sSql = "Select vue.vue_id,vue.Nom from vue order by Nom";

            this.lVue.DataSource = null;
            this.lVue.Items.Clear();
            LeRs = Common.SqlLit(sSql, ref LaConnect);
            while (LeRs.Read())
            {
                LaListe.Add(new Common.ListItem(LeRs.GetInt32(0), LeRs.GetString(1)));
            }
            LeRs.Close();
            lVue.DisplayMember = "Txt";
            lVue.ValueMember = "Val";
            lVue.DataSource = LaListe;
        }


        public pEx()
        {
            InitializeComponent();
        }

        private bool Initialise()
        {
            Microsoft.Office.Interop.Excel.Application APP = Globals.CompoExtract.Application;
            bool Init = false;
            try
            {
                lVue.DataSource = null;
                lVue.Items.Clear();   
                APP.StatusBar = "Vues...";
                tInit.Text = System.Security.Principal.WindowsIdentity.GetCurrent().Name;

                Extract.Properties.Settings.Default.Reload();
                Common.ConnexionInit(Extract.Properties.Settings.Default.VueConStr, ref LaConnect);
                if (Common.ConnexionTest(LaConnect.ConnectionString))
                {
                    Init = true;
                    AfficheVue();
                } else
                {
                    Init = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Init = false;
                tInit.Text = "Non Connecté";
            }
            i_info.Enabled = Init;
            APP.StatusBar = "";
            return Init;
        }

        private void pEx_Load(object sender, EventArgs e)
        {
           Initialise();
        }

  
        private void lVue_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lVue_MouseDoubleClick(object sender, EventArgs e)
        {
            string sSQL = "";
      //      string ExtractConStr = g;
      //      OleDbConnection ExtractConSql = new OleDbConnection();
            
            if (lVue.SelectedIndex < 0) { return; }

            try
            {

                Microsoft.Office.Interop.Excel.Application APP = Globals.CompoExtract.Application;
                APP.Calculation = XlCalculation.xlCalculationManual;

                OleDbDataReader LeRs;
                Common.ListItem LItem = (Common.ListItem)lVue.SelectedItem;

                sSQL = "Select CmdSql from vue where vue.vue_id=" + LItem.Val;
                LeRs = Common.SqlLit(sSQL, ref LaConnect);

                if (LeRs.Read())
                { sSQL = LeRs.GetString(0); }    

                if (sSQL.Contains("?") )
                {
                    fCrit fc = new fCrit();
                    fc.laReq = sSQL;
                    fc.ShowDialog();
                    sSQL = fc.laReq;
                    fc.Dispose();
                }
                
                if ( sSQL !="") { 
                    if (APP.ActiveCell.ListObject == null) {
                        QueryTable Q =  APP.ActiveSheet.ListObjects.Add(SourceType: 0, Source: "OLEDB;" + Extract.Properties.Settings.Default.VueConStr, Destination: APP.ActiveCell).QueryTable;
                        Q.CommandType = XlCmdType.xlCmdSql;
                        Q.CommandText = sSQL;
                        Q.RowNumbers = false;
                        Q.FillAdjacentFormulas = false;
                        Q.PreserveFormatting = true;
                        Q.RefreshOnFileOpen = false;
                        Q.BackgroundQuery = false;
                        Q.SavePassword = false;
                        Q.SaveData = true;
                        Q.AdjustColumnWidth = true;
                        Q.RefreshPeriod = 0;
                        Q.PreserveColumnInfo = true;
                        Q.Refresh(BackgroundQuery: false);
                    } else
                    {
                        MessageBox.Show("Impossible de mettre à jour ce tableau. Veuillez extraire dans un autre onglet !");
                    }
                    APP.Calculation = XlCalculation.xlCalculationAutomatic;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            lVue_MouseDoubleClick(sender, e);
        }

        private void Param(object sender, EventArgs e)
        {
            Form passe = new fPasse();
            if (passe.ShowDialog()== DialogResult.OK) {
                Form leP = new fParamSQL();
                leP.ShowDialog();
                leP.Dispose();
                Initialise();
            }
        }

        private void i_info_Click(object sender, EventArgs e)
        {

        }
    }
}
