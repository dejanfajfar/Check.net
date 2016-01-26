using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Check.net
{
    public class Checker<T>
    {
        public T Value { get;  }

        public Checker(T value)
        {
            Value = value;
        }

        #region Modifiers

        public Checker<T> Is
        {
            get
            {
                return this;
            }
        }

        public Checker<T> Not
        {
            get
            {
                return this;
            }
        }

        #endregion

        public void Null<T>(string message = "The given value is not null")
        {
            if (Value == null)
            {
                throw new CheckException(message);
            }
        }
    }
}
