//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using K = ApiFunctionClass;

    partial class Kinds
    {
        public readonly struct EmitterFunc : IOperational<K> { public K Kind => K.Emitter; }

        public readonly struct UnaryFunc : IOperational<K> { public K Kind => K.UnaryFunc; }

        public readonly struct BinaryFunc : IOperational<K> { public K Kind => K.BinaryFunc; }

        public readonly struct TernaryFunc : IOperational<K> { public K Kind => K.TernaryFunc; }

        public readonly struct EmitterFunc<T> : IOperational<EmitterFunc,K,T> {}

        public readonly struct UnaryFunc<T> : IOperational<UnaryFunc,K,T> {}

        public readonly struct BinaryFunc<T> : IOperational<BinaryFunc,K,T> {}

        public readonly struct TernaryFunc<T> : IOperational<TernaryFunc,K,T> {}

        public readonly struct UnaryFunc<A,R> : IOperational<UnaryFunc,K,R> {}

        public readonly struct BinaryFunc<A,B,R> : IOperational<BinaryFunc,K,R> {}

        public readonly struct TernaryFunc<A,B,C,R> : IOperational<TernaryFunc,K,R> {}
    }
}