//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Kinds;

    using C = OperatorClass;

    partial class OpClass
    {
        public readonly struct OperatorClass : IOperationClass<C> 
        {
            public C Class => C.Operator; 
        } 

        public readonly struct UnaryOp : IOperationClass<C> 
        {
            public C Class => C.UnaryOp; 

            [MethodImpl(Inline)]
            public static implicit operator OperatorClass(UnaryOp src)
                => default;

            public OperatorClass Generalized => default;
        }

        public readonly struct BinaryOp : IOperationClass<C> 
        {
            public C Class => C.BinaryOp; 

            public static implicit operator OperatorClass(BinaryOp src)
                => default;

            public OperatorClass Generalized => default;
        }

        public readonly struct TernaryOp : IOperationClass<C> 
        {
            public C Class => C.TernaryOp; 

            public static implicit operator OperatorClass(TernaryOp src)
                => default;

            public OperatorClass Generalized => default;
        }

        public readonly struct OperatorClass<T> : IOperationClass<C,T> 
            where T : unmanaged 
        { 
            public C Class => C.Operator; 
        }

        public readonly struct UnaryOp<T> : IOperationClass<C,T> 
            where T : unmanaged 
        { 
            public static implicit operator OperatorClass<T>(UnaryOp<T> src)
                => default;
            
            [MethodImpl(Inline)]
            public static implicit operator UnaryOp(UnaryOp<T> src)
                => default;
                        
            public C Class => C.UnaryOp; 

            public OperatorClass<T> Generalized => default;

            public UnaryOp NonGeneric => default;
        }

        public readonly struct BinaryOp<T> : IOperationClass<C,T> 
            where T : unmanaged 
        { 
            public static implicit operator OperatorClass<T>(BinaryOp<T> src)
                => default;
            
            [MethodImpl(Inline)]
            public static implicit operator BinaryOp(BinaryOp<T> src)
                => default;
                        
            public C Class => C.BinaryOp; 

            public OperatorClass<T> Generalized => default;

            public BinaryOp NonGeneric => default;
            
        }

        public readonly struct TernaryOp<T> : IOperationClass<C,T> 
            where T : unmanaged 
        {
            [MethodImpl(Inline)]
            public static implicit operator OperatorClass<T>(TernaryOp<T> src)
                => default;

            [MethodImpl(Inline)]
            public static implicit operator TernaryOp(TernaryOp<T> src)
                => default;

            public C Class => C.TernaryOp; 

            public OperatorClass<T> Generalized => default;

            public TernaryOp NonGeneric => default;

        }
    }
}