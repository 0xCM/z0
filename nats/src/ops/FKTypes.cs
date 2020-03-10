//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    /// <summary>
    /// Function-kinded types
    /// </summary>
    public static class FKT
    {
        public readonly struct FuncType<R> : IFuncType<R>
        {
            public const FunctionClass Kind = FunctionClass.Func0;

            [MethodImpl(Inline)]
            public static implicit operator FunctionClass(FuncType<R> src)
                =>  src.Classifier;


            public FunctionClass Classifier { [MethodImpl(Inline)] get=> Kind;}
        }

        public readonly struct FuncType<T1,R> : IFuncType<T1,R>
        {
            public const FunctionClass Kind = FunctionClass.Func1;

            [MethodImpl(Inline)]
            public static implicit operator FunctionClass(FuncType<T1,R> src)
                =>  src.Classifier;

            public FunctionClass Classifier { [MethodImpl(Inline)] get=> Kind;}
        }

        public readonly struct FuncType<T1,T2,R> : IFuncType<T1,T2,R>
        {
            public const FunctionClass Kind = FunctionClass.Func2;


            [MethodImpl(Inline)]
            public static implicit operator FunctionClass(FuncType<T1,T2,R> src)
                =>  src.Classifier;

            public FunctionClass Classifier { [MethodImpl(Inline)] get=> Kind;}
        }

        public readonly struct FuncType<T1,T2,T3,R> : IFuncType<T1,T2,T3,R>
        {
            public const FunctionClass Kind = FunctionClass.Func3;

            [MethodImpl(Inline)]
            public static implicit operator FunctionClass(FuncType<T1,T2,T3,R> src)
                =>  src.Classifier;

            public FunctionClass Classifier { [MethodImpl(Inline)] get=> Kind;}
        }

        public readonly struct UnaryFuncType : IFuncType, IFuncArity<N1>
        {
            public const FunctionClass Kind = FunctionClass.UnaryFunc;

            [MethodImpl(Inline)]
            public static implicit operator FunctionClass(UnaryFuncType src)
                =>  src.Classifier;

            public FunctionClass Classifier { [MethodImpl(Inline)] get=> Kind;}
        }

        public readonly struct BinaryFuncType : IFuncType, IFuncArity<N2>
        {
            public const FunctionClass Kind = FunctionClass.BinaryFunc;

            [MethodImpl(Inline)]
            public static implicit operator FunctionClass(BinaryFuncType src)
                =>  src.Classifier;

            public FunctionClass Classifier { [MethodImpl(Inline)] get=> Kind;}
        }

        public readonly struct TernaryFuncType : IFuncType, IFuncArity<N3>
        {
            public const FunctionClass Kind = FunctionClass.TernaryFunc;


            [MethodImpl(Inline)]
            public static implicit operator FunctionClass(TernaryFuncType src)
                =>  src.Classifier;

            public FunctionClass Classifier { [MethodImpl(Inline)] get=> Kind;}
        }

        /// <summary>
        /// Classifier for operators of known arity
        /// </summary>
        /// <typeparam name="N">The arity type</typeparam>
        public readonly struct OperatorType<N> : IOperatorFuncType<N>
            where N : unmanaged, ITypeNat
        {
            public static FunctionClass Kind => FK.ofk<N>();

            [MethodImpl(Inline)]
            public static implicit operator FunctionClass(OperatorType<N> src)
                => src.Classifier;

            public FunctionClass Classifier { [MethodImpl(Inline)] get=> Kind;}
        }

        /// <summary>
        /// Classifier for operators of known arity and operand types
        /// </summary>
        /// <typeparam name="N">The arity type</typeparam>
        /// <typeparam name="T">The operand type</typeparam>
        public readonly struct OperatorType<N,T> : IOperatorFuncType<N,T>
            where N : unmanaged, ITypeNat
        {
            public static FunctionClass Kind => FK.ofk<N>();

            [MethodImpl(Inline)]
            public static implicit operator FunctionClass(OperatorType<N,T> src)
                => src.Classifier;

            [MethodImpl(Inline)]
            public static implicit operator FuncType<T,T>(OperatorType<N,T> src)
                => default;

            public FunctionClass Classifier { [MethodImpl(Inline)] get=> Kind;}
        }

        public readonly struct UnaryOpType : IOperatorFuncType<N1>
        {
            public const FunctionClass Kind = FunctionClass.UnaryOp;

            [MethodImpl(Inline)]
            public static implicit operator FunctionClass(UnaryOpType src)
                => src.Classifier;

            [MethodImpl(Inline)]
            public static implicit operator OperatorType<N1>(UnaryOpType src)
                => default;

            [MethodImpl(Inline)]
            public static implicit operator UnaryOpType(OperatorType<N1> src)
                => default;

            public FunctionClass Classifier { [MethodImpl(Inline)] get=> Kind;}
        }

        public readonly struct UnaryOpType<T> : IFuncType<N1,T>
        {
            public const FunctionClass Kind = FunctionClass.UnaryOp;

            [MethodImpl(Inline)]
            public static implicit operator OperatorType<N1>(UnaryOpType<T> src)
                => default;

            [MethodImpl(Inline)]
            public static implicit operator OperatorType<N1,T>(UnaryOpType<T> src)
                => default;

            [MethodImpl(Inline)]
            public static implicit operator UnaryOpType<T>(OperatorType<N1,T> src)
                => default;

            [MethodImpl(Inline)]
            public static implicit operator FunctionClass(UnaryOpType<T> src)
                => src.Classifier;

            [MethodImpl(Inline)]
            public static implicit operator FuncType<T,T>(UnaryOpType<T> src)
                => default;

            [MethodImpl(Inline)]
            public static implicit operator UnaryOpType(UnaryOpType<T> src)
                => default;
            
            public FunctionClass Classifier { [MethodImpl(Inline)] get=> Kind;}
        }

        public readonly struct BinaryOpType : IFuncArity<N2>
        {
            public const FunctionClass Kind = FunctionClass.BinaryOp;

            [MethodImpl(Inline)]
            public static implicit operator OperatorType<N2>(BinaryOpType src)
                => default;

            [MethodImpl(Inline)]
            public static implicit operator BinaryOpType(OperatorType<N2> src)
                => default;

            [MethodImpl(Inline)]
            public static implicit operator FunctionClass(BinaryOpType src)
                => src.Classifier;

            public FunctionClass Classifier { [MethodImpl(Inline)] get=> Kind;}
        }

        public readonly struct BinaryOpType<T> : IFuncType<N2,T>
        {
            public const FunctionClass Kind = FunctionClass.BinaryOp;

            public FunctionClass Classifier { [MethodImpl(Inline)] get=> Kind;}

            [MethodImpl(Inline)]
            public static implicit operator OperatorType<N2>(BinaryOpType<T> src)
                => default;

            [MethodImpl(Inline)]
            public static implicit operator OperatorType<N3,T>(BinaryOpType<T> src)
                => default;

            [MethodImpl(Inline)]
            public static implicit operator BinaryOpType<T>(OperatorType<N3,T> src)
                => default;

            [MethodImpl(Inline)]
            public static implicit operator FunctionClass(BinaryOpType<T> src)
                => src.Classifier;

            [MethodImpl(Inline)]
            public static implicit operator FuncType<T,T,T>(BinaryOpType<T> src)
                => default;
            

            [MethodImpl(Inline)]
            public static implicit operator BinaryOpType(BinaryOpType<T> src)
                => default;
        }

        public readonly struct TernaryOpType : IOperatorFuncType<N3>
        {
            public const FunctionClass Kind = FunctionClass.TernaryOp;

            public FunctionClass Classifier { [MethodImpl(Inline)] get=> Kind;}

            [MethodImpl(Inline)]
            public static implicit operator OperatorType<N3>(TernaryOpType src)
                => default;

            [MethodImpl(Inline)]
            public static implicit operator TernaryOpType(OperatorType<N3> src)
                => default;

            [MethodImpl(Inline)]
            public static implicit operator FunctionClass(TernaryOpType src)
                => src.Classifier;

            [MethodImpl(Inline)]
            public static implicit operator TernaryFuncType(TernaryOpType src)
                => default;
        }

        public readonly struct TernaryOpType<T> : IOperatorFuncType<N3,T>
        {
            public const FunctionClass Kind = FunctionClass.TernaryOp;

            public FunctionClass Classifier { [MethodImpl(Inline)] get=> Kind;}

            [MethodImpl(Inline)]
            public static implicit operator FunctionClass(TernaryOpType<T> src)
                => src.Classifier;

            [MethodImpl(Inline)]
            public static implicit operator FuncType<T,T,T,T>(TernaryOpType<T> src)
                => default;

            [MethodImpl(Inline)]
            public static implicit operator TernaryFuncType(TernaryOpType<T> src)
                => default;

            [MethodImpl(Inline)]
            public static implicit operator OperatorType<N3>(TernaryOpType<T> src)
                => default;

            [MethodImpl(Inline)]
            public static implicit operator OperatorType<N3,T>(TernaryOpType<T> src)
                => default;

            [MethodImpl(Inline)]
            public static implicit operator TernaryOpType<T>(OperatorType<N3,T> src)
                => default;
        }        
    }
}