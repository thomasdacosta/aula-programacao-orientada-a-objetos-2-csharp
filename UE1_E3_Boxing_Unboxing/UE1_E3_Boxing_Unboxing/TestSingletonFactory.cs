using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UE1_E3_Boxing_Unboxing
{
    public class TestSingletonFactory
    {
        private static SingletonPattern singletonPattern = null;

        private TestSingletonFactory()
        {

        }

        public static SingletonPattern GetSingletonPattern()
        {
            if (singletonPattern == null)
            {
                singletonPattern = SingletonPattern.NewInstance();
            }
            return singletonPattern;
        }
    }
}
