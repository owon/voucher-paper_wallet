namespace Voucher_Paper_Wallet
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btn_save = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.check_mobile = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_walletname = new System.Windows.Forms.TextBox();
            this.check_rawsk = new System.Windows.Forms.CheckBox();
            this.btn_generate = new System.Windows.Forms.Button();
            this.check_showPW = new System.Windows.Forms.CheckBox();
            this.combo_design = new System.Windows.Forms.ComboBox();
            this.lbl_design = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_password = new System.Windows.Forms.Label();
            this.lbl_raw_format = new System.Windows.Forms.Label();
            this.picbox_sk_raw = new System.Windows.Forms.PictureBox();
            this.lbl_mob_format = new System.Windows.Forms.Label();
            this.lbl_sk = new System.Windows.Forms.Label();
            this.picbox_Address = new System.Windows.Forms.PictureBox();
            this.picbox_sk_mobile = new System.Windows.Forms.PictureBox();
            this.lbl_Address = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_sk_raw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_Address)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_sk_mobile)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_save
            // 
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_save.Location = new System.Drawing.Point(992, 573);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(182, 23);
            this.btn_save.TabIndex = 9;
            this.btn_save.Text = "Save to file...";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(992, 544);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 24);
            this.button1.TabIndex = 8;
            this.button1.Text = "Info...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(155, 518);
            this.txt_password.MaxLength = 12;
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(115, 22);
            this.txt_password.TabIndex = 2;
            this.txt_password.TextChanged += new System.EventHandler(this.txt_password_TextChanged);
            // 
            // check_mobile
            // 
            this.check_mobile.AutoSize = true;
            this.check_mobile.BackColor = System.Drawing.Color.Transparent;
            this.check_mobile.Checked = true;
            this.check_mobile.CheckState = System.Windows.Forms.CheckState.Checked;
            this.check_mobile.Location = new System.Drawing.Point(11, 494);
            this.check_mobile.Name = "check_mobile";
            this.check_mobile.Size = new System.Drawing.Size(250, 21);
            this.check_mobile.TabIndex = 1;
            this.check_mobile.Text = "Include mobile walltet import format";
            this.check_mobile.UseVisualStyleBackColor = false;
            this.check_mobile.CheckedChanged += new System.EventHandler(this.check_mobile_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(34, 521);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Import password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(35, 540);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Wallet name:";
            // 
            // txt_walletname
            // 
            this.txt_walletname.Location = new System.Drawing.Point(155, 538);
            this.txt_walletname.MaxLength = 10;
            this.txt_walletname.Name = "txt_walletname";
            this.txt_walletname.Size = new System.Drawing.Size(115, 22);
            this.txt_walletname.TabIndex = 3;
            this.txt_walletname.TextChanged += new System.EventHandler(this.txt_walletname_TextChanged);
            // 
            // check_rawsk
            // 
            this.check_rawsk.AutoSize = true;
            this.check_rawsk.BackColor = System.Drawing.Color.Transparent;
            this.check_rawsk.Checked = true;
            this.check_rawsk.CheckState = System.Windows.Forms.CheckState.Checked;
            this.check_rawsk.Location = new System.Drawing.Point(417, 494);
            this.check_rawsk.Name = "check_rawsk";
            this.check_rawsk.Size = new System.Drawing.Size(293, 21);
            this.check_rawsk.TabIndex = 5;
            this.check_rawsk.Text = "Include RAW private key (Recommended)";
            this.check_rawsk.UseVisualStyleBackColor = false;
            this.check_rawsk.CheckedChanged += new System.EventHandler(this.check_rawsk_CheckedChanged);
            // 
            // btn_generate
            // 
            this.btn_generate.BackColor = System.Drawing.SystemColors.Control;
            this.btn_generate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_generate.ForeColor = System.Drawing.Color.Green;
            this.btn_generate.Location = new System.Drawing.Point(783, 543);
            this.btn_generate.Name = "btn_generate";
            this.btn_generate.Size = new System.Drawing.Size(188, 53);
            this.btn_generate.TabIndex = 7;
            this.btn_generate.Text = "Generate voucher";
            this.btn_generate.UseVisualStyleBackColor = false;
            this.btn_generate.Click += new System.EventHandler(this.btn_generate_Click);
            // 
            // check_showPW
            // 
            this.check_showPW.AutoSize = true;
            this.check_showPW.BackColor = System.Drawing.Color.Transparent;
            this.check_showPW.Checked = true;
            this.check_showPW.CheckState = System.Windows.Forms.CheckState.Checked;
            this.check_showPW.Location = new System.Drawing.Point(37, 566);
            this.check_showPW.Name = "check_showPW";
            this.check_showPW.Size = new System.Drawing.Size(307, 21);
            this.check_showPW.TabIndex = 4;
            this.check_showPW.Text = "Show password in voucher (Recommended)";
            this.check_showPW.UseVisualStyleBackColor = false;
            this.check_showPW.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // combo_design
            // 
            this.combo_design.FormattingEnabled = true;
            this.combo_design.Location = new System.Drawing.Point(783, 514);
            this.combo_design.Name = "combo_design";
            this.combo_design.Size = new System.Drawing.Size(391, 24);
            this.combo_design.TabIndex = 6;
            this.combo_design.SelectedIndexChanged += new System.EventHandler(this.combo_design_SelectedIndexChanged);
            // 
            // lbl_design
            // 
            this.lbl_design.AutoSize = true;
            this.lbl_design.BackColor = System.Drawing.Color.Transparent;
            this.lbl_design.Location = new System.Drawing.Point(780, 495);
            this.lbl_design.Name = "lbl_design";
            this.lbl_design.Size = new System.Drawing.Size(93, 17);
            this.lbl_design.TabIndex = 16;
            this.lbl_design.Text = "Select design";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Voucher_Paper_Wallet.Properties.Resources.Jabo_Paper_Wallet_1200_480;
            this.panel1.Controls.Add(this.lbl_password);
            this.panel1.Controls.Add(this.lbl_raw_format);
            this.panel1.Controls.Add(this.picbox_sk_raw);
            this.panel1.Controls.Add(this.lbl_mob_format);
            this.panel1.Controls.Add(this.lbl_sk);
            this.panel1.Controls.Add(this.picbox_Address);
            this.panel1.Controls.Add(this.picbox_sk_mobile);
            this.panel1.Controls.Add(this.lbl_Address);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 480);
            this.panel1.TabIndex = 6;
            // 
            // lbl_password
            // 
            this.lbl_password.BackColor = System.Drawing.Color.White;
            this.lbl_password.Location = new System.Drawing.Point(738, 255);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(200, 18);
            this.lbl_password.TabIndex = 6;
            this.lbl_password.Text = "Import password:";
            // 
            // lbl_raw_format
            // 
            this.lbl_raw_format.BackColor = System.Drawing.Color.White;
            this.lbl_raw_format.Location = new System.Drawing.Point(741, 423);
            this.lbl_raw_format.Name = "lbl_raw_format";
            this.lbl_raw_format.Size = new System.Drawing.Size(130, 17);
            this.lbl_raw_format.TabIndex = 5;
            this.lbl_raw_format.Text = "RAW private key";
            // 
            // picbox_sk_raw
            // 
            this.picbox_sk_raw.Location = new System.Drawing.Point(741, 294);
            this.picbox_sk_raw.Name = "picbox_sk_raw";
            this.picbox_sk_raw.Size = new System.Drawing.Size(130, 130);
            this.picbox_sk_raw.TabIndex = 4;
            this.picbox_sk_raw.TabStop = false;
            // 
            // lbl_mob_format
            // 
            this.lbl_mob_format.BackColor = System.Drawing.Color.White;
            this.lbl_mob_format.Location = new System.Drawing.Point(738, 239);
            this.lbl_mob_format.Name = "lbl_mob_format";
            this.lbl_mob_format.Size = new System.Drawing.Size(200, 17);
            this.lbl_mob_format.TabIndex = 3;
            this.lbl_mob_format.Text = "Mobile wallet import format QR";
            // 
            // lbl_sk
            // 
            this.lbl_sk.BackColor = System.Drawing.Color.White;
            this.lbl_sk.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lbl_sk.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sk.Location = new System.Drawing.Point(871, 294);
            this.lbl_sk.Name = "lbl_sk";
            this.lbl_sk.Size = new System.Drawing.Size(72, 146);
            this.lbl_sk.TabIndex = 1;
            this.lbl_sk.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picbox_Address
            // 
            this.picbox_Address.Location = new System.Drawing.Point(90, 167);
            this.picbox_Address.Name = "picbox_Address";
            this.picbox_Address.Size = new System.Drawing.Size(150, 150);
            this.picbox_Address.TabIndex = 0;
            this.picbox_Address.TabStop = false;
            // 
            // picbox_sk_mobile
            // 
            this.picbox_sk_mobile.Location = new System.Drawing.Point(738, 40);
            this.picbox_sk_mobile.Name = "picbox_sk_mobile";
            this.picbox_sk_mobile.Size = new System.Drawing.Size(200, 200);
            this.picbox_sk_mobile.TabIndex = 1;
            this.picbox_sk_mobile.TabStop = false;
            // 
            // lbl_Address
            // 
            this.lbl_Address.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Address.Location = new System.Drawing.Point(41, 320);
            this.lbl_Address.Name = "lbl_Address";
            this.lbl_Address.Size = new System.Drawing.Size(325, 53);
            this.lbl_Address.TabIndex = 2;
            this.lbl_Address.Text = "NEM address";
            // 
            // MainForm
            // 
            this.BackgroundImage = global::Voucher_Paper_Wallet.Properties.Resources.paper;
            this.ClientSize = new System.Drawing.Size(1199, 604);
            this.Controls.Add(this.lbl_design);
            this.Controls.Add(this.combo_design);
            this.Controls.Add(this.check_showPW);
            this.Controls.Add(this.btn_generate);
            this.Controls.Add(this.check_rawsk);
            this.Controls.Add(this.txt_walletname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.check_mobile);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_save);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "n e m  |  paper wallet & voucher generator";
            this.Load += new System.EventHandler(this.Form_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picbox_sk_raw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_Address)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_sk_mobile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_sk;
        private System.Windows.Forms.Label lbl_Address;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox picbox_Address;
        private System.Windows.Forms.PictureBox picbox_sk_mobile;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_raw_format;
        private System.Windows.Forms.PictureBox picbox_sk_raw;
        private System.Windows.Forms.Label lbl_mob_format;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.CheckBox check_mobile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_walletname;
        private System.Windows.Forms.CheckBox check_rawsk;
        private System.Windows.Forms.Button btn_generate;
        private System.Windows.Forms.CheckBox check_showPW;
        private System.Windows.Forms.ComboBox combo_design;
        private System.Windows.Forms.Label lbl_design;
    }
}

