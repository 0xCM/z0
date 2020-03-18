//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static OpTypes;
    using OC = OperationClass;
    using C = PredicateClass;


    [Flags]
    public enum PredicateClass : ushort
    {
        /// <summary>
        /// The empty class
        /// </summary>        
        None = 0,
       
        /// <summary>
        /// Classifies functions that return a system boolean value or a bit value
        /// </summary>        
        Predicate = OC.Predicate,

        /// <summary>
        /// Classifies predicates that accept one argument
        /// </summary>        
        UnaryPred = OC.UnaryPred,

        /// <summary>
        /// Classifies predicates that accept two arguments
        /// </summary>        
        BinaryPred = OC.BinaryPred,

        /// <summary>
        /// Classifies predicates that accept three arguments
        /// </summary>        
        TernaryPred = OC.TernaryPred,
    }    

    public static partial class OpTypes
    {
        public readonly struct UnaryPred : IKind<UnaryPred, C> { public C Class => C.UnaryPred; }

        public readonly struct BinaryPred : IKind<BinaryPred, C> { public C Class => C.BinaryPred; }

        public readonly struct TernaryPred : IKind<TernaryPred, C> { public C Class => C.TernaryPred; }

        public readonly struct UnaryPred<T> : IKind<UnaryPred<T>, C, T> where T : unmanaged { public C Class => C.UnaryPred; }

        public readonly struct BinaryPred<T> : IKind<BinaryPred<T>, C, T> where T : unmanaged { public C Class => C.BinaryPred; }

        public readonly struct TernaryPred<T> : IKind<TernaryPred<T>, C, T> where T : unmanaged { public C Class => C.TernaryPred; }
    }

    public static partial class OpReps
    {
        public static UnaryPred UnaryPred => default;

        public static BinaryPred BinaryPred => default;

        public static TernaryPred TernaryPred => default;

        public static UnaryPred<T> unaryPred<T>() where T : unmanaged => default;

        public static BinaryPred<T> binaryPred<T>() where T : unmanaged => default;

        public static TernaryPred<T> ternaryPred<T>() where T : unmanaged => default;
    }
}