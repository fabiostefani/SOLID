using System.Net.Mail;

namespace fabiostefani.io.solid.srp
{
    public class SmtpClientFake : SmtpClient
    {
        public SmtpClientFake(string smtp) 
            : base(smtp)
        {
            
        }
        public void SendEmail(MailMessage mailMessage)
        {
            
        }
    }
}