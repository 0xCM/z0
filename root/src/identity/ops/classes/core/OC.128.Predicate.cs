//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using OC = OperationClass;

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
        UnaryPred = OC.UnaryPredicate,

        /// <summary>
        /// Classifies predicates that accept two arguments
        /// </summary>        
        BinaryPred = OC.BinaryPredicate,

        /// <summary>
        /// Classifies predicates that accept three arguments
        /// </summary>        
        TernaryPred = OC.TernaryPredicate,
    }    
}