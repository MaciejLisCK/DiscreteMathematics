using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscreteMathematics.BusinessLogic
{
    public class Set<T> : IEnumerable<T>
    {
        private readonly HashSet<T> _objects;

        public int Count
        {
            get
            {
                return _objects.Count;
            }
        }

        public Set(params T[] objects)
        {
            _objects = new HashSet<T>(objects);
        }

        public bool Add(T @object)
        {
            var isObjectExist = _objects.Add(@object);

            return isObjectExist;
        }

        public bool Remove(T @object)
        {
            bool isObjectFoundAndRemoved = _objects.Remove(@object);

            return isObjectFoundAndRemoved;
        }

        public IEnumerator<T> GetEnumerator()
        {
            var setEnumerator = new SetEnumerator<T>(_objects);

            return setEnumerator;
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            var setEnumerator = new SetEnumerator<T>(_objects);

            return setEnumerator;
        }

        public override string ToString()
        {
            var setStringBuilder = String.Empty;

            setStringBuilder += "{";
            setStringBuilder += String.Join(", ", _objects);
            setStringBuilder += "}";

            return setStringBuilder;
        }
    }
}
