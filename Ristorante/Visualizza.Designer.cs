﻿namespace Ristorante
{
    partial class Visualizza
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
            this.label1 = new System.Windows.Forms.Label();
            this.antipasti = new System.Windows.Forms.ListBox();
            this.primi = new System.Windows.Forms.ListBox();
            this.secondi = new System.Windows.Forms.ListBox();
            this.dessert = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(296, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(373, 55);
            this.label1.TabIndex = 1;
            this.label1.Text = "Visualizza Menú";
            // 
            // antipasti
            // 
            this.antipasti.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.antipasti.FormattingEnabled = true;
            this.antipasti.ItemHeight = 24;
            this.antipasti.Location = new System.Drawing.Point(23, 138);
            this.antipasti.Name = "antipasti";
            this.antipasti.Size = new System.Drawing.Size(218, 340);
            this.antipasti.TabIndex = 2;
            this.antipasti.SelectedIndexChanged += new System.EventHandler(this.antipasti_SelectedIndexChanged);
            // 
            // primi
            // 
            this.primi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.primi.FormattingEnabled = true;
            this.primi.ItemHeight = 24;
            this.primi.Location = new System.Drawing.Point(260, 138);
            this.primi.Name = "primi";
            this.primi.Size = new System.Drawing.Size(218, 340);
            this.primi.TabIndex = 3;
            this.primi.SelectedIndexChanged += new System.EventHandler(this.primi_SelectedIndexChanged);
            // 
            // secondi
            // 
            this.secondi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondi.FormattingEnabled = true;
            this.secondi.ItemHeight = 24;
            this.secondi.Location = new System.Drawing.Point(498, 138);
            this.secondi.Name = "secondi";
            this.secondi.Size = new System.Drawing.Size(218, 340);
            this.secondi.TabIndex = 4;
            this.secondi.SelectedIndexChanged += new System.EventHandler(this.secondi_SelectedIndexChanged);
            // 
            // dessert
            // 
            this.dessert.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dessert.FormattingEnabled = true;
            this.dessert.ItemHeight = 24;
            this.dessert.Location = new System.Drawing.Point(737, 138);
            this.dessert.Name = "dessert";
            this.dessert.Size = new System.Drawing.Size(218, 340);
            this.dessert.TabIndex = 5;
            this.dessert.SelectedIndexChanged += new System.EventHandler(this.dessert_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 37);
            this.label2.TabIndex = 6;
            this.label2.Text = "Antipasti";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(322, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 37);
            this.label3.TabIndex = 7;
            this.label3.Text = "Primi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(535, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 37);
            this.label4.TabIndex = 8;
            this.label4.Text = "Secondi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(782, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 37);
            this.label5.TabIndex = 9;
            this.label5.Text = "Dessert";
            // 
            // Visualizza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(981, 498);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dessert);
            this.Controls.Add(this.secondi);
            this.Controls.Add(this.primi);
            this.Controls.Add(this.antipasti);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(997, 537);
            this.MinimumSize = new System.Drawing.Size(997, 537);
            this.Name = "Visualizza";
            this.Text = "Ristorante";
            this.Load += new System.EventHandler(this.Visualizza_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox antipasti;
        private System.Windows.Forms.ListBox primi;
        private System.Windows.Forms.ListBox secondi;
        private System.Windows.Forms.ListBox dessert;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}