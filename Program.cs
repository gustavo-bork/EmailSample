using System.Net;
using System.Net.Mail;

try {
  DotNetEnv.Env.Load();
  var smtp = new SmtpClient() {
    Host = "smtp.gmail.com",
    Port = 587,
    EnableSsl = true,
    DeliveryMethod = SmtpDeliveryMethod.Network,
    UseDefaultCredentials = false,
    Credentials = new NetworkCredential("tarrskp@gmail.com", Environment.GetEnvironmentVariable("SENHA"))
  };
  
  smtp.Send("tarrskp@gmail.com", "gubork@gmail.com", "Teste", "Teste de envio de E-Mail");
} catch (SmtpException ex) {
  Console.WriteLine(ex.ToString());
}