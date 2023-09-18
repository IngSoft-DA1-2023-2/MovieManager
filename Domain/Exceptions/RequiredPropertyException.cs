namespace Domain.Exceptions
{
    public class RequiredPropertyException : Exception
    {
        public RequiredPropertyException(string message): base(message) { }
    }
}
