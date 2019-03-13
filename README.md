# New in C# 7.0

C# is a general-purpose, type-safe, object-oriented programming language. The goal of the language is programmer productivity. To this end, C# balances simplicity, expressiveness, and performance. The chief architect of the language since its first version is Anders Hejlsberg (creator of Turbo Pascal and architect of Delphi). The C# language is platform-neutral and works with a range of platform-specific compilers and frameworks, most notably the Microsoft .NET Framework for Windows.

Some awesome feature in c# 7.0
## 1. Binary literals and digit seperators

C# 7.0 provides the great feature for the number writing convention
    int[] n1 = { 0b1, 0b10 , 0b1000, 12345689012345678};
    int[] n2 = { 0b1, 0b10 , 0b1_000, 123_45_68_901_2345_678};
    
Here, n1 and n2 are two int array with the same value in each item just writing in two different way. Writing 12345689012345678 and 
123_45_68_901_2345_678 is same.

## 2. Tuples
If your function return more than one value. Just chill with c# 7.0, you can return more than one value form your function as below
         
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
        
 which can finally can call form anywhere as 
 
            var (sum, count) = Talley(n1);  //Using de-structuring 
            Console.WriteLine($"Sum : { sum}, Count : { count}");
            
            OR
            
            int[] numbers = { 1, 2, 5, 7, 9, 2, 66 };

            var t = Talley(numbers);

            Console.WriteLine($"Sum : {t.sum}, Count : { t.count}");
            
## 3. Local Function

In above Tuples Example, you see Add() method which scope only within the Talley() method. Thus Add() is the Local function to Talley().

## 4. Pattern Mathching
This is the great feature to c# 7.0.Prior to C# 7.0, Is operator was used to check the type of a variable and based on the type, it returns true or false but with C# 7.0, Is Expression provides following three types of pattern matching

1. Const Pattern
2. Type Pattern
3. Var Pattern

        static void IsConstExpression()
        {
        Object obj = 2;
        string name = "Brij";

        // null check
        if (obj is null)
            Console.WriteLine("Obj is null");

        // Constant value check
        if(obj is 2)
            Console.WriteLine("Obj has value 2");

        // String value check
        if(name is "Brij")
            Console.WriteLine("name has value \"Brij\"");
        }
        
In C# 7.0 now switch expression is for everything, due to Expression Matching. Follwing is the example for some 
Type pattern.

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
       

  Now this function can be use as follows for differnt type of object 
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

   AWESOME c#, follow me on GitHub for more awesome implementation
