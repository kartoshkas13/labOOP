using System;

namespace ComplexStringApp
{
    public class ComplexNumber : StringBase, IComplexActions
    {
        private int real;
        private int imag;

        public ComplexNumber() : base()
        {
            SetZero();
        }

        public ComplexNumber(string s) : base(s)
        {
            Parse();
        }

        public ComplexNumber(int r, int i) : base("")
        {
            real = r;
            imag = i;
            UpdateString();
        }

        public int Real
        {
            get { return real; }
        }

        public int Imag
        {
            get { return imag; }
        }

        private void Parse()
        {
            string s = str.Replace(" ", "");

            if (string.IsNullOrEmpty(s))
                throw new Exception("Порожній рядок");

            if (!s.EndsWith("i"))
                throw new Exception("Число має закінчуватись на i");

            string withoutI = s.Substring(0, s.Length - 1);

            int pos = -1;

            for (int i = 1; i < withoutI.Length; i++)
            {
                if (withoutI[i] == '+' || withoutI[i] == '-')
                {
                    pos = i;
                    break;
                }
            }

            if (pos == -1)
                throw new Exception("Неправильний формат комплексного числа");

            string realPart = withoutI.Substring(0, pos);
            string imagPart = withoutI.Substring(pos);

            if (!IsValidPart(realPart) || !IsValidPart(imagPart))
                throw new Exception("Неправильні частини числа");

            real = int.Parse(realPart);
            imag = int.Parse(imagPart);

            UpdateString();
        }

        private bool IsValidPart(string part)
        {
            if (string.IsNullOrEmpty(part))
                return false;

            for (int i = 0; i < part.Length; i++)
            {
                if (i == 0 && (part[i] == '+' || part[i] == '-'))
                    continue;

                if (!char.IsDigit(part[i]))
                    return false;
            }

            return true;
        }

        private void SetZero()
        {
            real = 0;
            imag = 0;
            str = "0+0i";
            length = (byte)str.Length;
        }

        private void UpdateString()
        {
            if (imag >= 0)
                str = real.ToString() + "+" + imag.ToString() + "i";
            else
                str = real.ToString() + imag.ToString() + "i";

            length = (byte)str.Length;
        }

        public bool IsEqual(ComplexNumber other)
        {
            if (other == null)
                throw new Exception("Об'єкт відсутній");

            return real == other.real && imag == other.imag;
        }

        public ComplexNumber Add(ComplexNumber other)
        {
            if (other == null)
                throw new Exception("Другий операнд відсутній");

            int newReal = real + other.real;
            int newImag = imag + other.imag;

            return new ComplexNumber(newReal, newImag);
        }

        public ComplexNumber Multiply(ComplexNumber other)
        {
            if (other == null)
                throw new Exception("Другий операнд відсутній");

            int newReal = real * other.real - imag * other.imag;
            int newImag = real * other.imag + imag * other.real;

            return new ComplexNumber(newReal, newImag);
        }

        public double Module()
        {
            return Math.Sqrt(real * real + imag * imag);
        }

        public override int CompareTo(object obj)
        {
            if (obj == null) return 1;

            ComplexNumber other = obj as ComplexNumber;
            if (other == null)
                throw new ArgumentException("Об'єкт не є ComplexNumber");

            return this.Module().CompareTo(other.Module());
        }

        public override object Clone()
        {
            return new ComplexNumber(this.real, this.imag);
        }

        public override string ToString()
        {
            return str;
        }
    }
}