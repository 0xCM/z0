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

    public enum OpArityKind
    {
        
        /// <summary>
        /// Identifies an operator with no arguments
        /// </summary>
        Nullary = 0,

        /// <summary>
        /// Identifies an operator with one argument
        /// </summary>
        Unary = 1,

        /// <summary>
        /// Identifies an operator with two arguments
        /// </summary>
        Binary = 2,

        /// <summary>
        /// Identifies an operator with three arguments
        /// </summary>
        Ternary = 3,

        /// <summary>
        /// Identifies an n-ary operator where n > 3
        /// </summary>
        Sequence = 4
    }


}