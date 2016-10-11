using System.Collections.Generic;

namespace Mocking
{
    public class MailBox : IMailModule
    {
        
        public int NumReceivedMessages { get; set; }

        List<Mail> Mails = new List<Mail>();
        public MailBox()
        {
        }

        

        public void Add(Mail mail)
        {
            Mails.Add(mail);
        }

        public string GetLatestMessageText()
        {
            NumReceivedMessages = Mails.Count;
            return Mails[NumReceivedMessages - 1].Content;
        }

        public void SendMail(Mail mail, Employee employee)
        {
            employee.MailBox.Add(mail);
        }

        public Mail GetEmailById(int id)
        {
            throw new System.NotImplementedException();
        }

        public void AddToDraft(Mail mail)
        {
            throw new System.NotImplementedException();
        }

        public void AddToSentMessages(Mail mail)
        {
            throw new System.NotImplementedException();
        }

        public void AddToSentSpam(Mail mail)
        {
            throw new System.NotImplementedException();
        }

        public List<Mail> GetAllMail()
        {
            throw new System.NotImplementedException();
        }
    }
}