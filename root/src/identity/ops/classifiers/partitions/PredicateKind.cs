//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Root;
    using static OpKindId;    
    
    using A = OpKindAttribute;

    public enum PredicateKind : ulong
    {
        None = 0,
       
        /// <summary>
        /// Classifies a function as a unary predicate
        /// </summary>        
        UnaryPred = FunctionKind.UnaryPred,

        /// <summary>
        /// Classifies a function as a binary predicate
        /// </summary>        
        BinaryPred = FunctionKind.BinaryPred,

       /// <summary>
       /// Classifies a function as a ternary predicate
       /// </summary>        
       TernaryPred = FunctionKind.TernaryPred,   
    }    

    public sealed class PredAttribute : A { public PredAttribute() : base(Pred) {} }
}