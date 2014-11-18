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

        public bool IsReflexive
        {
            get
            {
                var allObjectsSet = GetAllObjectsSet();
                bool hasEachObjectLoop = allObjectsSet.All(o => this.Any(p => p.Equals(new OrderedPair<T>(o, o))));

                return hasEachObjectLoop;
            }
        }

        public bool IsIrreflexive 
        {
            get
            {
                var isAnyLoopExist = this.Any(p => p.First.Equals(p.Second));

                return !isAnyLoopExist;
            }
        }

        public bool IsCoreflexive
        {
            get
            {
                var hasOnlyLoops = this.All(p => p.First.Equals(p.Second));

                return hasOnlyLoops;
            }
        }

        public bool IsSymmetric
        {
            get
            {
                foreach (var pair in this)
                {
                    var reversedPair = pair.GetReversePair();
                    var hasReversedPair = this.Any(p => p.Equals(reversedPair));

                    if (!hasReversedPair)
                        return false;
                }

                return true;
            }
        }

        public bool IsAntisymmetric 
        {
            get
            {
                foreach (var pair in this)
                {
                    var reversedPair = pair.GetReversePair();
                    var hasSameObjectsInPair = pair.First.Equals(pair.Second);
                    var hasReversedPair = this.Any(p => p.Equals(reversedPair));

                    if (hasReversedPair && !hasSameObjectsInPair)
                        return false;
                }

                return true;
            }
        }

        public bool IsAsymmetric
        {
            get
            {
                foreach (var pair in this)
                {
                    var reversedPair = pair.GetReversePair();
                    var hasReversedPair = this.Any(p => p.Equals(reversedPair));

                    if (hasReversedPair)
                        return false;
                }

                return true;
            }
        }

        public bool IsTransitive
        {
            get
            {
                foreach (var firstPair in this)
                {
                    foreach (var secondPair in this)
                    {
                        var isPairLeadsToAnotherPair = firstPair.Second.Equals(secondPair.First);

                        if (isPairLeadsToAnotherPair)
                        {
                            var isTransitivePairExist =
                                this.Any(p => firstPair.First.Equals(p.First) && secondPair.Second.Equals(p.Second));

                            if (!isTransitivePairExist)
                                return false;
                        }
                    }
                }

                return true;
            }
        }

        public bool IsTotal
        {
            get
            {
                var allObjectsSet = GetAllObjectsSet();
                foreach (var x in allObjectsSet)
                {
                    foreach (var y in allObjectsSet)
                    {
                        var hasPairInAnyOrder = this
                            .Any(p => p.Equals(new OrderedPair<T>(x, y)) || p.Equals(new OrderedPair<T>(y, x)));
                        
                        if (!hasPairInAnyOrder)
                            return false;
                    }
                }
                return true;
            }
        }

        private Set<T> GetAllObjectsSet()
        {
            var allObjects = this.SelectMany(o => new[] { o.First, o.Second });
            var allObjectsSet = new Set<T>(allObjects.ToArray());

            return allObjectsSet;
        }
    }
}
