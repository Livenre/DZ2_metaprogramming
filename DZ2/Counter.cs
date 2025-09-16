using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ2
{
    public sealed class Counter
    {
        private int _value;

        public int Value
        {
            get { return this._value; }
        }

        public Counter() : this(0) { }

        public Counter(int start)
        {
            if (start < 0)
            {
                throw new ArgumentException("Початкове значення не може бути від’ємним", nameof(start));
            }
            this._value = start;
        }

        public void Increment()
        {
            this._value++;
        }

        public void Decrement()
        {
            if (this._value == 0)
            {
                throw new Exception("Значення не може бути від’ємним");
            }
            this._value--;
        }

        public bool TryDecrement()
        {
            if (this._value == 0)
            {
                return false;
            }
            this._value--;
            return true;
        }

        public void Reset()
        {
            this._value = 0;
        }
    }

}










