//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Models.Logics
{
    using System;

    using static core;

    /// <summary>
    /// Defines common aspects of first order logic
    /// </summary>
    public readonly partial struct FOL
    {
        public readonly struct Conjuntion
        {
            public LogicSym Symbol => LogicSym.And;
        }

        public readonly struct Disjuntion
        {
            public LogicSym Symbol => LogicSym.Or;
        }

        public readonly struct Universal
        {
            public LogicSym Symbol => LogicSym.All;

        }

        public readonly struct Existential
        {
            public LogicSym Symbol => LogicSym.Exists;

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