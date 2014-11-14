using System;
using System.Collections.Generic;
using System.Linq;

namespace DiscreteMathematics.BusinessLogic
{
    public class SetEnumerator<T> : IEnumerator<T>
    {
        private static readonly Random _random = new Random();
        private T[] _objects;
        private int _currentObjectOffset;

        public SetEnumerator(IEnumerable<T> objects)
        {
            _objects = objects.ToArray();

            Reset();
        }

        public T Current
        {
            get
            {
                return _objects[_currentObjectOffset];
            }
        }

        object System.Collections.IEnumerator.Current
        {
            get
            {
                return _objects[_currentObjectOffset];
            }
        }

        public bool MoveNext()
        {
            _currentObjectOffset++;

            bool isValidOffset = _currentObjectOffset <= _objects.Length-1;

            return isValidOffset;
        }

        public void Reset()
        {
            var shuffledObjects = _objects.OrderBy(e => _random.Next());
            _objects = shuffledObjects.ToArray();

            _currentObjectOffset = -1;
        }

        public void Dispose()
        { }
    }
}