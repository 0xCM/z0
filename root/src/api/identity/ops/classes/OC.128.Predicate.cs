//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Classes;
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

    public static partial class Classes
    {
        public readonly struct UnaryPred : IOpClass<C> { public C Class => C.UnaryPred; }

        public readonly struct BinaryPred : IOpClass<C> { public C Class => C.BinaryPred; }

        public readonly struct TernaryPred : IOpClass<C> { public C Class => C.TernaryPred; }

        public readonly struct UnaryPred<T> : IOpClass<C,T> where T : unmanaged { public C Class => C.UnaryPred; }

        public readonly struct BinaryPred<T> : IOpClass<C,T> where T : unmanaged { public C Class => C.BinaryPred; }

        public readonly struct TernaryPred<T> : IOpClass<C,T> where T : unmanaged { public C Class => C.TernaryPred; }
    }

    public static partial class ClassReps
    {
        public static UnaryPred UnaryPred => default;

        public static BinaryPred BinaryPred => default;

        public static TernaryPred TernaryPred => default;

        public static UnaryPred<T> unaryPred<T>() where T : unmanaged => default;

        public static BinaryPred<T> binaryPred<T>() where T : unmanaged => default;

        public static TernaryPred<T> ternaryPred<T>() where T : unmanaged => default;
    }
}