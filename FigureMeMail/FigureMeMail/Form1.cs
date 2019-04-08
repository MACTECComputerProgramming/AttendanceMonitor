using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;




namespace FigureMeMail
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {




            //TextBox passtexbox = new TextBox();
            //    passtexbox.PasswordChar = '*';

                string gMailAcount = usernameTextBox.Text;
                string password = passtexbox.Text;
                string to = totextbox.Text;
                string subject = subjecttextbox.Text;
                string message, emailid;

                NetworkCredential loginInfo = new NetworkCredential(gMailAcount, password);
                MailMessage msg = new MailMessage();
                msg.From = new MailAddress(gMailAcount);
                msg.To.Add(new MailAddress(to));
                msg.Subject = subject;
                msg.Body = messagetextbox.Text;
                msg.IsBodyHtml = true;

                try
                {
                    SmtpClient client = new SmtpClient("smtp.gmail.com");
                    client.EnableSsl = true;
                    client.UseDefaultCredentials = false;
                    client.Credentials = loginInfo;
                    client.Send(msg);
                  //  MessageBox.Show("Send Successfully");
                }

                catch (Exception ex)
                {

                    Console.WriteLine(ex);

                }
            

        }
    }
}
