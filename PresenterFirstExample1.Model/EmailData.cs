namespace PresenterFirstExample1.Model
{
    public class EmailData
    {
        public EmailData(string toAddress, string smtpHost)
        {
            ToAddress = toAddress;
            SmtpHost = smtpHost;
        }

        public string ToAddress { get; }
        public string SmtpHost { get; }
    }
}
