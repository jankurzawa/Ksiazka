using System;

namespace Struktury_danych_i_algorytmy_Książka
{
    //class Program
    //{
    //static void Main(string[] args)
    //{
    //string firtsName = "Marcin";
    //string lastName = "Jamro";
    //int year = 1988;
    ////string note = firtsName + " " + lastName.ToUpper() + " urodził się w roku " + year;
    ////string note = string.Format("{0} {1} urodził się w roku {2}", firtsName, lastName.ToUpper(), year);
    ////string note = $"{firtsName} {lastName.ToUpper()} urodził się w roku {year}";
    ////Console.WriteLine(note);
    //string initials = firtsName[0] + "." + lastName[0] + ".";

    //---------------------------------------------------

    //    int age = 28;
    //    object ageBoxing = age;
    //    int ageUnboxing = (int)ageBoxing;

    //}


    //}

    public struct MutablePoint
    {
        public int X;
        public int Y;

        public MutablePoint(int x, int y) => (X, Y) = (x, y);

        public override string ToString() => $"({X}, {Y})";
    }

    public class Program
    {
        public static void Main()
        {
            var p1 = new MutablePoint(1, 2);
            var p2 = p1;
            p2.Y = 200;
            Console.WriteLine($"{nameof(p1)} after {nameof(p2)} is modified: {p1}");
            Console.WriteLine($"{nameof(p2)}: {p2}");

            MutateAndDisplay(p2);
            Console.WriteLine($"{nameof(p2)} after passing to a method: {p2}");
        }

        private static void MutateAndDisplay(MutablePoint p)
        {
            p.X = 100;
            Console.WriteLine($"Point mutated in a method: {p}");
        }
    }
}
