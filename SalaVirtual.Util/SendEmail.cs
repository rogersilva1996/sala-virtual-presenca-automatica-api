using System;
using System.Net;
using System.Net.Mail;

namespace SalaVirtual.Util
{
    public class SendEmail
    {
        public void Email(string email, string senha)
        {

            MailMessage mail = new MailMessage();


            mail.From = new MailAddress("VirtualClassRoomRecover@outlook.com");
            mail.Subject = "Teste de email";
            mail.IsBodyHtml = true;

            mail.Body = BodyEmail(senha);

            mail.To.Add(email);

            SmtpClient smtp = new SmtpClient("smtp-mail.outlook.com");
            smtp.UseDefaultCredentials = true;
            smtp.EnableSsl = true;
            smtp.Port = 587;

            smtp.Credentials = new NetworkCredential("VirtualClassRoomRecover@outlook.com", "987ClassRom");

            smtp.Send(mail);
        }

        private string BodyEmail(string senha)
        {
            string css = "a";
            string conteudo = "<!DOCTYPE html>" +
                              "<html>" +
                              "<body>" +
                              "<style>" +
                              "div.a {text-align: center;}" +
                              "</style>" +
                              "<div class=" + css + ">" +
                              "<h2>Recuperação de senha</h2>" +
                              "<a>"+ senha +"</a>" +
                              "</div>" +
                              "</body>" +
                              "</html>";
    
            return conteudo;
        }
    }
}
