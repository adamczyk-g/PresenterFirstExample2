using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresenterFirstExample1.Model
{
    public interface EmailValidator
    {
        bool Validate(string email);
    }
}
