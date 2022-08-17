using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory
{
        public class TypesofRice
        {
            public string name;
            public int weight;
            public int price;
        }
        public class TypesofWheat
        {
            public string name;
            public int weight;
            public int price;
        }
        public class TypesofPulse
        {
            public string name;
            public int weight;
            public int price;
        }
        public class Food
        {
            public TypesofRice typesofRice;
            public TypesofWheat typesofWheat;
            public TypesofPulse typesofPulse;
        }
}
