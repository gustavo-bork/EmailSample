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
    Credentials = new NetworkCredential(
      Environment.GetEnvironmentVariable("FROM_EMAIL"),
      Environment.GetEnvironmentVariable("PASSWORD")
    )
  };
  
  smtp.Send(
    Environment.GetEnvironmentVariable("FROM_EMAIL"),
    Environment.GetEnvironmentVariable("TO_EMAIL"),
    "Teste",
    "Teste de envio de E-Mail"
  );
} catch (SmtpException ex) {
  Console.WriteLine(ex.ToString());
}