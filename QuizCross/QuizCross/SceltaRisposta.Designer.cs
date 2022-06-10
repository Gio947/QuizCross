namespace QuizCross
{
    partial class SceltaRisposta
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
            this.labelDomanda = new System.Windows.Forms.Label();
            this.btnRisposta1 = new System.Windows.Forms.Button();
            this.btnRisposta2 = new System.Windows.Forms.Button();
            this.btnRisposta3 = new System.Windows.Forms.Button();
            this.btnRisposta4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelDomanda
            // 
            this.labelDomanda.AutoSize = true;
            this.labelDomanda.Location = new System.Drawing.Point(75, 41);
            this.labelDomanda.Name = "labelDomanda";
            this.labelDomanda.Size = new System.Drawing.Size(0, 13);
            this.labelDomanda.TabIndex = 0;
            // 
            // btnRisposta1
            // 
            this.btnRisposta1.BackColor = System.Drawing.SystemColors.Control;
            this.btnRisposta1.Location = new System.Drawing.Point(55, 178);
            this.btnRisposta1.Name = "btnRisposta1";
            this.btnRisposta1.Size = new System.Drawing.Size(263, 36);
            this.btnRisposta1.TabIndex = 1;
            this.btnRisposta1.UseVisualStyleBackColor = false;
            this.btnRisposta1.Click += new System.EventHandler(this.btnRisposta_Click);
            // 
            // btnRisposta2
            // 
            this.btnRisposta2.Location = new System.Drawing.Point(55, 220);
            this.btnRisposta2.Name = "btnRisposta2";
            this.btnRisposta2.Size = new System.Drawing.Size(263, 36);
            this.btnRisposta2.TabIndex = 2;
            this.btnRisposta2.UseVisualStyleBackColor = true;
            this.btnRisposta2.Click += new System.EventHandler(this.btnRisposta_Click);
            // 
            // btnRisposta3
            // 
            this.btnRisposta3.Location = new System.Drawing.Point(55, 262);
            this.btnRisposta3.Name = "btnRisposta3";
            this.btnRisposta3.Size = new System.Drawing.Size(263, 36);
            this.btnRisposta3.TabIndex = 3;
            this.btnRisposta3.UseVisualStyleBackColor = true;
            this.btnRisposta3.Click += new System.EventHandler(this.btnRisposta_Click);
            // 
            // btnRisposta4
            // 
            this.btnRisposta4.Location = new System.Drawing.Point(55, 305);
            this.btnRisposta4.Name = "btnRisposta4";
            this.btnRisposta4.Size = new System.Drawing.Size(263, 36);
            this.btnRisposta4.TabIndex = 4;
            this.btnRisposta4.UseVisualStyleBackColor = true;
            this.btnRisposta4.Click += new System.EventHandler(this.btnRisposta_Click);
            // 
            // SceltaRisposta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuizCross.Properties.Resources.risposta;
            this.ClientSize = new System.Drawing.Size(370, 353);
            this.Controls.Add(this.btnRisposta4);
            this.Controls.Add(this.btnRisposta3);
            this.Controls.Add(this.btnRisposta2);
            this.Controls.Add(this.btnRisposta1);
            this.Controls.Add(this.labelDomanda);
            this.Name = "SceltaRisposta";
            this.Text = "QuizCross";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDomanda;
        private System.Windows.Forms.Button btnRisposta1;
        private System.Windows.Forms.Button btnRisposta2;
        private System.Windows.Forms.Button btnRisposta3;
        private System.Windows.Forms.Button btnRisposta4;
    }
}