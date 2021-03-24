using System;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Extract
{
    public partial class fParamSQL : Form
    {
        private OleDbConnection LaConnect = new OleDbConnection();

        private void Initialise()
        {
            try
            {
                Extract.Properties.Settings.Default.Reload();
                Common.ConnexionInit(Extract.Properties.Settings.Default.VueConStr, ref LaConnect);
                Common.ListFill("Select vue.vue_id,vue.nom from vue order by vue.nom", this.lVue, ref LaConnect);
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        public fParamSQL()
        {
            InitializeComponent();
        }

        private void lVue_DoubleClick(object sender, EventArgs e)
        {
            Common.FormRempli(this, "SELECT Vue_id,Vue.nom,CmdSQL FROM Vue where vue_id=" + ((Common.ListItem)lVue.SelectedItem).Val, ref LaConnect);
        }

        private void bNouv_click(object sender, EventArgs e)
        {
            this.tID.Text = "";
            this.tNom.Text = "";
            this.tSql.Text = "";
        }

        private void bEnreg(object sender, EventArgs e)
        {
            int Lid = Common.FormEnreg(this, "vue", ref LaConnect);
            if (Lid !=0)  {
                //MAZ des champs
                bNouv_click(null,null);
                Common.ListFill("Select vue.vue_id,vue.nom from vue order by vue.nom", this.lVue, ref LaConnect);
            }
        }



        private void bSuppr_Click(object sender, EventArgs e)
        {
            if ( this.lVue.SelectedIndex>=0) { 
                Common.SqlDo("Delete from vue where vue_id=" + ((Common.ListItem)(this.lVue.SelectedItem)).Val, ref LaConnect);
                bNouv_click(null, null);
                Common.ListFill("Select vue.vue_id,vue.nom from vue order by vue.nom", this.lVue, ref LaConnect);
            }
        }


        private void bInit_Click(object sender, EventArgs e)
        {
            
            if ( MessageBox.Show("Initialiser les tables") == DialogResult.OK) { 
                try
                {
                    OleDbConnection LaConnect = new OleDbConnection();
                    Common.ConnexionInit(Extract.Properties.Settings.Default.VueConStr, ref LaConnect);

                    string s = "DROP TABLE IF EXISTS Vue; CREATE TABLE Vue( Vue_id [int] IDENTITY(1, 1) NOT NULL, Nom [varchar] (200) NOT NULL, CmdSQL [varchar] (8000) NOT NULL"
                    + " CONSTRAINT[PK_Vue] PRIMARY KEY CLUSTERED ( Vue_id ASC ) WITH(PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON"
                    + ", ALLOW_PAGE_LOCKS = ON) ON[PRIMARY] ) ON[PRIMARY]";

                    Common.SqlDo(s, ref LaConnect);

                    MessageBox.Show("La table a été créée !");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void fParamSQL_Load(object sender, EventArgs e)
        {
            Extract.Properties.Settings.Default.Reload();
            this.tConstr.Text = Extract.Properties.Settings.Default.VueConStr;
            Version version = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
            this.Text = "Extract Mono - " + version.ToString();
            Initialise();
        }



        private void bOK_Click(object sender, EventArgs e)
        {
            Extract.Properties.Settings.Default.VueConStr = this.tConstr.Text;
            Extract.Properties.Settings.Default.Save();
            DialogResult = DialogResult.OK;
            Close();
        }

        private void bAnnul_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void bTest_Click(object sender, EventArgs e)
        {
            if (Common.ConnexionTest(this.tConstr.Text))
            {
                MessageBox.Show("Connexion OK");
                Initialise();
            }
            else
            {
                MessageBox.Show("Erreur Connection");
            }
        }
    }
}
