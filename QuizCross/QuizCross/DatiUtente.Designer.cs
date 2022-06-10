namespace QuizCross
{
    partial class DatiUtente
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGioca = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxUsername2 = new System.Windows.Forms.TextBox();
            this.textBoxUsername1 = new System.Windows.Forms.TextBox();
            this.listBoxAvatar1 = new System.Windows.Forms.ListBox();
            this.listBoxAvatar2 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnGioca
            // 
            this.btnGioca.Location = new System.Drawing.Point(293, 406);
            this.btnGioca.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGioca.Name = "btnGioca";
            this.btnGioca.Size = new System.Drawing.Size(100, 28);
            this.btnGioca.TabIndex = 0;
            this.btnGioca.Text = "Gioca";
            this.btnGioca.UseVisualStyleBackColor = true;
            this.btnGioca.Click += new System.EventHandler(this.btnGioca_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(293, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Giocatore 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(295, 222);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Giocatore 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(176, 59);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Username : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(176, 267);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Username : ";
            // 
            // textBoxUsername2
            // 
            this.textBoxUsername2.Location = new System.Drawing.Point(299, 267);
            this.textBoxUsername2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxUsername2.Name = "textBoxUsername2";
            this.textBoxUsername2.Size = new System.Drawing.Size(159, 22);
            this.textBoxUsername2.TabIndex = 5;
            // 
            // textBoxUsername1
            // 
            this.textBoxUsername1.Location = new System.Drawing.Point(293, 59);
            this.textBoxUsername1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxUsername1.Name = "textBoxUsername1";
            this.textBoxUsername1.Size = new System.Drawing.Size(159, 22);
            this.textBoxUsername1.TabIndex = 6;
            // 
            // listBoxAvatar1
            // 
            this.listBoxAvatar1.FormattingEnabled = true;
            this.listBoxAvatar1.ItemHeight = 16;
            this.listBoxAvatar1.Location = new System.Drawing.Point(293, 91);
            this.listBoxAvatar1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBoxAvatar1.Name = "listBoxAvatar1";
            this.listBoxAvatar1.Size = new System.Drawing.Size(159, 84);
            this.listBoxAvatar1.TabIndex = 7;
            // 
            // listBoxAvatar2
            // 
            this.listBoxAvatar2.FormattingEnabled = true;
            this.listBoxAvatar2.ItemHeight = 16;
            this.listBoxAvatar2.Location = new System.Drawing.Point(299, 299);
            this.listBoxAvatar2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBoxAvatar2.Name = "listBoxAvatar2";
            this.listBoxAvatar2.Size = new System.Drawing.Size(159, 84);
            this.listBoxAvatar2.TabIndex = 8;
            // 
            // DatiUtente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuizCross.Properties.Resources.logo;
            this.ClientSize = new System.Drawing.Size(504, 477);
            this.Controls.Add(this.listBoxAvatar2);
            this.Controls.Add(this.listBoxAvatar1);
            this.Controls.Add(this.textBoxUsername1);
            this.Controls.Add(this.textBoxUsername2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGioca);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "DatiUtente";
            this.Text = "QuizCross";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DatiUtente_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGioca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxUsername2;
        private System.Windows.Forms.TextBox textBoxUsername1;
        private System.Windows.Forms.ListBox listBoxAvatar1;
        private System.Windows.Forms.ListBox listBoxAvatar2;
    }
}

