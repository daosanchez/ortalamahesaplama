﻿namespace form6
{
    partial class Form1
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
            this.txtNot1 = new System.Windows.Forms.TextBox();
            this.txtNot2 = new System.Windows.Forms.TextBox();
            this.lblNot1 = new System.Windows.Forms.Label();
            this.lblNot2 = new System.Windows.Forms.Label();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.lblOrtalama = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNot1
            // 
            this.txtNot1.Location = new System.Drawing.Point(269, 67);
            this.txtNot1.Name = "txtNot1";
            this.txtNot1.Size = new System.Drawing.Size(100, 20);
            this.txtNot1.TabIndex = 0;
            // 
            // txtNot2
            // 
            this.txtNot2.Location = new System.Drawing.Point(269, 107);
            this.txtNot2.Name = "txtNot2";
            this.txtNot2.Size = new System.Drawing.Size(100, 20);
            this.txtNot2.TabIndex = 1;
            // 
            // lblNot1
            // 
            this.lblNot1.AutoSize = true;
            this.lblNot1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblNot1.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNot1.Location = new System.Drawing.Point(208, 70);
            this.lblNot1.Name = "lblNot1";
            this.lblNot1.Size = new System.Drawing.Size(36, 13);
            this.lblNot1.TabIndex = 2;
            this.lblNot1.Text = "Not1:";
            // 
            // lblNot2
            // 
            this.lblNot2.AutoSize = true;
            this.lblNot2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblNot2.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNot2.Location = new System.Drawing.Point(208, 114);
            this.lblNot2.Name = "lblNot2";
            this.lblNot2.Size = new System.Drawing.Size(36, 13);
            this.lblNot2.TabIndex = 3;
            this.lblNot2.Text = "Not2:";
            // 
            // btnHesapla
            // 
            this.btnHesapla.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnHesapla.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHesapla.Location = new System.Drawing.Point(171, 201);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(75, 27);
            this.btnHesapla.TabIndex = 4;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = false;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblSonuc.Location = new System.Drawing.Point(275, 166);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(19, 13);
            this.lblSonuc.TabIndex = 5;
            this.lblSonuc.Text = "***";
            // 
            // lblOrtalama
            // 
            this.lblOrtalama.AutoSize = true;
            this.lblOrtalama.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrtalama.Location = new System.Drawing.Point(189, 166);
            this.lblOrtalama.Name = "lblOrtalama";
            this.lblOrtalama.Size = new System.Drawing.Size(58, 13);
            this.lblOrtalama.TabIndex = 7;
            this.lblOrtalama.Text = "Ortalama:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblOrtalama);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.lblNot2);
            this.Controls.Add(this.lblNot1);
            this.Controls.Add(this.txtNot2);
            this.Controls.Add(this.txtNot1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNot1;
        private System.Windows.Forms.TextBox txtNot2;
        private System.Windows.Forms.Label lblNot1;
        private System.Windows.Forms.Label lblNot2;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Label lblSonuc;
        private System.Windows.Forms.Label lblOrtalama;
    }
}

