//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Dynamics
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Represents a logical disjunction; i.e., the or conective that evaluates to true if and only if one or more of it's operands are true
    /// </summary>
    public sealed class Disjunction : Junction
    {
        public Disjunction(Junction Parent = null)
            : base(new IPredicateAplication[] { }, Parent)
        { }

        public Disjunction(IEnumerable<IPredicateAplication> Predicates, Junction Parent = null)
            : base(Predicates, Parent)
        { }

        protected override ILogicalOperator Connective
            => StandardOperators.Or;

    }
}
