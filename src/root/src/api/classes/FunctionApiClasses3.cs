//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using K = OperationKind;

    public readonly struct FunctionApiClasses
    {
        public readonly struct EmitterFunc : IOperationClass<K> { public K Kind => K.Emitter; }

        public readonly struct EmitterFunc<T> : IOperationClass<EmitterFunc,K,T> {}

        public readonly struct UnaryFunc : IOperationClass<K> { public K Kind => K.UnaryFunc; }

        public readonly struct UnaryFunc<T> : IOperationClass<UnaryFunc,K,T> {}

        public readonly struct BinaryFunc : IOperationClass<K> { public K Kind => K.BinaryFunc; }

        public readonly struct BinaryFunc<T> : IOperationClass<BinaryFunc,K,T> {}

        public readonly struct TernaryFunc : IOperationClass<K> { public K Kind => K.TernaryFunc; }

        public readonly struct TernaryFunc<T> : IOperationClass<TernaryFunc,K,T> {}

        public readonly struct UnaryFunc<A,R> : IOperationClass<UnaryFunc,K,R> {}

        public readonly struct BinaryFunc<A,B,R> : IOperationClass<BinaryFunc,K,R> {}

        public readonly struct TernaryFunc<A,B,C,R> : IOperationClass<TernaryFunc,K,R> {}
    }
}