using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace cSharp
{
    class Program
    {

        // 14. NARROWING AND WIDENING DATA TYPE CONVERSION * * 
        static int Add(int x, int y)
        { return x + y; }

        static void NarrowingAttempt()
        {
            byte myByte = 0;
            int myInt = 200;
            // Explicitly cast the int into a byte (no loss of data).
            myByte = (byte)myInt;
            Console.WriteLine("Value of myByte: {0}", myByte);
        }

        // 13. SYSTEM.TEXT.STRINGBUILDER TYPE * *
        //static void FunWithStringBuilder()
        //{
        //    Console.WriteLine("=> Using the StringBuilder:");
        //    StringBuilder sb = new StringBuilder("**** Fantastic Games ****", 256);
        //    sb.Append("\n");
        //    sb.AppendLine("Half Life");
        //    sb.AppendLine("Beyond Good and Evil");
        //    sb.AppendLine("Deus Ex 2");
        //    sb.AppendLine("System Shock");
        //    Console.WriteLine(sb.ToString());
        //    sb.Replace("2", "Invisible War");
        //    Console.WriteLine(sb.ToString());
        //    Console.WriteLine("sb has {0} chars.", sb.Length);
        //    Console.WriteLine();
        //}

        // 12. ESCAPE CHARACTERS * *
        //static void EscapeChars()
        //{
        //    Console.WriteLine("=> Escape characters:\a");
        //    string strWithTabs = "Model\tColor\tSpeed\tPet Name\a ";
        //    Console.WriteLine(strWithTabs);
        //    Console.WriteLine("Everyone loves \"Hello World\"\a ");
        //    // Adds a total of 4 blank lines (then beep again!).
        //    Console.WriteLine("All finished.\n\n\n\a ");
        //    Console.WriteLine();
        //}

        // 11. STRING CONCATENATION * *
        //static void StringConcatenation()
        //{
        //    Console.WriteLine("STRING CONCATENATION");
        //    string s1 = "Programming the";
        //    string s2 = "PsychoDrill (PTP)";
        //    string s3 = String.Concat(s1, s2);
        //    Console.WriteLine(s3);
        //    Console.WriteLine();
        //}

        // 10. BASIC STRING MANIPULATION * *
        //static void BasicStringFunctionality()
        //{
        //    Console.WriteLine("BASIC STRING FUNCTIONALITY");
        //    string FirstName = "Dilay";
        //    Console.WriteLine("Value of firstName: {0}", FirstName);
        //    Console.WriteLine("FirstName has {0} characters", FirstName.Length);
        //    Console.WriteLine("FirstName in uppercase {0}", FirstName.ToUpper());
        //    Console.WriteLine("FirstName in lowercase {0}", FirstName.ToLower());
        //    Console.WriteLine("FirstName contains the letter y?: {0}",FirstName.Contains("y"));
        //    Console.WriteLine("FirstName after replace: {0}", FirstName.Replace("ay",""));
        //    Console.WriteLine();
        //}

        // 9. SYSTEM.NUMEERICS NAMASPACE * *
        //static void UseBigInteger()
        //{
        //    Console.WriteLine("USE BIG INTEGER");
        //    BigInteger biggy = BigInteger.Parse("9999999999999999999999999999999999999999999999");
        //    Console.WriteLine("Value of biggy is {0}", biggy);
        //    Console.WriteLine("Is biggy an even value?: {0}", biggy.IsEven);
        //    Console.WriteLine("Is biggy a power of two?: {0}", biggy.IsPowerOfTwo);
        //    BigInteger reallyBig = BigInteger.Multiply(biggy, BigInteger.Parse("8888888888888888888888888888888888888888888"));
        //    Console.WriteLine("Value of reallyBig is {0}",reallyBig);
        //}

        // 8. SYSTEM.DATETIME AND SYSTEM.TIMESPAN * *
        //static void UseDatesAndTimes()
        //{
        //    Console.WriteLine("DATES AND TIMES");
        //    // Constructor takes(year, month, day)
        //    DateTime dt = new DateTime(2018, 08, 01);
        //    Console.WriteLine("The day of {0} is {1}", dt.Date, dt.DayOfWeek);
        //    // Month is now December
        //    dt = dt.AddMonths(2);
        //    Console.WriteLine("Daylight savings: {0}", dt.IsDaylightSavingTime());
        //    // Constructor takes (hours, minutes, seconds)
        //    TimeSpan ts = new TimeSpan(4, 30, 0);
        //    Console.WriteLine(ts);
        //    // Substract 15 minutes from the current TimeSpan
        //    Console.WriteLine(ts.Subtract(new TimeSpan(0, 15, 0)));
        //}

        // 7. PARSING VALUES FROM STRING DATA * *
        //static void ParseFromStrings()
        //{
        //    Console.WriteLine("DATA TYPE PARSING");
        //    bool b = bool.Parse("True");
        //    Console.WriteLine("Value of b: {0}", b);
        //    double d = double.Parse("99.884");
        //    Console.WriteLine("Value of d: {0}", d);
        //    int i = int.Parse("8");
        //    Console.WriteLine("Value of d: {0}", i);
        //    char c = char.Parse("w");
        //    Console.WriteLine("Value of d: {0}", c);
        //    Console.WriteLine();
        //}

        // 6. MEMBERS OF SYSTEM.CHAR * *
        //static void CharFunctionality()
        //{
        //    Console.WriteLine("CHAR TYPE FUNCTIONALITY");
        //    char myChar = 'a';
        //    Console.WriteLine("char.IsDigit('a'): {0}", char.IsDigit(myChar));
        //    Console.WriteLine("CHAR.IsLetter('a'): {0}", char.IsLetter(myChar));
        //    Console.WriteLine("char.IsWhiteSpace('Hello There', 5): {0}",char.IsWhiteSpace("Hello There", 5));
        //    Console.WriteLine("char.IsWhiteSpace('Hello There', 6): {0}",char.IsWhiteSpace("Hello There", 6));
        //    Console.WriteLine("char.IsPunctuation('?'): {0}",char.IsPunctuation('?'));
        //    Console.WriteLine();
        //}

        //5. MEMBERS O NUMERICAL DATA TYPES * *
        //static void DataTypeFunctionality()
        //{
        //    Console.WriteLine("Data Type Functionality");
        //    Console.WriteLine("Max of int : {0}", int.MaxValue);
        //    Console.WriteLine("Min of int : {0}", int.MinValue);
        //    Console.WriteLine("Max of double : {0}", double.MaxValue);
        //    Console.WriteLine("Min of double : {0}", double.MinValue);
        //    Console.WriteLine("double.Epsilon : {0}", double.Epsilon);
        //    Console.WriteLine("double.PositiveInfinity : {0}", double.PositiveInfinity);
        //    Console.WriteLine("double.NegativeInfinity : {0}", double.NegativeInfinity);
        //    Console.WriteLine("bool.FalseString: {0}", bool.FalseString);
        //    Console.WriteLine("bool.TrueString: {0}", bool.TrueString);
        //    Console.WriteLine();
        //}

        // 4. BASIC DATA TYPES * *
        //static void ObjectFunctionality()
        //{
        //    Console.WriteLine("System.Object Functionality");
        //    Console.WriteLine("12.GetHashCode() = {0}", 12.GetHashCode());
        //    Console.WriteLine("12.Equals(23) = {0}", 12.Equals(23));
        //    Console.WriteLine("12.ToString() = {0}", 12.ToString());
        //    Console.WriteLine("12.GetType() = {0}", 12.GetType());
        //    Console.WriteLine();
        //}

        //3. FORMATTING NUMERICAL DATA * * 
        //  static void FormatNumericalData()
        //  {
        //      Console.WriteLine("The value 99999 in various formats:");
        //      Console.WriteLine("c format: {0:c}", 99999);
        //      Console.WriteLine("d9 format: {0:d9}", 99999);
        //      Console.WriteLine("f3 format: {0:f3}", 99999);
        //      Console.WriteLine("n format: {0:n}", 99999);
        //    // Notice that upper- or lowercasing for hex
        //    // determines if letters are upper- or lowercase.
        //      Console.WriteLine("E format: {0:E}", 99999);
        //      Console.WriteLine("e format: {0:e}", 99999);
        //      Console.WriteLine("X format: {0:X}", 99999);
        //      Console.WriteLine("x format: {0:x}", 99999);
        //}

        /* * 2. THE SYSTEM.CONSOLE CLASS USE * *
        static void GetUserData()
        {
            Console.Write("Please enter yoru name: ");
            string Username = Console.ReadLine();
            Console.Write("Please enter yout age:");
            string UserAge = Console.ReadLine();

            //Change echo color, just for fun.
            ConsoleColor PrevColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Yellow;

            //Echo to the console
            Console.WriteLine("Hello {0}! You are {1} years old.", Username, UserAge);

            //Restore previous color
            Console.ForegroundColor = PrevColor;
        }*/

        /* 1. SYSTEM.ENVIRONMENT CLASS USE * * 
        static void ShowEnvironmentDetails()
        {
            foreach (string drive in Environment.GetLogicalDrives())
                Console.WriteLine("Drive: {0}", drive);

            Console.WriteLine("OS: {0}", Environment.OSVersion);
            Console.WriteLine("Number of processors: {0}", Environment.ProcessorCount);
            Console.WriteLine(".NET Version: {0}", Environment.Version);
        }*/
        static void Main(string[] args)
        {
            /* 1. SYSTEM.ENVIRONMENT CLASS USE * * 
             * You must change the main method void to int ! * *
            ShowEnvironmentDetails();
            Console.ReadLine();
            return -1;*/

            /* 2. THE SYSTEM.CONSOLE CLASS USE * *
            Console.WriteLine("Basic I/O");
            GetUserData();
            Console.ReadLine();*/

            /* 3. FORMATTING NUMERICAL DATA * * 
            Console.WriteLine("Formatting Numerical Data");
            FormatNumericalData();
            Console.ReadLine();*/

            //4. BASIC DATA TYPES * *
            //ObjectFunctionality();
            //Console.ReadLine(); 

            //5.MEMBERS O NUMERICAL DATA TYPES * *
            //DataTypeFunctionality();
            //Console.ReadLine();

            // 6. MEMBERS OF SYSTEM.CHAR * *
            //CharFunctionality();
            //Console.ReadLine();      

            // 7. PARSING VALUES FROM STRING DATA * *
            //ParseFromStrings();
            //Console.ReadLine();

            // 8. SYSTEM.DATETIME AND SYSTEM.TIMESPAN * *
            //UseDatesAndTimes();
            //Console.ReadLine();

            // 9. SYSTEM.NUMEERICS NAMASPACE * *
            //UseBigInteger();
            //Console.ReadLine();

            // 10. BASIC STRING MANIPULATION * *
            //BasicStringFunctionality();
            //Console.ReadLine();

            // 11. STRING CONCATENATION * *
            //StringConcatenation();
            //Console.ReadLine();

            // 12. ESCAPE CHARACTERS * *
            //EscapeChars();
            //Console.ReadLine();

            // 13. SYSTEM.TEXT.STRINGBUILDER TYPE * *
            //FunWithStringBuilder();
            //Console.ReadLine();

            // 14. NARROWING AND WIDENING DATA TYPE CONVERSION * * 
            Console.WriteLine("NARROWING AND WIDENING DATA TYPE CONVERSION");
            // Add two shorts and print the result.
            short numb1 = 3000;
            short numb2 = 3000;
            short answer = (short)Add(numb1, numb2);
            Console.WriteLine("{0} + {1} = {2}", numb1, numb2, answer);
            NarrowingAttempt();
            Console.ReadLine();

        }


    }
}
