//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using C = FunctionClass;

    public static partial class OpClass
    {
        public readonly struct FunctionClass : IOperationClass<C> { public C Class => C.Function; }

        public readonly struct Emitter : IOperationClass<C> { public C Class => C.Emitter; }

        public readonly struct UnaryFunc : IOperationClass<C> { public C Class => C.UnaryFunc; }

        public readonly struct BinaryFunc : IOperationClass<C> { public C Class => C.BinaryFunc; }

        public readonly struct TernaryFunc : IOperationClass<C> { public C Class => C.TernaryFunc; }
     
        public readonly struct FunctionClass<T> : IOperationClass<C,T> where T : unmanaged { public C Class => C.Function; }

        public readonly struct Emitter<T> : IOperationClass<C,T> where T : unmanaged { public C Class => C.Emitter; }

        public readonly struct UnaryFunc<T> : IOperationClass<C,T> where T : unmanaged { public C Class => C.UnaryFunc; }

        public readonly struct BinaryFunc<T> : IOperationClass<C,T> where T : unmanaged { public C Class => C.BinaryFunc; }

        public readonly struct TernaryFunc<T> : IOperationClass<C,T> where T : unmanaged { public C Class => C.TernaryFunc; }
    }    
}