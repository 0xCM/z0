//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using K = FunctionClassKind;

    partial class Kinds
    {
        public readonly struct FunctionClass : IOpClass<K> { public K Kind => K.Function; }

        public readonly struct EmitterFunc : IOpClass<K> { public K Kind => K.Emitter; }

        public readonly struct UnaryFunc : IOpClass<K> { public K Kind => K.UnaryFunc; }

        public readonly struct BinaryFunc : IOpClass<K> { public K Kind => K.BinaryFunc; }

        public readonly struct TernaryFunc : IOpClass<K> { public K Kind => K.TernaryFunc; }

        public readonly struct FunctionClass<T> : IOpClass<FunctionClass,K,T>  {}

        public readonly struct EmitterFunc<T> : IOpClass<EmitterFunc,K,T> {}

        public readonly struct UnaryFunc<T> : IOpClass<UnaryFunc,K,T> {}
        
        public readonly struct BinaryFunc<T> : IOpClass<BinaryFunc,K,T> {}

        public readonly struct TernaryFunc<T> : IOpClass<TernaryFunc,K,T> {}

        public readonly struct UnaryFunc<A,R> : IOpClass<UnaryFunc,K,R> {}

        public readonly struct BinaryFunc<A,B,R> : IOpClass<BinaryFunc,K,R> {}

        public readonly struct TernaryFunc<A,B,C,R> : IOpClass<TernaryFunc,K,R> {}
    }
}