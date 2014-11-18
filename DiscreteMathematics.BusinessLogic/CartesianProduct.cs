using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscreteMathematics.BusinessLogic
{
    public class CartesianProduct<T> : Set<OrderedPair<T>>
    {
        public CartesianProduct(Set<T> firstSet, Set<T> secondSet)
        {
            foreach (var firstSetObject in firstSet)
            {
                foreach (var secondSetObject in secondSet)
                {
                    var orderedPair = new OrderedPair<T>(firstSetObject, secondSetObject);
                    Add(orderedPair);
                }
            }
        }
    }
}
