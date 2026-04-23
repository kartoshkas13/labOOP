using System;

namespace ComplexStringApp
{
    public abstract class StringBase : IComparable, ICloneable
    {
        protected string str;
        protected byte length;

        public StringBase()
        {
            str = "";
            length = 0;
        }

        public StringBase(string s)
        {
            str = s;
            length = (byte)s.Length;
        }

        public StringBase(char c)
        {
            str = c.ToString();
            length = 1;
        }

        public byte GetLength()
        {
            return length;
        }

        public void Clear()
        {
            str = "";
            length = 0;
        }

        public string GetString()
        {
            return str;
        }

        public virtual int CompareTo(object obj)
        {
            if (obj == null) return 1;

            StringBase other = obj as StringBase;
            if (other == null)
                throw new ArgumentException("Об'єкт не є StringBase");

            return this.str.CompareTo(other.str);
        }

        public virtual object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}