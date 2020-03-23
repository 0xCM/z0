//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using C = OperatorClass;

    partial class OperationClasses
    {
        public readonly struct OperatorClass : IOperationClass<C> 
        {
            public C Class => C.Operator; 
        } 

        public readonly struct UnaryOp : IOperationClass<C> 
        {
            public C Class => C.UnaryOp; 

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
            
            public C Class => C.UnaryOp; 

            public OperatorClass<T> Generalized => default;
        }

        public readonly struct BinaryOp<T> : IOperationClass<C,T> 
            where T : unmanaged 
        { 
            public static implicit operator OperatorClass<T>(BinaryOp<T> src)
                => default;
            
            public C Class => C.BinaryOp; 

            public OperatorClass<T> Generalized => default;
        }

        public readonly struct TernaryOp<T> : IOperationClass<C,T> 
            where T : unmanaged 
        {
            public static implicit operator OperatorClass<T>(TernaryOp<T> src)
                => default;
                
                public C Class => C.TernaryOp; 

            public OperatorClass<T> Generalized => default;
        }
    }
}