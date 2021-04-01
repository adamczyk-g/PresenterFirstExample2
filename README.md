
# MVP Presenter First example

After reading the article ["Is Presenter First Still Valuable to Modern App Architecture?"](https://spin.atomicobject.com/2015/03/11/presenter-first-modern-architecture/) I decided to expand the examples of the Presenter implementation shown there. Based on the original Java examples, I created complete C# projects that also included unit tests and the user interface.

The second example is a presenter working with a stateless model too. The role of the presenter is more modest here. The model has a smaller interface and protects its data better.

An original example, that was the starting point for this project:

```Java
OnSubmit:
    formData = view.FormData();
    result = model.TryEmailFormAsPdf(view.FormData(), view.Email());
    if (result == EmailFormResult.InvalidFormData) {
        view.DisplayValidationResult(result.FormValidationResult());
    } else if (result == EmailFormResult.InvalidEmail) {
        view.DisplayEmailError();
    }
