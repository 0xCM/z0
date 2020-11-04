//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using K = PredicateApiClass;
    using I = IPredicateApiKey;

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

        public readonly struct Odd<T> : IBooleanPredicateKind<Odd,T> {}

        public readonly struct Even<T> : IBooleanPredicateKind<Even,T> {}

        public readonly struct EqPred<T> : IBooleanPredicateKind<EqPred,T> {}

        public readonly struct NeqPred<T> : IBooleanPredicateKind<NeqPred,T> {}

        public readonly struct GtPred<T> : IBooleanPredicateKind<GtPred,T> {}

        public readonly struct GtEqPred<T> : IBooleanPredicateKind<GtEqPred,T> {}

        public readonly struct LtPred<T> : IBooleanPredicateKind<LtPred,T> {}

        public readonly struct LtEqPred<T> : IBooleanPredicateKind<LtEqPred,T> {}
    }
}