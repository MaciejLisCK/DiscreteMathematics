using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscreteMathematics.BusinessLogic
{
    public class Relation<T> : Set<OrderedPair<T>>
    {
        public Relation(IEnumerable<OrderedPair<T>> orderedPairs)
        {
            foreach (var orderedPair in orderedPairs)
            {
                Add(orderedPair);
            }
        }

        public Set<T> Domain
        {
            get
            {
                var domain = new Set<T>();
                foreach (var orderedPair in this)
                    domain.Add(orderedPair.First);

                return domain;
            }
        }

        public Set<T> Codomain
        {
            get
            {
                var codomain = new Set<T>();
                foreach (var orderedPair in this)
                    codomain.Add(orderedPair.Second);

                return codomain;
            }
        }
    }
}
