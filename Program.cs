using System;

namespace NewInCSharp7
{
    class Program
    {
        static void Main(string[] args)
        {
            //binary literals and digit seperators
            int[] n1 = { 0b1, 0b10 , 0b1_000, 3_2};
            var (sum, count) = Talley(n1);
            Console.WriteLine($"Sum : { sum}, Count : { count}");


            int[] numbers = { 1, 2, 5, 7, 9, 2, 66 };

            var t = Talley(numbers);

            Console.WriteLine($"Sum : {t.sum}, Count : { t.count}");


            //testing

            //Case Null
            try
            {
                PatternWithSwitch(null);
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Exception : - {ex.Message}");
            }


            //Case Circle
            var circle = new Circle();
            circle.Radius = 10;
            PatternWithSwitch(circle);

            //Case Rectangle
            var rect = new Rectangle();
            rect.Length = 10;
            rect.Height = 7; 
            PatternWithSwitch(rect);


            //Case Square
            var sq = new Rectangle();
            sq.Length = sq.Height = 10; 
            PatternWithSwitch(sq); 

            Console.ReadKey();
        }


        //Tuples
        private static (int sum, int count) Talley(int[] numbers)
        {
            var r = (s: 0, c: 0);

            foreach (var number in numbers)
            {
                Add(number, 1);
            }

            return r;


            //local function
            void Add(int s,int c) { r.s += s; r.c += c; }
        }

        //Pattern Mathching
        public static void PrintStars(object o)
        {
            if (o is null) return; //constant pattern "null"

            if (!(o is int i)) return; //type pattern "int i"

            Console.WriteLine($"New veriable i with value {i},if o is type of an int");  
        }

        //pattern matching with switch statement
        public static void PatternWithSwitch(object shape)
        {
            switch (shape) //switch on anything
            {
                case Rectangle s when (s.Length == s.Height):     //special rectangle if length and hight is same --- WOW !! this is an square
                    Console.WriteLine($"Square with Length= {s.Length} and Height={s.Height}");
                    break;

                case Rectangle r:
                    Console.WriteLine($"Rectangle with Length= {r.Length} and Height={r.Height}");
                    break;

                case Circle c:
                    Console.WriteLine($"Circle with radius {c.Radius}");
                    break;

                case null:
                    throw new NullReferenceException(nameof(shape));
                    
                default:
                    Console.WriteLine($"<Unknown Shape>");
                    break;
            }
        }
    }



    public class Circle
    {
        public int Radius { get; set; }
    }

    public class Rectangle
    {   
        public int Length { get; set; }
        public int Height { get; set; }
    }
}
