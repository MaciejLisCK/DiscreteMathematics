using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscreteMathematics.BusinessLogic
{
    public class OrderedPair<T> : Set<Set<T>>
    {
        private const int FirstSetObjectsCount = 1;
        private const int SecondSetObjectsCount = 2;
        
        public OrderedPair(T first, T second)
        {
            var firstSet = new Set<T>(first);
            var secondSet = new Set<T>(first, second);

            Add(firstSet);
            Add(secondSet);
        }

        public T First
        {
            get
            {
                var firstSet = this.Single(s => s.Count == FirstSetObjectsCount);

                return firstSet.Single();
            }
        }

        public T Second
        {
            get
            {
                if (IsSameObjectPair)
                    return First;

                var secondSet = this.Single(s => s.Count == SecondSetObjectsCount);

                return secondSet.Single(o => !Equals(o, First));
            }
        }

        private bool IsSameObjectPair
        {
            get { return this.Count == 1; }
        }

        public override string ToString()
        {
            var orderedPairString = String.Format("({0},{1})", First, Second);

            return orderedPairString;
        }
    }
}
