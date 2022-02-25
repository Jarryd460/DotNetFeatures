namespace BoxingUnboxing
{
    public class BoxingService
    {
        public object BoxValue(int number)
        {
            return number;
        }

        public int UnboxValue(object value)
        {
            return (int)value;
        }

        public int SimpleReturnInt(int number)
        {
            return number;
        }

        public object SimpleReturnObject(object value)
        {
            return value;
        }
    }
}
