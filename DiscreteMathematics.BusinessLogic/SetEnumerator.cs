using System;
using System.Collections.Generic;
using System.Linq;

namespace DiscreteMathematics.BusinessLogic
{
    public class SetEnumerator<T> : IEnumerator<T>
    {
        private static readonly Random _random = new Random();
        private T[] _elements;
        private int _currentElementOffset;

        public SetEnumerator(IEnumerable<T> elements)
        {
            _elements = elements.ToArray();

            Reset();
        }

        public T Current
        {
            get
            {
                return _elements[_currentElementOffset];
            }
        }

        object System.Collections.IEnumerator.Current
        {
            get
            {
                return _elements[_currentElementOffset];
            }
        }

        public bool MoveNext()
        {
            _currentElementOffset++;

            bool isValidOffset = _currentElementOffset <= _elements.Length-1;

            return isValidOffset;
        }

        public void Reset()
        {
            var shuffledElements = _elements.OrderBy(e => _random.Next());
            _elements = shuffledElements.ToArray();

            _currentElementOffset = -1;
        }

        public void Dispose()
        { }
    }
}