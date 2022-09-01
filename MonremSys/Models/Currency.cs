namespace MonremSys
{
    public enum CurrencyName
    {
        USD = 0,
        SYR = 1,
        EUR = 2,
        LBP = 3,
        ETB = 4,
        CNY = 5
    };

    class Currency
    {
        private CurrencyName name;
        private float rate = 1;

        public float Rate {get => rate; set => rate = value; } // Rate Property

        public CurrencyName Name { get => name; set => name = value; }

        public int Cindex
        {
            get { return (int)name; }
            set
            {
                name = (CurrencyName)value;
            }
        }

        // Validation Property
        public bool IsValid => (Rate > 0);

        public override string ToString()
        {
            return $"{Name} /{Rate}";
        }

        
    }
}
