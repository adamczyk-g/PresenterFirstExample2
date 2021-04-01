using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using PresenterFirstExample2.Model;
using PresenterFirstExample2.Presenter;

namespace PresenterFirstExample2.View
{
    static class Program
    {
        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            SimpleEmailValidator emailValidator = new Model.SimpleEmailValidator();
            IFormValidator formValidator = new FormValidator(emailValidator);
            
            IFormView view = new FormView();
            IFormModel model = new FormModel(formValidator);
            FormPresenter prezenter = new FormPresenter(view, model);

            Application.Run((Form)view);
        }
    }
}
