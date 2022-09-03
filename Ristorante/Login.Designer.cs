namespace Ristorante
{
    partial class Login
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
            this.userbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.passbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.loginbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userbox
            // 
            this.userbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userbox.Location = new System.Drawing.Point(12, 182);
            this.userbox.Multiline = true;
            this.userbox.Name = "userbox";
            this.userbox.Size = new System.Drawing.Size(326, 32);
            this.userbox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 37);
            this.label2.TabIndex = 2;
            this.label2.Text = "USERNAME";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(203, 37);
            this.label3.TabIndex = 4;
            this.label3.Text = "PASSWORD";
            // 
            // passbox
            // 
            this.passbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passbox.Location = new System.Drawing.Point(12, 290);
            this.passbox.Multiline = true;
            this.passbox.Name = "passbox";
            this.passbox.Size = new System.Drawing.Size(326, 32);
            this.passbox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(90, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 55);
            this.label1.TabIndex = 5;
            this.label1.Text = "LOGIN";
            // 
            // loginbutton
            // 
            this.loginbutton.BackColor = System.Drawing.Color.White;
            this.loginbutton.Location = new System.Drawing.Point(266, 385);
            this.loginbutton.Name = "loginbutton";
            this.loginbutton.Size = new System.Drawing.Size(72, 33);
            this.loginbutton.TabIndex = 6;
            this.loginbutton.Text = "ENTER";
            this.loginbutton.UseVisualStyleBackColor = false;
            this.loginbutton.Click += new System.EventHandler(this.loginbutton_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(352, 430);
            this.Controls.Add(this.loginbutton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.passbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.userbox);
            this.MaximumSize = new System.Drawing.Size(368, 469);
            this.MinimumSize = new System.Drawing.Size(368, 469);
            this.Name = "Login";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox userbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox passbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button loginbutton;
    }
}

