//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Seed;

    using K = BooleanPredicateKind;
    using I = IBooleanPredicateKind;

    partial class Kinds
    {
        public readonly struct Odd : I { K I.Kind => K.Odd; }

        public readonly struct Even : I { K I.Kind => K.Even; }

        public readonly struct EqPred : I { K I.Kind => K.EqPred; }

        public readonly struct NeqPred : I { K I.Kind => K.NeqPred; }

        public readonly struct GtPred : I { K I.Kind => K.GtPred; }

        public readonly struct GtEqPred : I { K I.Kind => K.GtEqPred; }

        public readonly struct LtPred : I { K I.Kind => K.LtPred; }

        public readonly struct LtEqPred : I { K I.Kind => K.LtEqPred; }
    }
}