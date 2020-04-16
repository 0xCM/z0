//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Seed;

    using K = OperatorClass;


    partial class Kinds
    {
        public readonly struct OperatorClass : IOperatorClass<OperatorClass,K> 
        {
            public K Class => K.Operator; 
        } 

        public readonly struct UnaryOpClass : IOperatorClass<UnaryOpClass,K> 
        {
            public K Class => K.UnaryOp; 

            [MethodImpl(Inline)]
            public static implicit operator OperatorClass(UnaryOpClass src)
                => default;

            public OperatorClass Generalized => default;
        }

        public readonly struct BinaryOpClass : IOperatorClass<BinaryOpClass,K> 
        {
            public K Class => K.BinaryOp; 

            public static implicit operator OperatorClass(BinaryOpClass src)
                => default;

            public OperatorClass Generalized => default;
        }

        public readonly struct TernaryOpClass : IOperatorClass<TernaryOpClass,K> 
        {
            public K Class => K.TernaryOp; 

            public static implicit operator OperatorClass(TernaryOpClass src)
                => default;

            public OperatorClass Generalized => default;
        }

        public readonly struct OperatorClass<T> : IOpClass<K,T> 
            where T : unmanaged 
        { 
            public K Class => K.Operator; 
        }

        public readonly struct UnaryOpClass<T> : IOperatorClass<UnaryOpClass<T>, K,T> 
            where T : unmanaged 
        { 
            public static implicit operator OperatorClass<T>(UnaryOpClass<T> src)
                => default;
            
            [MethodImpl(Inline)]
            public static implicit operator UnaryOpClass(UnaryOpClass<T> src)
                => default;
                        
            public K Class => K.UnaryOp; 

            public OperatorClass<T> Generalized => default;

            public UnaryOpClass NonGeneric => default;
        }

        public readonly struct BinaryOpClass<T> : IOperatorClass<BinaryOpClass<T>,K,T> 
            where T : unmanaged 
        { 
            public static implicit operator OperatorClass<T>(BinaryOpClass<T> src)
                => default;
            
            [MethodImpl(Inline)]
            public static implicit operator BinaryOpClass(BinaryOpClass<T> src)
                => default;
                        
            public K Class => K.BinaryOp; 

            public OperatorClass<T> Generalized => default;

            public BinaryOpClass NonGeneric => default;            
        }

        public readonly struct TernaryOpClass<T> : IOperatorClass<TernaryOpClass<T>,K,T> 
            where T : unmanaged 
        {
            [MethodImpl(Inline)]
            public static implicit operator OperatorClass<T>(TernaryOpClass<T> src)
                => default;

            [MethodImpl(Inline)]
            public static implicit operator TernaryOpClass(TernaryOpClass<T> src)
                => default;

            public K Class => K.TernaryOp; 

            public OperatorClass<T> Generalized => default;

            public TernaryOpClass NonGeneric => default;
        }
    }
}