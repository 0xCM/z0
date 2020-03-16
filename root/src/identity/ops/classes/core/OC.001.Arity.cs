//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using OC = OperationClass;

    [Flags]
    public enum ArityClass : ulong
    {
        /// <summary>
        /// The empty class
        /// </summary>
        None = 0,

        /// <summary>
        /// Classifies operations of arity 0
        /// </summary>        
        Nullary = OC.Nullary,

        /// <summary>
        /// Classifies operations of arity 1
        /// </summary>        
        Unary = OC.Unary,

        /// <summary>
        /// Classifies operations of arity 2
        /// </summary>        
        Binary = OC.Binary,

        /// <summary>
        /// Classifies operations of arity 3
        /// </summary>        
        Ternary = OC.Ternary,   
    }    
}