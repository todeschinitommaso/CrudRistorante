namespace Ristorante
{
    partial class Elimina
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
            this.searchbutton = new System.Windows.Forms.Button();
            this.namebox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.confirmbutton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchbutton
            // 
            this.searchbutton.BackColor = System.Drawing.Color.White;
            this.searchbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchbutton.Location = new System.Drawing.Point(230, 96);
            this.searchbutton.Name = "searchbutton";
            this.searchbutton.Size = new System.Drawing.Size(108, 33);
            this.searchbutton.TabIndex = 26;
            this.searchbutton.Text = "Elimina";
            this.searchbutton.UseVisualStyleBackColor = false;
            this.searchbutton.Click += new System.EventHandler(this.searchbutton_Click);
            // 
            // namebox
            // 
            this.namebox.Location = new System.Drawing.Point(20, 104);
            this.namebox.Name = "namebox";
            this.namebox.Size = new System.Drawing.Size(147, 20);
            this.namebox.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 24);
            this.label2.TabIndex = 24;
            this.label2.Text = "Nome";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.searchbutton);
            this.panel1.Controls.Add(this.namebox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(380, 148);
            this.panel1.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(99, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 55);
            this.label1.TabIndex = 23;
            this.label1.Text = "Elimina";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.confirmbutton);
            this.panel2.Location = new System.Drawing.Point(-4, 8);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(374, 148);
            this.panel2.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(34, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(331, 18);
            this.label4.TabIndex = 29;
            this.label4.Text = "in un secondo momento nella sezione \"recupera\"";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(81, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(216, 18);
            this.label3.TabIndex = 28;
            this.label3.Text = "il piatto potrá essere recuperato";
            // 
            // confirmbutton
            // 
            this.confirmbutton.BackColor = System.Drawing.Color.White;
            this.confirmbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmbutton.Location = new System.Drawing.Point(84, 31);
            this.confirmbutton.Name = "confirmbutton";
            this.confirmbutton.Size = new System.Drawing.Size(213, 33);
            this.confirmbutton.TabIndex = 27;
            this.confirmbutton.Text = "Conferma Eliminazione";
            this.confirmbutton.UseVisualStyleBackColor = false;
            this.confirmbutton.Click += new System.EventHandler(this.confirmbutton_Click);
            // 
            // Elimina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(382, 153);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "Elimina";
            this.Text = "Elimina";
            this.Load += new System.EventHandler(this.Elimina_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button searchbutton;
        private System.Windows.Forms.TextBox namebox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button confirmbutton;
        private System.Windows.Forms.Label label1;
    }
}