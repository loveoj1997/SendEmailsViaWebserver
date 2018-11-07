using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Mail;
using System.Web.Services;


namespace email
{
    /// <summary>
    /// WebService1 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消注释以下行。 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {
        System.Net.Mail.SmtpClient smtpClient = null;

        [WebMethod(Description = "sendemail")]
        public string Send(string pProductNom, string pToEmail, string pSubject, string pBody)
        {
            try
            {
                this.smtpClient = new System.Net.Mail.SmtpClient();
                this.smtpClient.Host = "smtp.qq.com";
                this.smtpClient.Port = 25;
                this.smtpClient.Timeout = 60 * 1000;

                string mFrom = "";//type your email address
                string mPassword = "";//type your password
                string mDisplayName = "";//diy a name for yourself

                this.smtpClient.UseDefaultCredentials = true;
                this.smtpClient.Credentials = new System.Net.NetworkCredential(mFrom, mPassword);

                MailMessage mailMessage = new MailMessage();
                mailMessage.From = new MailAddress(mFrom, mDisplayName, System.Text.Encoding.Unicode);
                mailMessage.To.Add(pToEmail);
                mailMessage.Subject = pSubject;
                mailMessage.Body = pBody;

                this.smtpClient.Send(mailMessage);

                return Boolean.TrueString;
            }
            catch (Exception ex)
            {
                return "Error" + ex.Message;
            }
        }
    }
}
