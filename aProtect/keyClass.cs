using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aProtect
{
    public class keyClass
    {
        static string user = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
        static string dir = "C:\\" + user;
        static string file = "aprotectKey.txt";
        public static string fullPath = Path.Combine(dir, file);

        private object responseFromServer;

        public string callAPI(string codeLicence, string email, string password)
        {
            string dataJSON;
            string mac = getMACAdress();
            WebRequest request = WebRequest.Create("https://www.rpi-projet.pw/api/index.php?codeLicence=" + codeLicence + "&email=" + email + "&password=" + password + "&biosNumber=" + mac);
            request.Credentials = CredentialCache.DefaultCredentials;

            WebResponse response = request.GetResponse();
            Console.WriteLine(((HttpWebResponse)response).StatusDescription);
            using (Stream dataStream = response.GetResponseStream())
            {

                StreamReader reader = new StreamReader(dataStream);
                string responseFromServer = reader.ReadToEnd();
                dataJSON = responseFromServer;
            }

            response.Close();
            return dataJSON;
        }

        public bool checkLicence()
        {
            if(fileExist())
            {
                StreamReader dataRead = new StreamReader(fullPath);
                string MAC = dataRead.ReadLine();
                string codeLicence = dataRead.ReadLine();
                string dateExpiration = dataRead.ReadLine();
                string typeLicence = dataRead.ReadLine();
                dataRead.Close();

                DateTime currentDate = DateTime.Now;

                if (getMACAdress() == MAC)
                {
                    if(checkDate(dateExpiration))
                    {
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Votre licence a expiré ! Veuillez saisir une nouvelle clé d'activation", "LICENCE EXPIRÉE");
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("Licence non valide !", "ERREUR DE LICENCE");
                    return false;
                }
            }
            else
            {
                return false;
            }


            return false;
        }

        public static bool fileExist()
        {
            if(File.Exists(fullPath))
            {
                return true;
            }
            return false;
        }
        public static bool checkDate(string dateExpiration)
        {
            var dateExpirationConverted = Convert.ToDateTime(dateExpiration);
            DateTime currentDate = DateTime.Now;
            int res = DateTime.Compare(dateExpirationConverted, currentDate);
            if(res < 0)
            {
                return false;
            }
            else
            {
                return true;
            }
            return false;
        }


        public void writeFile(string[] line)
        {
            string email = line[2];
            string typeLicence = line[1];
            string dateExpiration = line[2];
            string codeLicence = line[3];
            DateTime startDate = DateTime.Parse(dateExpiration);
            startDate = startDate.Date;
            DateTime expiryDate = startDate.AddDays(30);

            DirectoryInfo di = Directory.CreateDirectory(dir);
            string[] data = { getMACAdress(), codeLicence, expiryDate.ToString(), typeLicence};
            File.WriteAllLines(fullPath, data);
        }


        public static string getMACAdress()
        {
            NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces();
            String sMacAddress = string.Empty;
            foreach (NetworkInterface adapter in nics)
            {
                if (sMacAddress == String.Empty)// only return MAC Address from first card  
                {
                    sMacAddress = adapter.GetPhysicalAddress().ToString();
                }
            }
            return sMacAddress;
        }

        public bool checkMACAdress(string macAdress)
        {
            if (getMACAdress() == macAdress)
            {
                return true;
            }
            return false;
        }

    }
}