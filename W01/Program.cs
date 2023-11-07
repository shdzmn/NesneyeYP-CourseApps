

namespace w01  // maviler kelimeler; keywords
{
    internal class Program
    {
        //starting or entry point method/function
        static void Main (string[] args)
        {
            int a = 1 + 2; int b = 3 + 4; int c = 5 + 6; // numerical literal
            Console.WriteLine("hello"); // string literal

            // region: progrraming ile ilgili değil, for description 
            #region Data Types

            #region Value Types / Primitives Types
            #region Predefined Types 
            //numerical and boolean types içerir. Aşağıdaki gibi;
            int a1 = 5;
            float f1 = 5.5f;
            double d1 = 6.5;
            bool b2 = false;
            char c1 = 'a';
            #endregion
            #region User DEfined Types
            // structs and enum types:
            //see example 1
            #endregion
            #endregion
            #region Pointer Types - not used so much

            unsafe
            {
                int* p1 = &b;
            }

            #endregion
            #region Reference Types
            #region Predifined Types
            // ÖNEMLİ: string data types reference tipe girer
            string name = "suheda dizman";
            object anyData = new MyData();

            #endregion
            #region User Difined Types
            //classes and user defined everything
            //class Program{}=>  user defined reference type
            //see example 2

            #endregion
            #endregion
            #endregion

        }
    }


    //Example 1: User Defined Complex Primitive types/value types
    struct MyData
    {
        int p1 = 1;
        //..

        double d1;
        public MyData()
        {
        }
    }

    enum DayNames
    {
        Monday,
        Tuesday,
        Wednesday,
        Friday,
        Sunday,
    }
}

// Tokens;
// 1 - keywords (maviler: namespace, class gibi)
// 2 - identifies (veriable definitions: int gibi)
// 3 - symbols ( [] , {} gibi)
// 4 - operators ( =,+ gibi)
// 5 - litearls: Numerical or String

