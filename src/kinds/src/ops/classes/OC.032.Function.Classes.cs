//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using K = FunctionClass;

    public static partial class OpClass
    {
        public readonly struct FunctionClass : IOpClass<K> 
        { 
            public K Class => K.Function; 
        }

        public readonly struct Emitter : IOpClass<K> 
        { 
            public K Class => K.Emitter; 
        }

        public readonly struct UnaryFunc : IOpClass<K> 
        { 
            public K Class => K.UnaryFunc; 
        }

        public readonly struct BinaryFunc : IOpClass<K> 
        { 
            public K Class => K.BinaryFunc; 
        }

        public readonly struct TernaryFunc : IOpClass<K> 
        { 
            public K Class => K.TernaryFunc; 
        }
     
        public readonly struct FunctionClass<T> : IOpClass<K,T> 
            where T : unmanaged 
        { 
            public K Class => K.Function; 
        }

        public readonly struct Emitter<T> : IOpClass<K,T> 
            where T : unmanaged 
        { 
            public K Class => K.Emitter; 
        }

        public readonly struct UnaryFunc<T> : IOpClass<K,T> 
            where T : unmanaged 
        { 
            public K Class => K.UnaryFunc; 
        }
        
        public readonly struct BinaryFunc<T> : IOpClass<K,T> 
            where T : unmanaged 
        { 
            public K Class => K.BinaryFunc; 
        }

        public readonly struct TernaryFunc<T> : IOpClass<K,T> 
            where T : unmanaged 
        { 
            public K Class => K.TernaryFunc; 
        }

        public readonly struct UnaryFunc<A,R> : IOpClassF<UnaryFunc<A,R>, K>
        { 
            public K Class => K.UnaryFunc;             
        }

        public readonly struct BinaryFunc<A,B,R> : IOpClassF<BinaryFunc<A,B,R>, K>
        { 
            public K Class => K.BinaryFunc;             
        }

        public readonly struct TernaryFunc<A,B,C,R> : IOpClassF<TernaryFunc<A,B,C,R>, K>
        { 
            public K Class => K.TernaryFunc;                         
        }
    }    
}