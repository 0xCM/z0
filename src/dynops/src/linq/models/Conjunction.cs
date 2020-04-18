//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Dynamics
{
    using System;
    using System.Collections.Generic;    

    /// <summary>
    /// Represents a logical conjunction; i.e., the and conective that evaluates to true if and only if all of its operands are true
    /// </summary>
    public sealed class Conjunction : Junction
    {
        public Conjunction(Junction Parent = null)
            : base(new IPredicateAplication[] { }, Parent)
        { }

        public Conjunction(IEnumerable<IPredicateAplication> Predicates, Junction Parent = null)
            : base(Predicates, Parent)
        { }

        protected override ILogicalOperator Connective
            => StandardOperators.And;
    }

}
