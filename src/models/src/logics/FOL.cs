//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Models.Logics
{
    using System;
    using System.Runtime.CompilerServices;


    using static core;
    using static Root;

    /// <summary>
    /// Defines common aspects of first order logic
    /// </summary>
    public readonly partial struct FOL
    {
        public readonly struct Conjuntion<A,B>
        {
            public A Left {get;}

            public B Right {get;}

            [MethodImpl(Inline)]
            public Conjuntion(A left, B right)
            {
                Left = left;
                Right = right;
            }

            public LogicSym Symbol => LogicSym.And;
        }

        public readonly struct Disjuntion
        {
            public LogicSym Symbol => LogicSym.Or;
        }

        public readonly struct Disjunction<A,B>
        {
            public A Left {get;}

            public B Right {get;}

            [MethodImpl(Inline)]
            public Disjunction(A left, B right)
            {
                Left = left;
                Right = right;
            }

            public LogicSym Symbol
                => LogicSym.Or;
        }

        public readonly struct Disjunction<T>
        {
            public Index<T> Terms {get;}

            [MethodImpl(Inline)]
            public Disjunction(T[] terms)
            {
                Terms = terms;
            }

            public LogicSym Symbol
                => LogicSym.Or;
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

        public readonly struct Implication
        {
            public LogicSym Symbol => LogicSym.IfThen;

        }

        public readonly struct Biconditional
        {
            public LogicSym Symbol => LogicSym.Iff;
        }
    }
}