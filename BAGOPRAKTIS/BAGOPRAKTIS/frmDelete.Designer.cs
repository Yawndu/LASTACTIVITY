﻿namespace BAGOPRAKTIS
{
    partial class frmDelete
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
            this.txtDeleteName = new System.Windows.Forms.TextBox();
            this.txtDeleteEmail = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtDeleteCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtDeleteName
            // 
            this.txtDeleteName.Location = new System.Drawing.Point(63, 54);
            this.txtDeleteName.Name = "txtDeleteName";
            this.txtDeleteName.Size = new System.Drawing.Size(206, 20);
            this.txtDeleteName.TabIndex = 0;
            // 
            // txtDeleteEmail
            // 
            this.txtDeleteEmail.Location = new System.Drawing.Point(63, 114);
            this.txtDeleteEmail.Name = "txtDeleteEmail";
            this.txtDeleteEmail.Size = new System.Drawing.Size(206, 20);
            this.txtDeleteEmail.TabIndex = 1;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(69, 178);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(89, 34);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtDeleteCancel
            // 
            this.txtDeleteCancel.Location = new System.Drawing.Point(170, 178);
            this.txtDeleteCancel.Name = "txtDeleteCancel";
            this.txtDeleteCancel.Size = new System.Drawing.Size(89, 34);
            this.txtDeleteCancel.TabIndex = 3;
            this.txtDeleteCancel.Text = "Cancel";
            this.txtDeleteCancel.UseVisualStyleBackColor = true;
            this.txtDeleteCancel.Click += new System.EventHandler(this.txtDeleteCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "NAME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "EMAIL";
            // 
            // frmDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 258);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDeleteCancel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtDeleteEmail);
            this.Controls.Add(this.txtDeleteName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmDelete";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delete Record";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDeleteName;
        private System.Windows.Forms.TextBox txtDeleteEmail;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button txtDeleteCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}