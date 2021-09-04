using System.Net;
using System.Net.Mail;

namespace fabiostefani.io.solid.srp
{
    public class EnviarEmail
    {        
        public void Enviar(string para, string assunto, string corpo)
        {
            MailMessage mail = new MailMessage();            
            mail.From = new MailAddress("fabiostefani@gmail.com");
            mail.To.Add(para);
            mail.Subject = assunto;
            mail.Body = corpo;            
            using (var smtp = new SmtpClient("smtp.gmail.com"))
            {
                smtp.EnableSsl = true;
                smtp.Port = 587;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.UseDefaultCredentials = false;                    
                smtp.Credentials = new NetworkCredential("fabiostefani@gmail.com", "Helen@.123");
                smtp.Send(mail);
            }
        }
    }
}