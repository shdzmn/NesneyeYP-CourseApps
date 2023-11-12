namespace w02
{

    #region Part 1 

    /*

    //0-Scope Level overall assembly scope
    //can be defined classes, Interfaces, Enums, Structs
    //cannot be defined variables, methods of any kind.


    class Program 
    { 
     //1-Global scope Level
     //can be defined inner classes, methods, variables


     readonly int _count = 1; //almost similar with const but it may be changed only one time.
     // in java look like fixed keyword
     public Program()
     {
         _count = 15;
     //  _count = 16; is impossible because readonly can be assigned once. 

     }

      //3-Formal scope level
      static void Main(string[] args)
      {
          //2-Local Scope - Level
          //cannot be defined classes, Interfaces, enums, structs
          //any kind of variable, methods, bot not recommended, we use especially here, the methods as lambda functions/anonymous methods .



          var test = new Program();


          //variable definition
          //standart veriable definition
          int a = 1;
          string name = "suheda";
          bool b = true;



          //definition of var keyword
          var a1 = 1;
          var name1 = "suheda";
          var b1 = true;
          // üstteki iki tanımlamalar aynı işlevi görür. Bu sebeple genellikle var keyword kullanılır.



          //dynamic keyword
          //javascript, python gibi diller fuuly dynamic tir. Fakat;
          //C# dynamic değildr. Bu sebeple dynamic keyword kullanılır.

          dynamic a3 = 1; // evaluated in runtime
          a3 = "suheda";
          a3 = true; // dinamik olduğundan veriable tipi değişebilir.




          //constant keyword
          const int ac = 1;
          //ac = 3; cannot be changed, cannot be null

          //overflow
          //lef size (bytes)   >=  right size (bytes)
          // int a11 = 1351354135413543154313543153431543153;



          //comments //single line comment

          block comment


          bool bl = false;
          int cl = 1; 
    



          }


      } */
    #endregion

    #region part 2

    //    class Program
    //{
    //    static void Main(string[] args)
    //    {
    //int a = Convert.ToInt32(Console.ReadLine()); //scanf in c
    //Console.WriteLine(a*a); //printf in c 

    //yukarıdaki örnekte -> Console.ReadLine() string type olduğundan Convert.ToInt32() kullandık.
    //Kullanmasaydık ve int a = Console.ReadLine() şeklinde yazsaydık hata alırdık (compile error).
    //dynamic a = Console.ReadLine() -> (runtime error) alır.


    //implicit type conversion
    //        int a = 12;
    //        double b = a;

    //        //leftsize>=rightsize
    //        long c = a;
    //        c = 125416546;


    //       //explicit type conversion;

    //        //cast operations
    //        a = (int)c; //we may get overflow problem
    //        Console.WriteLine(a);

    //        decimal d = 12345678901234567891;
    //        //c = (long)d;  //err overflow 
    //        Console.WriteLine(c);



    //        //operators
    //        //01-Arithmetic ops  + - / *  % ----------->  produces numbers/return numbers
    //        var res = 1 + 5 * 9 + 1.5/2;

    //        //02-relational <, <=, >, >=, ==, !=      ----------->  produces boolean/return true or false
    //        var ro = 1 < 2; //--->true
    //        ro = 3 >= 5;
    //        ro = 1 == 1;
    //        ro = 1 != 3;

    //        //03-logical && (and), ||(or), !      ----------->  produces boolean/return true or false
    //        ro = !((1 == 1) && (1<3) || (5>=100));


    //        //04-bitwise &, |, ~      ----------->  not used frequently


    //        //05-Assignment(eşittir)  =, +=, -=, *=, /=, %=     ----------->  

    //res : result
    //        res = 2;
    //        res += 2;  //res = res+2 (2 ve 2den fazla);
    //        res -= 2;  //res = res-2;
    //        res *= 2;  //res = res*2;
    //        res /= 2;  //res = res/2;

    //        //05-unary ops  ++, --, !     ----------->  used in numeric ops
    //        ++res;
    //        res++;
    //        --res;
    //        res--;

    //        //binary ops    operand1 operator  operand2 --> 1 + 2;
    //        //unary ops     operand operator,   operator operand1 --->  ++res, res++,  !bl,
    //        //ternary op : conditional if


    //        bool bl = !false; //--> true

    //        //05-ternary ops  ? :     -----------> returns any type of data

    /* var ahmetisgood = true;
     var restext = (ahmetisgood == true) ? "ahmet is true" : "ahmet is not true";
     Console.WriteLine(restext);

     if (ahmetisgood)
     {
         Console.WriteLine("ahmet is good" );
     }
     else
     {
         Console.WriteLine("ahmet is not true");
     } */
    //        var res2 = 1 == 2 ? -1 : 0;

    //    }
    //}

    #endregion

    #region part 3

    class Program
    {
        static void Main(string[] args)
        {
            int a = 45;

            Console.WriteLine(sizeof(int));

            Type t = typeof(int);

            Console.WriteLine(t == typeof(int));



            //arrays/ reference type

            char[] name = { 'a', 'y', 'd', 'ı', 'n' }; //reference type
            Console.WriteLine(name);

            string name2 = "aydın";      //reference type
            //yukarıdaki 2 örnek de aynı sonucu verir fakat -> REM'de farklı şekilde tutulurlar. (2.hafta-2.17.00)

            int[] numbers = { 1, 2, 3, 4, 5, 6 };
            int[,] numbers2 = { { 1, 2, 3, 4, 5, 6 }, { 1, 2, 3, 4, 5, 6 } };
            int[,,] numbers3 = new int[2, 2, 2];
            numbers3[0, 0, 0] = 3;

            //object array
            Program[] objectList = new Program[3];
            objectList[0] = new Program();

            //null types

            //as a default, value types cannot be null
            // int b = null; err
            //but we can make they nullable with a special operator
            int? c = null;

            //ref types can be null
            int[] list = null;

            //string is ref type and it can be null
            string name3 = null;

            Program p = null;


            //default or initial values
            int x; //x = 0
            //Console.WriteLine(x); //err

            string name4; //x = null;
            //Console.WriteLine(name4); //err



            int? x2 = null; // ? konulduğunda nullable yapmış oluruz. 


        }
    }

    #endregion

}
