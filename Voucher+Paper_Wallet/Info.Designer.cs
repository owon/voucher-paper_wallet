namespace Voucher_Paper_Wallet
{
    partial class Info
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
            this.lbl_about_head = new System.Windows.Forms.Label();
            this.txt_info = new System.Windows.Forms.TextBox();
            this.btn_okay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_about_head
            // 
            this.lbl_about_head.AutoSize = true;
            this.lbl_about_head.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_about_head.Location = new System.Drawing.Point(27, 21);
            this.lbl_about_head.Name = "lbl_about_head";
            this.lbl_about_head.Size = new System.Drawing.Size(0, 17);
            this.lbl_about_head.TabIndex = 0;
            // 
            // txt_info
            // 
            this.txt_info.AllowDrop = true;
            this.txt_info.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_info.Location = new System.Drawing.Point(31, 21);
            this.txt_info.Multiline = true;
            this.txt_info.Name = "txt_info";
            this.txt_info.ReadOnly = true;
            this.txt_info.Size = new System.Drawing.Size(550, 480);
            this.txt_info.TabIndex = 2;
            this.txt_info.TabStop = false;
            // 
            // btn_okay
            // 
            this.btn_okay.Location = new System.Drawing.Point(220, 512);
            this.btn_okay.Name = "btn_okay";
            this.btn_okay.Size = new System.Drawing.Size(129, 37);
            this.btn_okay.TabIndex = 3;
            this.btn_okay.Text = "okay";
            this.btn_okay.UseVisualStyleBackColor = true;
            this.btn_okay.Click += new System.EventHandler(this.button1_Click);
            // 
            // Info
            // 
            this.ClientSize = new System.Drawing.Size(614, 561);
            this.Controls.Add(this.btn_okay);
            this.Controls.Add(this.txt_info);
            this.Controls.Add(this.lbl_about_head);
            this.Name = "Info";
            this.Text = "Tipps & About";
            this.Load += new System.EventHandler(this.Info_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_about_head;
        private System.Windows.Forms.TextBox txt_info;
        private System.Windows.Forms.Button btn_okay;
    }
}