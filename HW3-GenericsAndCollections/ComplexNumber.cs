namespace HW3_GenericsAndCollections
{
    public readonly struct ComplexNumber<T> where T : notnull
    {
        private readonly T re;
        private readonly T im;

        static ComplexNumber()
        {
            var typeCode = Type.GetTypeCode(typeof(T));
            bool isNumeric = typeCode == TypeCode.Decimal || typeCode == TypeCode.Double ||
                             typeCode == TypeCode.Single || typeCode == TypeCode.Int32 ||
                             typeCode == TypeCode.Int64 || typeCode == TypeCode.UInt32 ||
                             typeCode == TypeCode.UInt64;

            if (!isNumeric)
                throw new InvalidOperationException($"{typeof(T).Name} is not a supported numeric type for ComplexNumber");
        }

        public ComplexNumber(T real, T imaginary)
        {
            re = real;
            im = imaginary;
        }

        public T Real => re;
        public T Imaginary => im;

        public static ComplexNumber<T> operator +(ComplexNumber<T> a, ComplexNumber<T> b)
        {
            dynamic reA = a.Real, imA = a.Imaginary;
            dynamic reB = b.Real, imB = b.Imaginary;
            return new ComplexNumber<T>(reA + reB, imA + imB);
        }

        public static ComplexNumber<T> operator -(ComplexNumber<T> a, ComplexNumber<T> b)
        {
            dynamic reA = a.Real, imA = a.Imaginary;
            dynamic reB = b.Real, imB = b.Imaginary;
            return new ComplexNumber<T>(reA - reB, imA - imB);
        }

        public void Print()
        {
            Console.WriteLine($"Complex number: {re} + {im}i");
        }
    }
}
