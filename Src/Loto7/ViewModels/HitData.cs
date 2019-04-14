namespace Loto7.ViewModels
{
    public class HitData
    {
        public HitData(
            int first,
            int second,
            int third,
            int fourth,
            int fifth,
            int sixth,
            int seventh,
            int bonus1,
            int bonus2)
        {
            First = first;
            Second = second;
            Third = third;
            Fourth = fourth;
            Fifth = fifth;
            Sixth = sixth;
            Seventh = seventh;
            Bonus1 = bonus1;
            Bonus2 = bonus2;
        }

        public int First { get; }

        public int Second { get; }

        public int Third { get; }

        public int Fourth { get; }

        public int Fifth { get; }

        public int Sixth { get; }

        public int Seventh { get; }

        public int Bonus1 { get; }

        public int Bonus2 { get; }
    }
}