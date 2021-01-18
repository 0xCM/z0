//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using K = OperationKind;

    partial class Kinds
    {
        public readonly struct EmitterFunc : IOperationClass<K> { public K Kind => K.Emitter; }


        public readonly struct UnaryFunc : IOperationClass<K> { public K Kind => K.UnaryFunc; }


        public readonly struct BinaryFunc : IOperationClass<K> { public K Kind => K.BinaryFunc; }


        public readonly struct TernaryFunc : IOperationClass<K> { public K Kind => K.TernaryFunc; }

    }
}