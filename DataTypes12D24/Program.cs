namespace DataTypes12D24
{
    internal class Program
    {
        struct Town
        {
            public string TownName;
            public int Population;
            public double Area;
            public string County;

            public Town(string tName, int tPop,double tArea,string tCounty)
            {
                TownName = tName;
                Population = tPop;
                Area = tArea;
                County = tCounty;
            }
        }
        static void Main(string[] args)
        {
            // datatype identifier (optional assignment)
            // integer
            int myInteger;
            myInteger = 42;
            Console.WriteLine(myInteger);
            Console.WriteLine(myInteger + myInteger);

            int a = int.MaxValue;
            int b = int.MaxValue;
            int c = a + b;
            Console.WriteLine(c);



            //real/float
            float myFloat = 0.579F;
            decimal myDecimal = 1.342946M;
            double myDouble = 1.23456;

            //Boolean
            bool myBool = true;
            myBool = false;

            //character
            char myChar = 'P';
            char anotherChar = 'A';
            Console.WriteLine(myChar + anotherChar); // adds ASCII values

            //string
            string myString = "This is a string";
            string anotherString = "So is this!";
            Console.WriteLine(myString + anotherString); //concattenation
            Console.WriteLine(myString + myChar);

            //date/time
            DateTime myToday = DateTime.Today;
            Console.WriteLine(myToday);

            DateTime myDateTime = DateTime.Now;
            Console.WriteLine(myDateTime);
            Console.WriteLine(myDateTime.Year);
            Console.WriteLine(myDateTime.Month);
            Console.WriteLine(myDateTime.Day);
            Console.WriteLine(myDateTime.Hour);
            Console.WriteLine(myDateTime.Minute);
            Console.WriteLine(myDateTime.Second);
            Console.WriteLine(myDateTime.Millisecond);

            //Records/Structure
            Town myTown = new Town();
            myTown.TownName = "Heckmondwike";
            myTown.Population = 40;
            myTown.Area = 300.5;
            myTown.County = "W Yorks";

            Console.WriteLine(myTown.TownName);
            Console.WriteLine(myTown.Population);
            Town homeTown = new Town("Doncaster", 500, 251.631, "S Yorks");

            //arrays
            int[] someNums = { 5, 9, 4, 3, 9, 4, 9, 5, 4, 52 };
            Console.WriteLine(someNums[0]);
            Console.WriteLine(someNums[9]);


        }
    }
}
