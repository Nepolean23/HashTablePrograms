using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableProgram
{
    internal class AbilityToFindFrequencyOfWords<K,V>
    {
        private readonly int size;
        private readonly LinkedList<KeyValue<K, V>>[] items;
        public AbilityToFindFrequencyOfWords(int size)
        {
            this.size = size;
            this.items = new LinkedList<KeyValue<K, V>>[size];
        }

        

        public struct KeyValue<k, v>
        {
            public k Key { get; set; }
            public v Value { get; set; }
        }




    }

}
