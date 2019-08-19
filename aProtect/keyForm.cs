using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aProtect
{
    public partial class keyForm : Form
    {
        public static string code;
        public static string type;
        public static string dateAchat;
        public static string codeLicence;
        static string user = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
        static string dir = "C:\\" + user;
        static string file = "aprotectKey.txt";
        static string fullPath = Path.Combine(dir, file);
        public bool jobDone = false;

        public keyForm()
        {
            InitializeComponent();
        }

        private void MainPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void MainTitle_Click(object sender, EventArgs e)
        {

        }

        private void MainLabelMail_Click(object sender, EventArgs e)
        {

        }

        private void MainLabelProductKey_Click(object sender, EventArgs e)
        {

        }

        private void MainTextBoxEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void MainTextBoxKey_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void MainButtonWebsite_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.rpi-projet.pw/");

        }

        private void MainButtonActivate_Click(object sender, EventArgs e)
        {
            keyClass licence = new keyClass();

            if (!licence.checkLicence())
            {
                string codeLicence = mainTextBoxKey.Text;
                string email = mainTextBoxEmail.Text;
                string password = textBoxPassword.Text;

                string resultAPI = licence.callAPI(codeLicence, email, password);
                string res = resultAPI;
                Console.WriteLine(res);

                code = res[37].ToString() + res[38].ToString() + res[39].ToString() + res[40].ToString() + res[41].ToString();
                type = res[77].ToString();
                dateAchat = res[112].ToString() + res[113].ToString() + res[114].ToString() + res[115].ToString() + res[116].ToString() + res[117].ToString() + res[118].ToString() + res[119].ToString() + res[120].ToString() + res[121].ToString();
                codeLicence = res[158].ToString() + res[159].ToString() + res[160].ToString() + res[161].ToString()
                                                  + res[162].ToString() + res[163].ToString() + res[164].ToString() + res[165].ToString() + res[166].ToString() + res[167].ToString() + res[168].ToString() + res[169].ToString()
                                                  + res[170].ToString() + res[171].ToString() + res[172].ToString() + res[173].ToString() + res[174].ToString() + res[175].ToString();
                string[] text = { code, type, dateAchat, codeLicence };

                licence.writeFile(text);
                jobDone = true;
                Console.WriteLine("JOBS IS DONE: " + jobDone);
                this.Close();
            }
            else
            {
                Console.WriteLine("OUI");
                this.Close();
            }
                
            

        }

        private void MainButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void KeyForm_Load(object sender, EventArgs e)
        {

        }

        private void PasswordLabel_Click(object sender, EventArgs e)
        {

        }

        private void TextBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
