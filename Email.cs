using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net.Mail;
using System.Windows.Forms;


namespace JavierS
{
    class Email
    {
        private string path;
        private string to;

        public Email(string path, string to)
        {

            this.path = path;
            this.to = to;
        }


        public void sendSupplierEmail()
        {

            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress("nitozsimmora@gmail.com");
                mail.To.Add(this.to);
                mail.Subject = "New order from Javier Simora Israel";
                mail.Body = "Hello, this is a new order from Javier Simora Israel please  confirm the order";

                System.Net.Mail.Attachment attachment;
                attachment = new System.Net.Mail.Attachment(this.path);
                mail.Attachments.Add(attachment);


                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("nitozsimmora", "javiersimora10");
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
                MessageBox.Show("mail Send");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void sendCustomerEmail(int orderId)
        {

            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
                string idTostring =orderId.ToString();
                mail.From = new MailAddress("nitozsimmora@gmail.com");
                mail.To.Add(this.to);
                mail.Subject = "Order confirmed-Javier Simora Israel";
                mail.Body = "Hello, order number:" + idTostring + " has been confirmed by the supplier";
                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("nitozsimmora", "javiersimora10");
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
                MessageBox.Show("mail Send");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


    }
}

