//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;
    
    using static zfunc;

    /// <summary>
    /// Classifies operator arities
    /// </summary>
    public enum OpArityKind : byte
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
        Ternary = 4,

        /// <summary>
        /// Classifies an n-ary operator
        /// </summary>
        Sequence = 8
    }


}