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
    /// Classifies function/receiver arities
    /// </summary>
    public enum ArityKind : byte
    {       
        /// <summary>
        /// Classifies an operator with no arguments
        /// </summary>
        Nullary = 0,

        /// <summary>
        /// Classifies an operator with one argument
        /// </summary>
        Unary = 1,

        /// <summary>
        /// Classifies an operator with two arguments
        /// </summary>
        Binary = 2,

        /// <summary>
        /// Classifies an operator with three arguments
        /// </summary>
        Ternary = 3,
    }
}