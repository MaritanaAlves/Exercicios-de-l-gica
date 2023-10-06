namespace _4_CalculateValue
{
    public class Product
    {
        public int Code { get; set; }
        public int Amount { get; set; }
        public double Value { get; set; }

        public Product(int code, int amount, double value)
        {
            Code = code;
            Amount = amount;
            Value = value;
        }

        public double TotalValue(int amount, double value)
        {
            return amount * value;
        }
    }
}
