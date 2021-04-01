namespace PresenterFirstExample1.Model
{
    public interface IFormModel
    {
        Notification ValidateForm(FormData formData, EmailData emailData);
        Pdf GeneratePdf(FormData formData);
        EmailSendingResult EmailFile(EmailData email, Pdf pdf);
        FormData DefaultFormData { get; }
    }
}
