using FormularioProposta.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace FormularioProposta.Library.Mail
{
    public class SendMail
    {
        public static void EnviarMensagemContato(Proposta proposta)
        {
            

            SmtpClient smtp = new SmtpClient(Constants.ServidorSMTP, Constants.PortaSMTP);
            smtp.EnableSsl = true;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential(Constants.Usuario, Constants.Senha);

            MailMessage mensagem = new MailMessage();
            mensagem.From = new MailAddress("mumbs05 @gmail.com");
            mensagem.To.Add("antonioletic@gmail.com");
            mensagem.Subject = "Nova Proposta";
            mensagem.IsBodyHtml = true;
            mensagem.Body = "";
            smtp.Send(mensagem);


        }
    }
}
