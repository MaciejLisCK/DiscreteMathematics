using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DiscreteMathematics.BusinessLogic
{
    public class Set<T> : IEnumerable<T>
    {
        private readonly HashSet<T> _elements;

        public Set(params T[] elements)
        {
            _elements = new HashSet<T>(elements);
        }

        public bool Add(T element)
        {
            var isElementExist = _elements.Add(element);

            return isElementExist;
        }

        public bool Remove(T element)
        {
            bool isElementFoundAndRemoved = _elements.Remove(element);

            return isElementFoundAndRemoved;
        }

        public IEnumerator<T> GetEnumerator()
        {
            var setEnumerator = new SetEnumerator<T>(_elements);

            return setEnumerator;
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            var setEnumerator = new SetEnumerator<T>(_elements);

            return setEnumerator;
        }
    }
}
