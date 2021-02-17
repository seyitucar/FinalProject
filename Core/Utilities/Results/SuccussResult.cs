using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class SuccussResult:Result
    {
        public SuccussResult(string message):base(true, message)
        {

        }

        public SuccussResult():base(true)
        {

        }

    }
}
