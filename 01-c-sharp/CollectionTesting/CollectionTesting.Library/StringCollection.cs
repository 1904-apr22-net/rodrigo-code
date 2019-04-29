using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionTesting.Library
{
    class StringCollection : GenericCollection<string>
    {

        public StringCollection() : base()
        {
            //constructors are not inherited
            //every child-class constructor has to call exactly one
        }

        public StringCollection(IEnumerable<string> coll) : base(coll)
        {

        }
        public void Add(string s)
        {
            List.Add(s);
        }

        public void Remove(string s)
        {
            List.Remove(s);
        }
        // we can override any operatoR: +, -, +=, ||, &&, ==

        public string this[int index] {
            get => List[index];
            set { List[index] = value; }
        }
    }
}
