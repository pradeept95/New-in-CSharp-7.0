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
            
or 
            int[] numbers = { 1, 2, 5, 7, 9, 2, 66 };
            var t = Talley(numbers); 
            Console.WriteLine($"Sum : {t.sum}, Count : { t.count}");
            
## 3. Local Function

    
   
