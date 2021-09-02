using System.Net;
using System.Net.Mail;

namespace fabiostefani.io.solid.srp
{
    public class FuncionarioViolacao
    {
        const int IMPOSTO = 10;
        public string Nome { get; private set; }
        public double Salario { get; private set; }
        public FuncionarioViolacao(string nome, double salario)
        {
            Nome = nome;
            Salario = salario;
        }

        public double CalcularImposto()
        {
            return (Salario * IMPOSTO)/100;
        }

        public void EnviarEmail()
        {
            MailMessage mail = new MailMessage();            
            mail.From = new MailAddress("fabiostefani@gmail.com");
            mail.To.Add("fabiostefani@gmail.com");
            mail.Subject = "Este é um simples ,muito simples email";
            mail.Body = "Este é o corpo do email";                        
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
