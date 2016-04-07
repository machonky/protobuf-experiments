namespace DotNet
{
    partial class Decimal
    {
        public decimal ToDecimal()
        {
            return new decimal(new [] { Lo, Mid, Hi, SignScale });
        }

        public static implicit operator decimal(Decimal d)  
        {
            return d.ToDecimal();
        }

        public static implicit operator Decimal(decimal d)
        {
            int[] bytes = decimal.GetBits(d);
            var result = new Decimal
            {
                Lo = bytes[0],
                Mid = bytes[1],
                Hi = bytes[2],
                SignScale = bytes[3]
            };
            return result;
        }
    }
}
