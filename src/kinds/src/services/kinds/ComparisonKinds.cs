//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using K = ComparisonKind;
    using I = IComparisonKind;

    partial class Kinds
    {
        public readonly struct Lt : I { K I.Kind => K.Lt; }

        public readonly struct LtEq : I { K I.Kind => K.LtEq; }

        public readonly struct Gt : I { K I.Kind => K.Gt; }

        public readonly struct GtEq : I { K I.Kind => K.GtEq; }

        public readonly struct Eq : I { K I.Kind => K.Eq; }

        public readonly struct Neq : I { K I.Kind => K.Neq; }
    }
}