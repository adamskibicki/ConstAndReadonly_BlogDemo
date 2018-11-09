using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstAndReadonly
{
    class Const
    {
        public const double PI = 3.14;
        private const int YEAR_OF_BIRTH = 1997;
        private const string AUTHOR_NAME = "Adam";

        public const string FULL_NAME = AUTHOR_NAME + " Skibicki";

        public class ReferenceTypeClass { }

        //błąd kompilatora - Error CS0133  The expression being assigned to 'Program.REFERENCE_CONST_1' must be constant 
        //public const ReferenceTypeClass REFERENCE_CONST_1 = new ReferenceTypeClass();

        //tu jest dobrze
        public const ReferenceTypeClass REFERENCE_CONST_2 = null;

        public class ClassWithPublicConstValue
        {
            public const string MyFavouriteProgrammingLanguage = "C#";
        }

        public void WriteMyFavouriteLanguage()
        {
            Console.WriteLine(ClassWithPublicConstValue.MyFavouriteProgrammingLanguage);
        }
    }

    public class Readonly
    {
        public class ReferenceTypeClass { }

        public static readonly int StaticReadonlyInt0 = 0;
        public static readonly int StaticReadonlyInt1;
        public static readonly ReferenceTypeClass StaticReadonlyReferenceTypeClass;

        static Readonly()
        {
            StaticReadonlyInt1 = 1;
            StaticReadonlyReferenceTypeClass = new ReferenceTypeClass();
        }

        public readonly int ReadonlyInt0 = 0;
        public readonly int ReadonlyInt1;
        public readonly ReferenceTypeClass ReadonlyReferenceTypeClass;

        public Readonly()
        {
            ReadonlyInt1 = 1;
            ReadonlyReferenceTypeClass = new ReferenceTypeClass();
        }

        public void ChangeReadonlyInt0()
        {
            //błąd kompilatora: Error CS0191 A readonly field cannot be assigned to (except in a constructor or a variable initializer)
            //ReadonlyInt0 = 1;
        }
    }
}
