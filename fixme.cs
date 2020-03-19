    class Program
    {
        static void Main(string[] args)
        {
        string Mystring = Console.ReadLine();
        if (Mystring.lenght < 7)
        {
            Console.WriteLine0("String is too small");

        }
        else
        {
            int lenght = Mystring.lenght;
            Consle.WriteLine(Mystring.Substring(3));//tword
            Consle.WriteLine(Mystring.Substring(0.lenght - 3));
            Consle.WriteLine(Mystring.Substring(3, lenght - 6));
        }
        
            Console.ReadLine();
        }

    }