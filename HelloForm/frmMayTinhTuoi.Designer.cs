
namespace HelloForm
{
    partial class frmMayTinhTuoi
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
            this.txttuoi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btntuoi = new System.Windows.Forms.Button();
            this.lbtuoi = new System.Windows.Forms.Label();
            this.lbtuoi2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txttuoi
            // 
            this.txttuoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttuoi.Location = new System.Drawing.Point(12, 128);
            this.txttuoi.Name = "txttuoi";
            this.txttuoi.Size = new System.Drawing.Size(230, 34);
            this.txttuoi.TabIndex = 0;
            this.txttuoi.TextChanged += new System.EventHandler(this.txttuoi_TextChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nhập số tuổi của bạn";
            // 
            // btntuoi
            // 
            this.btntuoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntuoi.Location = new System.Drawing.Point(12, 227);
            this.btntuoi.Name = "btntuoi";
            this.btntuoi.Size = new System.Drawing.Size(218, 37);
            this.btntuoi.TabIndex = 3;
            this.btntuoi.Text = "Tính  tuổi của bạn";
            this.btntuoi.UseVisualStyleBackColor = true;
            this.btntuoi.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbtuoi
            // 
            this.lbtuoi.AutoSize = true;
            this.lbtuoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtuoi.Location = new System.Drawing.Point(18, 188);
            this.lbtuoi.Name = "lbtuoi";
            this.lbtuoi.Size = new System.Drawing.Size(0, 25);
            this.lbtuoi.TabIndex = 4;
            // 
            // lbtuoi2
            // 
            this.lbtuoi2.AutoSize = true;
            this.lbtuoi2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtuoi2.Location = new System.Drawing.Point(7, 178);
            this.lbtuoi2.Name = "lbtuoi2";
            this.lbtuoi2.Size = new System.Drawing.Size(60, 24);
            this.lbtuoi2.TabIndex = 5;
            this.lbtuoi2.Text = "label3";
            this.lbtuoi2.Visible = false;
            this.lbtuoi2.Click += new System.EventHandler(this.lbtuoi2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(294, 29);
            this.label3.TabIndex = 7;
            this.label3.Text = "Máy tính tuổi thông minh";
            // 
            // frmMayTinhTuoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbtuoi2);
            this.Controls.Add(this.lbtuoi);
            this.Controls.Add(this.btntuoi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txttuoi);
            this.Name = "frmMayTinhTuoi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMayTinhTuoi";
            this.Load += new System.EventHandler(this.frmMayTinhTuoi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txttuoi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btntuoi;
        private System.Windows.Forms.Label lbtuoi;
        private System.Windows.Forms.Label lbtuoi2;
        private System.Windows.Forms.Label label3;
    }
}