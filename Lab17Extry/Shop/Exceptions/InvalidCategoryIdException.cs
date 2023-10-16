using System.Runtime.Serialization;

namespace Lab17Extry.Shop.Exceptions
{
    [Serializable]
    internal class InvalidCategoryIdException : Exception
    {
        public InvalidCategoryIdException()
        {
        }

        public InvalidCategoryIdException(string? message) : base(message)
        {
        }

        public InvalidCategoryIdException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected InvalidCategoryIdException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}