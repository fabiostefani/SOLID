using System.Net;
using System.Net.Mail;

namespace fabiostefani.io.solid.srp
{
    public class EnviarEmailFuncionario
    {
        private readonly FuncionarioSolucao funcionario;
        public EnviarEmailFuncionario(FuncionarioSolucao funcionario)
        {
            this.funcionario = funcionario;

        }

        public void Enviar()
        {
            MailMessage mail = new MailMessage();            
            mail.From = new MailAddress("fabiostefani@gmail.com");
            mail.To.Add("fabiostefani@gmail.com");
            mail.Subject = "Processamento de Imposto";
            mail.Body = "Seu imposto foi processado";            
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