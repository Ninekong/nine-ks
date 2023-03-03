class progarm {
    static void Main(string[] args) {
        Console.Write("password :");
        int i = int.Parse(Console.ReadLine());

        Console.Write("agency :");
        string e = (Console.ReadLine());

        if(i <= 999999 && i >= 0) {
            int d = i / 100000 % 10;
            int b = i / 10000 % 10;
            int l = i / 1000 % 10;
            int s = i / 100 % 10;
            int a = i / 10 % 10;
            int n = i % 10;
        
        if(e == "CIA") {
          if(l >= 4 && l != 8 && a != 1 && a != 3 && a != 5 && n % 3 == 0) {
             Console.WriteLine("True");
          }
          else {
            Console.WriteLine("False");
          }
        }
        if(e == "FBI") {
            if(d >= 4 && d <= 7 && s % 2 == 0 && s != 6 && b % 2 == 1) {
                Console.WriteLine("True");
            }
            else {
                Console.WriteLine("False");
            }
        }
        if(e =="NSA") {
            if(30 % n == 0 && s % 3 == 0 && s % 2 != 0 && a == 7 || l == 7 || b == 7 || d == 7 ) {
               Console.WriteLine("True");
            }
            else {
                Console.WriteLine("False");
            }
        }
        }
        }
    }



