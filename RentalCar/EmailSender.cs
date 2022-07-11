using FluentEmail.Core;
using FluentEmail.Smtp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace RentalCar
{
    class EmailSender
    {
        public void Sender(string toemail, string name, int code)
        {
            SmtpClient smtp = new SmtpClient()
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential()
                {
                    UserName = "xxxxxxx", //Adres email z którego będziesz wysyłać maila
                    Password = "xxxxxxx" // Hasło do tego maila
                }
            };
            MailAddress fromMail = new MailAddress("emailaddress"); //Adres email nadawcy
            MailAddress toMail = new MailAddress(toemail); //Adres email odbiorcy
            MailMessage mailMessage = new MailMessage()
            {
                From = fromMail,
                Subject = "Activate Code",
                Body = ("Hello"+name+ ", We are glad that you want to use our platform. Enter the following code to activate your account: "+code.ToString()),
            };
            mailMessage.To.Add(toMail);
            smtp.SendMailAsync(mailMessage);

        } 
    }
}