//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    partial class Kinds
    {
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