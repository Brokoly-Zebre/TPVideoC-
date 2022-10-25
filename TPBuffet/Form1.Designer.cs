namespace TPBuffet
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.RdbFilm = new System.Windows.Forms.RadioButton();
            this.RdbSerie = new System.Windows.Forms.RadioButton();
            this.lblTitre = new System.Windows.Forms.Label();
            this.lblnbEpisodes = new System.Windows.Forms.Label();
            this.lblRecette = new System.Windows.Forms.Label();
            this.lblannee = new System.Windows.Forms.Label();
            this.button_Ajouter = new System.Windows.Forms.Button();
            this.lstDiffusions = new System.Windows.Forms.ListBox();
            this.txtTItre = new System.Windows.Forms.TextBox();
            this.txtnbEpisodes = new System.Windows.Forms.TextBox();
            this.txtRecette = new System.Windows.Forms.TextBox();
            this.txtannee = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // RdbFilm
            // 
            this.RdbFilm.AutoSize = true;
            this.RdbFilm.Location = new System.Drawing.Point(66, 66);
            this.RdbFilm.Name = "RdbFilm";
            this.RdbFilm.Size = new System.Drawing.Size(58, 24);
            this.RdbFilm.TabIndex = 0;
            this.RdbFilm.TabStop = true;
            this.RdbFilm.Text = "Film";
            this.RdbFilm.UseVisualStyleBackColor = true;
            this.RdbFilm.CheckedChanged += new System.EventHandler(this.RdbFilm_CheckedChanged);
            // 
            // RdbSerie
            // 
            this.RdbSerie.AutoSize = true;
            this.RdbSerie.Location = new System.Drawing.Point(242, 66);
            this.RdbSerie.Name = "RdbSerie";
            this.RdbSerie.Size = new System.Drawing.Size(63, 24);
            this.RdbSerie.TabIndex = 1;
            this.RdbSerie.TabStop = true;
            this.RdbSerie.Text = "Serie";
            this.RdbSerie.UseVisualStyleBackColor = true;
            this.RdbSerie.CheckedChanged += new System.EventHandler(this.RdbSerie_CheckedChanged);
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Location = new System.Drawing.Point(66, 132);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(39, 20);
            this.lblTitre.TabIndex = 2;
            this.lblTitre.Text = "Titre";
            // 
            // lblnbEpisodes
            // 
            this.lblnbEpisodes.AutoSize = true;
            this.lblnbEpisodes.Location = new System.Drawing.Point(66, 255);
            this.lblnbEpisodes.Name = "lblnbEpisodes";
            this.lblnbEpisodes.Size = new System.Drawing.Size(92, 20);
            this.lblnbEpisodes.TabIndex = 3;
            this.lblnbEpisodes.Text = "Nb Episodes";
            // 
            // lblRecette
            // 
            this.lblRecette.AutoSize = true;
            this.lblRecette.Location = new System.Drawing.Point(66, 214);
            this.lblRecette.Name = "lblRecette";
            this.lblRecette.Size = new System.Drawing.Size(59, 20);
            this.lblRecette.TabIndex = 4;
            this.lblRecette.Text = "Recette";
            // 
            // lblannee
            // 
            this.lblannee.AutoSize = true;
            this.lblannee.Location = new System.Drawing.Point(66, 173);
            this.lblannee.Name = "lblannee";
            this.lblannee.Size = new System.Drawing.Size(51, 20);
            this.lblannee.TabIndex = 5;
            this.lblannee.Text = "Année";
            // 
            // button_Ajouter
            // 
            this.button_Ajouter.Location = new System.Drawing.Point(0, 326);
            this.button_Ajouter.Name = "button_Ajouter";
            this.button_Ajouter.Size = new System.Drawing.Size(478, 29);
            this.button_Ajouter.TabIndex = 6;
            this.button_Ajouter.Text = "Ajouter";
            this.button_Ajouter.UseVisualStyleBackColor = true;
            this.button_Ajouter.Click += new System.EventHandler(this.button1_Click);
            // 
            // lstDiffusions
            // 
            this.lstDiffusions.FormattingEnabled = true;
            this.lstDiffusions.ItemHeight = 20;
            this.lstDiffusions.Location = new System.Drawing.Point(0, 370);
            this.lstDiffusions.Name = "lstDiffusions";
            this.lstDiffusions.Size = new System.Drawing.Size(478, 284);
            this.lstDiffusions.TabIndex = 7;
            // 
            // txtTItre
            // 
            this.txtTItre.Location = new System.Drawing.Point(153, 125);
            this.txtTItre.Name = "txtTItre";
            this.txtTItre.Size = new System.Drawing.Size(312, 27);
            this.txtTItre.TabIndex = 8;
            // 
            // txtnbEpisodes
            // 
            this.txtnbEpisodes.Location = new System.Drawing.Point(153, 255);
            this.txtnbEpisodes.Name = "txtnbEpisodes";
            this.txtnbEpisodes.Size = new System.Drawing.Size(312, 27);
            this.txtnbEpisodes.TabIndex = 9;
            // 
            // txtRecette
            // 
            this.txtRecette.Location = new System.Drawing.Point(153, 211);
            this.txtRecette.Name = "txtRecette";
            this.txtRecette.Size = new System.Drawing.Size(312, 27);
            this.txtRecette.TabIndex = 10;
            // 
            // txtannee
            // 
            this.txtannee.Location = new System.Drawing.Point(153, 166);
            this.txtannee.Name = "txtannee";
            this.txtannee.Size = new System.Drawing.Size(312, 27);
            this.txtannee.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 661);
            this.Controls.Add(this.txtannee);
            this.Controls.Add(this.txtRecette);
            this.Controls.Add(this.txtnbEpisodes);
            this.Controls.Add(this.txtTItre);
            this.Controls.Add(this.lstDiffusions);
            this.Controls.Add(this.button_Ajouter);
            this.Controls.Add(this.lblannee);
            this.Controls.Add(this.lblRecette);
            this.Controls.Add(this.lblnbEpisodes);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.RdbSerie);
            this.Controls.Add(this.RdbFilm);
            this.Name = "Form1";
            this.Text = "DiffusionForms";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RadioButton RdbFilm;
        private RadioButton RdbSerie;
        private Label lblTitre;
        private Label lblnbEpisodes;
        private Label lblRecette;
        private Label lblannee;
        private Button button_Ajouter;
        private ListBox lstDiffusions;
        private TextBox txtTItre;
        private TextBox txtnbEpisodes;
        private TextBox txtRecette;
        private TextBox txtannee;
    }
}