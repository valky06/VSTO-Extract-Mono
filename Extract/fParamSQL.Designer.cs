namespace Extract
{
    partial class fParamSQL
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tConstr = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bAnnul = new System.Windows.Forms.Button();
            this.bOK = new System.Windows.Forms.Button();
            this.bTest = new System.Windows.Forms.Button();
            this.bInit = new System.Windows.Forms.Button();
            this.lVue = new System.Windows.Forms.ListBox();
            this.bSuppr = new System.Windows.Forms.Button();
            this.bNouv = new System.Windows.Forms.Button();
            this.tID = new System.Windows.Forms.Label();
            this.tSql = new System.Windows.Forms.TextBox();
            this.tNom = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tConstr
            // 
            this.tConstr.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tConstr.Location = new System.Drawing.Point(12, 30);
            this.tConstr.Multiline = true;
            this.tConstr.Name = "tConstr";
            this.tConstr.Size = new System.Drawing.Size(648, 58);
            this.tConstr.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Chaine de connexion";
            // 
            // bAnnul
            // 
            this.bAnnul.Location = new System.Drawing.Point(12, 94);
            this.bAnnul.Name = "bAnnul";
            this.bAnnul.Size = new System.Drawing.Size(75, 23);
            this.bAnnul.TabIndex = 2;
            this.bAnnul.Text = "Annuler";
            this.bAnnul.UseVisualStyleBackColor = true;
            this.bAnnul.Click += new System.EventHandler(this.bAnnul_Click);
            // 
            // bOK
            // 
            this.bOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bOK.Location = new System.Drawing.Point(585, 94);
            this.bOK.Name = "bOK";
            this.bOK.Size = new System.Drawing.Size(75, 23);
            this.bOK.TabIndex = 3;
            this.bOK.Text = "OK";
            this.bOK.UseVisualStyleBackColor = true;
            this.bOK.Click += new System.EventHandler(this.bOK_Click);
            // 
            // bTest
            // 
            this.bTest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bTest.Location = new System.Drawing.Point(449, 94);
            this.bTest.Name = "bTest";
            this.bTest.Size = new System.Drawing.Size(120, 23);
            this.bTest.TabIndex = 4;
            this.bTest.Text = "Test Connexion";
            this.bTest.UseVisualStyleBackColor = true;
            this.bTest.Click += new System.EventHandler(this.bTest_Click);
            // 
            // bInit
            // 
            this.bInit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bInit.Location = new System.Drawing.Point(358, 94);
            this.bInit.Name = "bInit";
            this.bInit.Size = new System.Drawing.Size(75, 23);
            this.bInit.TabIndex = 5;
            this.bInit.Text = "Init Tables";
            this.bInit.UseVisualStyleBackColor = true;
            this.bInit.Click += new System.EventHandler(this.bInit_Click);
            // 
            // lVue
            // 
            this.lVue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lVue.FormattingEnabled = true;
            this.lVue.Location = new System.Drawing.Point(13, 137);
            this.lVue.Name = "lVue";
            this.lVue.Size = new System.Drawing.Size(227, 368);
            this.lVue.TabIndex = 6;
            this.lVue.DoubleClick += new System.EventHandler(this.lVue_DoubleClick);
            // 
            // bSuppr
            // 
            this.bSuppr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bSuppr.Location = new System.Drawing.Point(12, 511);
            this.bSuppr.Name = "bSuppr";
            this.bSuppr.Size = new System.Drawing.Size(75, 23);
            this.bSuppr.TabIndex = 8;
            this.bSuppr.Text = "Supprimer";
            this.bSuppr.UseVisualStyleBackColor = true;
            this.bSuppr.Click += new System.EventHandler(this.bSuppr_Click);
            // 
            // bNouv
            // 
            this.bNouv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bNouv.Location = new System.Drawing.Point(165, 511);
            this.bNouv.Name = "bNouv";
            this.bNouv.Size = new System.Drawing.Size(75, 23);
            this.bNouv.TabIndex = 7;
            this.bNouv.Text = "Nouveau";
            this.bNouv.UseVisualStyleBackColor = true;
            this.bNouv.Click += new System.EventHandler(this.bNouv_click);
            // 
            // tID
            // 
            this.tID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tID.AutoSize = true;
            this.tID.Location = new System.Drawing.Point(640, 143);
            this.tID.Name = "tID";
            this.tID.Size = new System.Drawing.Size(18, 13);
            this.tID.TabIndex = 9;
            this.tID.Tag = "vue_Id,k";
            this.tID.Text = "ID";
            // 
            // tSql
            // 
            this.tSql.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tSql.Location = new System.Drawing.Point(246, 166);
            this.tSql.Multiline = true;
            this.tSql.Name = "tSql";
            this.tSql.Size = new System.Drawing.Size(412, 339);
            this.tSql.TabIndex = 10;
            this.tSql.Tag = "CmdSQL,t";
            // 
            // tNom
            // 
            this.tNom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tNom.Location = new System.Drawing.Point(247, 140);
            this.tNom.Name = "tNom";
            this.tNom.Size = new System.Drawing.Size(387, 20);
            this.tNom.TabIndex = 11;
            this.tNom.Tag = "nom,t";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(583, 511);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Enregistrer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.bEnreg);
            // 
            // fParamSQL
            // 
            this.ClientSize = new System.Drawing.Size(670, 545);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tNom);
            this.Controls.Add(this.tSql);
            this.Controls.Add(this.tID);
            this.Controls.Add(this.bSuppr);
            this.Controls.Add(this.bNouv);
            this.Controls.Add(this.lVue);
            this.Controls.Add(this.bInit);
            this.Controls.Add(this.bTest);
            this.Controls.Add(this.bOK);
            this.Controls.Add(this.bAnnul);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tConstr);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "fParamSQL";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.fParamSQL_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        //private System.Windows.Forms.ListBox lVue;
        //private System.Windows.Forms.TextBox tNom;
        //private System.Windows.Forms.TextBox tSQL;
        //private System.Windows.Forms.Label tID;
        //private System.Windows.Forms.Button button1;
        //private System.Windows.Forms.Button button3;
        //private System.Windows.Forms.Button button4;
        //private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        //private System.Windows.Forms.DataGridViewTextBoxColumn User;
        //private System.Windows.Forms.DataGridViewTextBoxColumn CritSQL;
        //private System.Windows.Forms.DataGridViewTextBoxColumn MOD;
        //private System.Windows.Forms.Label label1;
        //private System.Windows.Forms.Button button2;
        //private System.Windows.Forms.TextBox tConstr;
        //private System.Windows.Forms.Label label2;
        //internal System.Windows.Forms.Button button5;
        //private System.Windows.Forms.Button button6;
        //private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TextBox tConstr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bAnnul;
        private System.Windows.Forms.Button bOK;
        private System.Windows.Forms.Button bTest;
        private System.Windows.Forms.Button bInit;
        private System.Windows.Forms.ListBox lVue;
        private System.Windows.Forms.Button bSuppr;
        private System.Windows.Forms.Button bNouv;
        private System.Windows.Forms.Label tID;
        private System.Windows.Forms.TextBox tSql;
        private System.Windows.Forms.TextBox tNom;
        private System.Windows.Forms.Button button1;
    }
}