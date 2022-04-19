using System.Runtime.Serialization;

namespace LeapYear
{
    [Serializable]
    internal class LeapYearExeption : Exception
    {
        public LeapYearExeption()
        {
        }

        public LeapYearExeption(string? message) : base(message)
        {
        }

        public LeapYearExeption(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected LeapYearExeption(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}