//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using K = ComparisonApiClass;
    using I = IComparisonApiKey;

    public readonly struct ComparisonKinds
    {
        public readonly struct Lt : I { K I.Kind => K.Lt; }

        public readonly struct LtEq : I { K I.Kind => K.LtEq; }

        public readonly struct Gt : I { K I.Kind => K.Gt; }

        public readonly struct GtEq : I { K I.Kind => K.GtEq; }

        public readonly struct Eq : I { K I.Kind => K.Eq; }

        public readonly struct Neq : I { K I.Kind => K.Neq; }

        public readonly struct Lt<T> : IComparisonKind<Lt,T> {}

        public readonly struct LtEq<T> : IComparisonKind<LtEq,T> {}

        public readonly struct Gt<T> : IComparisonKind<Gt,T> {}

        public readonly struct GtEq<T> : IComparisonKind<GtEq,T> {}

        public readonly struct Eq<T> : IComparisonKind<Eq,T> {}

        public readonly struct Neq<T> : IComparisonKind<Neq,T> {}
    }
}