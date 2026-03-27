namespace ComplexStringApp
{
    public interface IComplexActions
    {
        bool IsEqual(ComplexNumber other);
        ComplexNumber Add(ComplexNumber other);
        ComplexNumber Multiply(ComplexNumber other);
    }
}
