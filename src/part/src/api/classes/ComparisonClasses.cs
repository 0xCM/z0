//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using K = ApiComparisonClass;
    using I = IApiComparisonClass;

    partial struct ApiClasses
    {
        public readonly struct Lt : I { K I.Kind => K.Lt; }

        public readonly struct LtEq : I { K I.Kind => K.LtEq; }

        public readonly struct Gt : I { K I.Kind => K.Gt; }

        public readonly struct GtEq : I { K I.Kind => K.GtEq; }

        public readonly struct Eq : I { K I.Kind => K.Eq; }

        public readonly struct Neq : I { K I.Kind => K.Neq; }

        public readonly struct Lt<T> : IApiComparisonClass<Lt,T> {}

        public readonly struct LtEq<T> : IApiComparisonClass<LtEq,T> {}

        public readonly struct Gt<T> : IApiComparisonClass<Gt,T> {}

        public readonly struct GtEq<T> : IApiComparisonClass<GtEq,T> {}

        public readonly struct Eq<T> : IApiComparisonClass<Eq,T> {}

        public readonly struct Neq<T> : IApiComparisonClass<Neq,T> {}
    }
}