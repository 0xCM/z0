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
        public readonly struct FunctionClass : IOpClass<C> 
        { 
            public C Class => C.Function; 
        }

        public readonly struct Emitter : IOpClass<C> 
        { 
            public C Class => C.Emitter; 
        }

        public readonly struct UnaryFunc : IOpClass<C> 
        { 
            public C Class => C.UnaryFunc; 
        }

        public readonly struct BinaryFunc : IOpClass<C> 
        { 
            public C Class => C.BinaryFunc; 
        }

        public readonly struct TernaryFunc : IOpClass<C> 
        { 
            public C Class => C.TernaryFunc; 
        }
     
        public readonly struct FunctionClass<T> : IOpClass<C,T> 
            where T : unmanaged 
        { 
            public C Class => C.Function; 
        }

        public readonly struct Emitter<T> : IOpClass<C,T> 
            where T : unmanaged 
        { 
            public C Class => C.Emitter; 
        }

        public readonly struct UnaryFunc<T> : IOpClass<C,T> 
            where T : unmanaged 
        { 
            public C Class => C.UnaryFunc; 
        }

        public readonly struct BinaryFunc<T> : IOpClass<C,T> 
            where T : unmanaged 
        { 
            public C Class => C.BinaryFunc; 
        }

        public readonly struct TernaryFunc<T> : IOpClass<C,T> 
            where T : unmanaged 
        { 
            public C Class => C.TernaryFunc; 
        }
    }    
}