using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NemApi;
using ZXing;
using SimpleCrypto;
using ikvm;
using System.Text.RegularExpressions;


namespace Voucher_Paper_Wallet
{
    public partial class MainForm : System.Windows.Forms.Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form_Load(object sender, EventArgs e)
        {
            combo_design.Items.Add("Jabo38's voucher wallet design");
            combo_design.Items.Add("NEM 1 voucher wallet design");
            combo_design.Items.Add("NEM 2 voucher wallet design");
            combo_design.SelectedIndex = 0;
            panel1.BackgroundImage = Voucher_Paper_Wallet.Properties.Resources.Jabo_Paper_Wallet_1200_480;
            blank_voucher();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            save();
        }

        private void generate()
        {
            if ((!check_rawsk.Checked) && (!check_mobile.Checked))
            {
                MessageBox.Show("You need to include at least one private key format.", "Select private key format");
                return;
            }

            int voucher_amount = 1;
            if (check_bulk.Checked)
            {
                voucher_amount = Convert.ToInt32(numericUpDown_blk_amount.Value);
            }

            for (int icount = 0; icount < voucher_amount; icount++)
            {
                string sk;
                using (RandomNumberGenerator rng = new RNGCryptoServiceProvider())
                {
                    byte[] tokenData = new byte[32];
                    rng.GetBytes(tokenData);

                    sk = ByteArrayToString(tokenData);
                }

                if (check_ownKey.Checked)
                {
                    if (!String.IsNullOrEmpty(txt_customKey.Text) && txt_customKey.Text.Length.Equals(64) && System.Text.RegularExpressions.Regex.IsMatch(txt_customKey.Text, @"\A\b[0-9a-fA-F]+\b\Z"))
                    {
                        sk = txt_customKey.Text;
                    }
                    else
                    {
                        MessageBox.Show("Your custom private key is not compatible - it must be a HEX string with 64 characters.", "Please provide a valid private key", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }


                // Testdata
                //string privateKey = "abf4cf55a2b3f742d7543d9cc17f50447b969e6e06f5ea9195d428ab12b7318d";

                string address = AddressEncoding.ToEncoded(0x68, new PublicKey(new PrivateKey(sk)));
                string splitaddress = address.Substring(0, 20) + Environment.NewLine + address.Substring(20, address.Length - 20);
                string walletname = "";

                lbl_Address.Text = splitaddress;

                if (check_mobile.Checked)
                {
                    string password = txt_password.Text;
                    if (check_rnd_password.Checked)
                    {
                        string dictionaryString = "abcdefghijkmnopqrstuvwxyzABCDEFGHJKLMNPRSTUVWXYZ23456789";
                        StringBuilder resultStringBuilder = new StringBuilder();
                        Random rd = new Random();
                        for (int i = 0; i < 8; i++)
                        {
                            resultStringBuilder.Append(dictionaryString[rd.Next(dictionaryString.Length)]);
                        }
                        password = resultStringBuilder.ToString();

                    }
                    if ((password.Equals("")) | (password.Length < 6))
                    {
                        MessageBox.Show("For mobile wallet support you need to provide a password with at least 6 characters.", "Provide password", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    walletname = txt_walletname.Text;
                    if ((walletname.Equals("")) | (walletname.Length < 1))
                    {
                        MessageBox.Show("For mobile wallet support you need to provide a wallet name.", "Provide name", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    if ((!Regex.IsMatch(walletname, @"^[a-zA-Z0-9]+$")) || (!Regex.IsMatch(password, @"^[a-zA-Z0-9]+$")))
                        MessageBox.Show("Your password or walletname contains special or country specific characters, this is not fully tested, please assure you can import the wallet before sending XEM to it!", "Special characters in use", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Generate salt
                    string salt;
                    using (RandomNumberGenerator rng = new RNGCryptoServiceProvider())
                    {
                        byte[] tokenData = new byte[32];
                        rng.GetBytes(tokenData);

                        salt = ByteArrayToString(tokenData);
                    }

                    String sk_encoded = voucher.GenEncsk(txt_walletname.Text, password, sk, salt);

                    //generate secret encoded key qrcode
                    IBarcodeWriter writerskencoded = new BarcodeWriter
                    {
                        Format = BarcodeFormat.QR_CODE,
                        Options = new ZXing.Common.EncodingOptions
                        {
                            Width = 200,
                            Height = 200,
                        }
                    };
                    var codesk = writerskencoded.Write(sk_encoded);
                    var barcodeBitmapsk = new Bitmap(codesk);
                    picbox_sk_mobile.Image = barcodeBitmapsk;

                    picbox_sk_mobile.Visible = true;
                    lbl_mob_format.Visible = true;
                    if (check_showPW.Checked)
                    {
                        lbl_password.Text = "Import password: " + password;
                        lbl_password.Visible = true;
                    }
                }


                if (check_rawsk.Checked)
                {
                    //generate secret raw key qrcode
                    IBarcodeWriter writerskraw = new BarcodeWriter
                    {
                        Format = BarcodeFormat.QR_CODE,
                        Options = new ZXing.Common.EncodingOptions
                        {
                            Width = 130,
                            Height = 130,
                        }
                    };
                    var codeskraw = writerskraw.Write(sk);
                    var barcodeBitmapskraw = new Bitmap(codeskraw);
                    picbox_sk_raw.Image = barcodeBitmapskraw;
                    picbox_sk_raw.Visible = true;

                    lbl_sk.Text = "";
                    for (int i = 0; i < 64; i += 8)
                    { lbl_sk.Text = lbl_sk.Text + (sk.Substring(i, 8).ToUpper() + Environment.NewLine); }

                    //lbl_sk.Text = sk;
                    lbl_sk.Visible = true;
                    lbl_raw_format.Visible = true;
                }

                //generate NEM address qrcode
                string address_qr = "{\"v\":2,\"type\":1,\"data\":{\"addr\":\"" + address + "\",\"name\":\"" + walletname + "\"}}";
                IBarcodeWriter writeradress = new BarcodeWriter
                {
                    Format = BarcodeFormat.QR_CODE,
                    Options = new ZXing.Common.EncodingOptions
                    {
                        Width = 150,
                        Height = 150
                    }
                };

                var codeadress = writeradress.Write(address_qr);
                var barcodeBitmapAddress = new Bitmap(codeadress);
                picbox_Address.Image = barcodeBitmapAddress;
                picbox_Address.Visible = true;
                lbl_Address.Visible = true;


                if (check_bulk.Checked)
                {
                    string file = address + ".jpg";
                    save(file);
                }
                //string expected = "NAZQOWGZJ5PKR3QJEUZEMS6MXQX3WZZZAKKTLPZT";
            }
        }

        private void save(string file = null)
        {
            using (Bitmap bmp = new Bitmap(panel1.Width, panel1.Height))
            {

                panel1.DrawToBitmap(bmp, new Rectangle(Point.Empty, bmp.Size));

                // Some testing here: Mono pictures are not rendered correctly, could be related to 'controls inside containers are rendered in reverse order' - more investigation required
                //panel1.DrawToBitmap(bmp, new Rectangle(0,0, panel1.Width, panel1.Height));
                //foreach (Control control in panel1.Controls)
                //{
                //    DrawControl(control, bmp);
                //}

                if (string.IsNullOrEmpty(file))
                {
                    SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                    saveFileDialog1.Filter = "PNG Image|*.png|JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif";
                    saveFileDialog1.Title = "Save voucher to image file";
                    saveFileDialog1.ShowDialog();
                    if (saveFileDialog1.FileName != "")
                    {
                        System.IO.FileStream fs =
                            (System.IO.FileStream)saveFileDialog1.OpenFile();
                        switch (saveFileDialog1.FilterIndex)
                        {
                            case 1:
                                bmp.Save(fs,
                                    System.Drawing.Imaging.ImageFormat.Png);
                                break;
                            case 2:
                                bmp.Save(fs,
                                    System.Drawing.Imaging.ImageFormat.Jpeg);
                                break;

                            case 3:
                                bmp.Save(fs,
                                    System.Drawing.Imaging.ImageFormat.Bmp);
                                break;

                            case 4:
                                bmp.Save(fs,
                                    System.Drawing.Imaging.ImageFormat.Gif);
                                break;
                        }
                        fs.Close();
                        MessageBox.Show("Voucher saved as " + saveFileDialog1.FileName, "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    System.IO.FileStream fs = new System.IO.FileStream(file, System.IO.FileMode.CreateNew);
                    bmp.Save(fs, System.Drawing.Imaging.ImageFormat.Jpeg);
                    fs.Close();
                }
            }
        }

        // Some testing here: Mono pictures are not rendered correctly, could be related to 'controls inside containers are rendered in reverse order' - more investigation required
        //public void DrawControl(Control control, Bitmap bitmap)
        //{
        //    control.DrawToBitmap(bitmap, control.Bounds);
        //    foreach (Control childControl in control.Controls)
        //    {
        //        DrawControl(childControl, bitmap);
        //    }
        //}

        private string PBKDF2_sk_string(string password, string sk)
        {
            int SALT_SIZE = 32;
            int HASH_ITERATIONS = 2000;

            ICryptoService cryptoService = new PBKDF2();
            password.ToCharArray();

            string salt = cryptoService.GenerateSalt(HASH_ITERATIONS, SALT_SIZE);

            string encrypted_sk = cryptoService.Compute(password, salt);
            return encrypted_sk;
        }

        private void btn_info_Click(object sender, EventArgs e)
        {
            Info aboutWindow = new Info();
            aboutWindow.Show();
        }

        private void btn_generate_Click(object sender, EventArgs e)
        {
            blank_voucher();
            generate();
        }

        private void blank_voucher()
        {
            picbox_Address.Visible = false;
            picbox_sk_mobile.Visible = false;
            picbox_sk_raw.Visible = false;
            lbl_Address.Visible = false;
            lbl_mob_format.Visible = false;
            lbl_password.Visible = false;
            lbl_sk.Visible = false;
            lbl_raw_format.Visible = false;
        }

        public static string ByteArrayToString(byte[] ba)
        {
            StringBuilder hex = new StringBuilder(ba.Length * 2);
            foreach (byte b in ba)
                hex.AppendFormat("{0:x2}", b);
            return hex.ToString();
        }

        private void check_CheckedChanged(object sender, EventArgs e)
        {
            blank_voucher();
        }

        private void check_mobile_CheckedChanged(object sender, EventArgs e)
        {
            blank_voucher();
            if (check_mobile.Checked)
            {
                txt_password.Enabled = true;
                txt_walletname.Enabled = true;
                check_showPW.Enabled = true;
                check_rnd_password.Enabled = true;
            }
            else
            {
                check_rnd_password.Checked = false;
                txt_password.Enabled = false;
                txt_walletname.Enabled = false;
                txt_password.Text = "";
                txt_walletname.Text = "";
                check_showPW.Enabled = false;
                check_rnd_password.Enabled = false;
            }
        }

        private void check_rawsk_CheckedChanged(object sender, EventArgs e)
        {
            blank_voucher();
        }

        private void txt_password_TextChanged(object sender, EventArgs e)
        {
            blank_voucher();
        }

        private void txt_walletname_TextChanged(object sender, EventArgs e)
        {
            blank_voucher();
        }

        private void combo_design_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combo_design.SelectedItem.ToString() == "Jabo38's voucher wallet design")
                panel1.BackgroundImage = Voucher_Paper_Wallet.Properties.Resources.Jabo_Paper_Wallet_1200_480;
            else if (combo_design.SelectedItem.ToString() == "NEM 1 voucher wallet design")
                panel1.BackgroundImage = Voucher_Paper_Wallet.Properties.Resources.vpw1;
            else if (combo_design.SelectedItem.ToString() == "NEM 2 voucher wallet design")
                panel1.BackgroundImage = Voucher_Paper_Wallet.Properties.Resources.vpw2;
        }

        private void check_ownKey_CheckedChanged(object sender, EventArgs e)
        {
            blank_voucher();
            if (check_ownKey.Checked)
            {
                txt_customKey.Enabled = true;
            }
            else
            {
                txt_customKey.Enabled = false;
                txt_customKey.Text = "";
            }
        }

        private void check_bulk_CheckedChanged(object sender, EventArgs e)
        {
            blank_voucher();
            if (check_bulk.Checked)
            {
                numericUpDown_blk_amount.Enabled = true;
            }
            else
            {
                numericUpDown_blk_amount.Enabled = false;
                numericUpDown_blk_amount.Value = 1;
            }
        }

        private void check_rnd_password_CheckedChanged(object sender, EventArgs e)
        {
            blank_voucher();
            if (check_rnd_password.Checked)
            {
                txt_password.Enabled = false;
                txt_password.Text = "";
                check_showPW.Checked = true;
                check_showPW.Enabled = false;
            }
            else
            {
                txt_password.Enabled = true;
                check_showPW.Enabled = true;
                check_showPW.Checked = true;
            }
        }
    }
}