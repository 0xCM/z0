//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using K = OperationKind;

    partial class Kinds
    {
        public readonly struct EmitterFunc : IOperationalClass<K> { public K Kind => K.Emitter; }

        public readonly struct UnaryFunc : IOperationalClass<K> { public K Kind => K.UnaryFunc; }

        public readonly struct BinaryFunc : IOperationalClass<K> { public K Kind => K.BinaryFunc; }

        public readonly struct TernaryFunc : IOperationalClass<K> { public K Kind => K.TernaryFunc; }

        public readonly struct EmitterFunc<T> : IOperationalClass<EmitterFunc,K,T> {}

        public readonly struct UnaryFunc<T> : IOperationalClass<UnaryFunc,K,T> {}

        public readonly struct BinaryFunc<T> : IOperationalClass<BinaryFunc,K,T> {}

        public readonly struct TernaryFunc<T> : IOperationalClass<TernaryFunc,K,T> {}

        public readonly struct UnaryFunc<A,R> : IOperationalClass<UnaryFunc,K,R> {}

        public readonly struct BinaryFunc<A,B,R> : IOperationalClass<BinaryFunc,K,R> {}

        public readonly struct TernaryFunc<A,B,C,R> : IOperationalClass<TernaryFunc,K,R> {}
    }
}