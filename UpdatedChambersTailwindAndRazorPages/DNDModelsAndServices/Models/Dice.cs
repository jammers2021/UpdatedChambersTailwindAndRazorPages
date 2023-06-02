namespace UpdatedChambersTailwindAndRazorPages.DNDModelsAndServices.Models
{
    public class Dice
    {
        protected static readonly Random _random = new Random(DateTimeOffset.Now.Millisecond);

        private int LowerBound = 1;
        protected int DiceSize { get; set; }
        public virtual int Roll()
        {
            return _random.Next(LowerBound, DiceSize + 1);
        }
    }
    public class SizedDie : Dice
    {
        public SizedDie(int size)
        {
            DiceSize = size;
        }
    }

    public class D6 : Dice
    {
        public D6()
        {
            DiceSize = 6;
        }
    }
    public class D8 : Dice
    {
        public D8()
        {
            DiceSize = 8;
        }
    }
    public class D4 : Dice
    {
        public D4()
        {
            DiceSize = 4;
        }
    }
    public class D10 : Dice
    {
        public D10()
        {
            DiceSize = 10;
        }
    }
    public class D12 : Dice
    {
        public D12()
        {
            DiceSize = 12;
        }
    }
    public class D20 : Dice
    {
        public D20()
        {
            DiceSize = 20;
        }
    }
    public class D100 : Dice
    {
        public D100()
        {
            DiceSize = 100;
        }
    }
}

