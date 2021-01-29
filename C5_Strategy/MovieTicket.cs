namespace C5_Strategy
{
    /// <summary>
    /// 环境类(context)：电影票MovieTicket
    /// </summary>
    public class MovieTicket
    {
        public double _price { get; set; }
        private IDiscount _discount;

        public double Price
        {
            get
            {
                return _discount.Calculate(_price);
            }
        }

        public IDiscount Discount
        {
            set
            {
                _discount = value;
            }
        }
    }
}