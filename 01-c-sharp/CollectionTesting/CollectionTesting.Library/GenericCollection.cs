using System;
using System.Collections;
using System.Collections.Generic;

namespace CollectionTesting.Library
{
    public class GenericCollection<T> : IEnumerable<T>
    {
        protected List<T> List { get; } = new List<T>();

        public GenericCollection()
        {

        }

        public GenericCollection(IEnumerable<T> coll)
        {
            List.AddRange(coll);
        }

        public IEnumerator<T> GetEnumerator()
        {
            return ((IEnumerable<T>) List).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable<T>)List).GetEnumerator();
        }
    }
}
