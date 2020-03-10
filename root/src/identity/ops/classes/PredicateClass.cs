//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Root;
    
    using FC = FunctionClass;

    public enum PredicateClass : ulong
    {
        None = 0,
       
        /// <summary>
        /// Classifies a function as a unary predicate
        /// </summary>        
        UnaryPred = FC.UnaryPred,

        /// <summary>
        /// Classifies a function as a binary predicate
        /// </summary>        
        BinaryPred = FC.BinaryPred,

       /// <summary>
       /// Classifies a function as a ternary predicate
       /// </summary>        
       TernaryPred = FC.TernaryPred,   
    }    
}