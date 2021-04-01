namespace PresenterFirstExample2.Model
{
    public interface IFormValidator
    {
        Notification Validate(FormData formData, EmailData emailData);
    }
}
