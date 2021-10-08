//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static core;
    using static Root;

    /// <summary>
    /// Defines common aspects of first order logic
    /// </summary>
    public readonly struct FOL
    {
        /// <summary>
        /// Conjunction: ∧
        /// </summary>
        public readonly struct And
        {
            public LogicSym Symbol
                => LogicSym.And;
        }

        /// <summary>
        /// Disjunction: a ∨ b
        /// </summary>
        public readonly struct Or
        {
            public LogicSym Symbol
                => LogicSym.Or;
        }

        /// <summary>
        /// Implication: a → b
        /// </summary>
        public readonly struct IfThen
        {
            public LogicSym Symbol
                => LogicSym.IfThen;
        }

        /// <summary>
        /// Biconditional, if and only if: a ⟷ b
        /// </summary>
        public readonly struct Iff
        {
            public LogicSym Symbol
                => LogicSym.Iff;
        }

        public readonly struct Universal
        {
            public LogicSym Symbol
                => LogicSym.All;
        }

        public readonly struct Existential
        {
            public LogicSym Symbol
                => LogicSym.Exists;
        }

        public readonly struct And<A,B>
        {
            public A Left {get;}

            public B Right {get;}

            [MethodImpl(Inline)]
            public And(A left, B right)
            {
                Left = left;
                Right = right;
            }

            public LogicSym Symbol => LogicSym.And;
        }

        public readonly struct Or<A,B>
        {
            public A Left {get;}

            public B Right {get;}

            [MethodImpl(Inline)]
            public Or(A left, B right)
            {
                Left = left;
                Right = right;
            }

            public LogicSym Symbol
                => LogicSym.Or;
        }
    }
}