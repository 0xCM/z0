//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using OC = OperationClass;
    using C = OperatorClass;
    
    using static OpTypes;


    /// <summary>
    /// Classifies operators of arity either 1, 2, or 3
    /// </summary>
    [Flags]
    public enum OperatorClass : ushort
    {
        /// <summary>
        /// The empty class
        /// </summary>
        None = 0,

        /// <summary>
        /// Classifies functions for which operands and return type are homogenous
        /// </summary>        
        Operator = OC.Operator,

        /// <summary>
        /// Classifies operators that accept one argument
        /// </summary>        
        UnaryOp = OC.UnaryOp,

        /// <summary>
        /// Classifies operators that accept two arguments
        /// </summary>        
        BinaryOp = OC.BinaryOp,
        
        /// <summary>
        /// Classifies operators that accept three arguments
        /// </summary>        
        TernaryOp = OC.TernaryOp,
    }


    public static partial class OpTypes
    {
        public readonly struct UnaryOp : IKind<UnaryOp, C> { public C Class => C.UnaryOp; }

        public readonly struct BinaryOp : IKind<BinaryOp, C> { public C Class => C.BinaryOp; }

        public readonly struct TernaryOp : IKind<TernaryOp, C> { public C Class => C.TernaryOp; }

        public readonly struct UnaryOp<T> : IKind<UnaryOp<T>, C, T> where T : unmanaged { public C Class => C.UnaryOp; }

        public readonly struct BinaryOp<T> : IKind<BinaryOp<T>, C, T> where T : unmanaged { public C Class => C.BinaryOp; }

        public readonly struct TernaryOp<T> : IKind<TernaryOp<T>, C, T> where T : unmanaged { public C Class => C.TernaryOp; }
    }

    public static partial class OpReps
    {
        public static UnaryOp UnaryOp => default;

        public static BinaryOp BinaryOp => default;

        public static TernaryOp TernaryOp => default;

        public static UnaryOp<T> unaryOp<T>() where T : unmanaged => default;

        public static BinaryOp<T> binaryOp<T>() where T : unmanaged => default;

        public static TernaryOp<T> ternaryOp<T>() where T : unmanaged => default;
    }
}