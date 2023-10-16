using System.Runtime.Serialization;

namespace Lab17Extry.Shop.Exceptions
{
    [Serializable]
    internal class InvalidManufacturerIdException : Exception
    {
        public InvalidManufacturerIdException()
        {
        }

        public InvalidManufacturerIdException(string? message) : base(message)
        {
        }

        public InvalidManufacturerIdException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected InvalidManufacturerIdException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}