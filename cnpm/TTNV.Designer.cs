namespace cnpm
{
    partial class TTNV
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
            this.labelTTNV = new System.Windows.Forms.Label();
            this.label_accNV = new System.Windows.Forms.Label();
            this.textBox_accNV = new System.Windows.Forms.TextBox();
            this.label_passNV = new System.Windows.Forms.Label();
            this.textBox_passNV = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelTTNV
            // 
            this.labelTTNV.AutoSize = true;
            this.labelTTNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTTNV.Location = new System.Drawing.Point(175, 43);
            this.labelTTNV.Name = "labelTTNV";
            this.labelTTNV.Size = new System.Drawing.Size(321, 31);
            this.labelTTNV.TabIndex = 1;
            this.labelTTNV.Text = "THÔNG TIN NHÂN VIÊN";
            // 
            // label_accNV
            // 
            this.label_accNV.AutoSize = true;
            this.label_accNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label_accNV.Location = new System.Drawing.Point(123, 121);
            this.label_accNV.Name = "label_accNV";
            this.label_accNV.Size = new System.Drawing.Size(80, 24);
            this.label_accNV.TabIndex = 2;
            this.label_accNV.Text = "Account";
            // 
            // textBox_accNV
            // 
            this.textBox_accNV.Location = new System.Drawing.Point(246, 123);
            this.textBox_accNV.Name = "textBox_accNV";
            this.textBox_accNV.ReadOnly = true;
            this.textBox_accNV.Size = new System.Drawing.Size(262, 20);
            this.textBox_accNV.TabIndex = 3;
            // 
            // label_passNV
            // 
            this.label_passNV.AutoSize = true;
            this.label_passNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label_passNV.Location = new System.Drawing.Point(123, 167);
            this.label_passNV.Name = "label_passNV";
            this.label_passNV.Size = new System.Drawing.Size(92, 24);
            this.label_passNV.TabIndex = 4;
            this.label_passNV.Text = "Password";
            // 
            // textBox_passNV
            // 
            this.textBox_passNV.Location = new System.Drawing.Point(246, 167);
            this.textBox_passNV.Name = "textBox_passNV";
            this.textBox_passNV.Size = new System.Drawing.Size(262, 20);
            this.textBox_passNV.TabIndex = 5;
            // 
            // TTNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(688, 329);
            this.Controls.Add(this.textBox_passNV);
            this.Controls.Add(this.label_passNV);
            this.Controls.Add(this.textBox_accNV);
            this.Controls.Add(this.label_accNV);
            this.Controls.Add(this.labelTTNV);
            this.Name = "TTNV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin nhân viên";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTTNV;
        private System.Windows.Forms.Label label_accNV;
        private System.Windows.Forms.TextBox textBox_accNV;
        private System.Windows.Forms.Label label_passNV;
        private System.Windows.Forms.TextBox textBox_passNV;
    }
}