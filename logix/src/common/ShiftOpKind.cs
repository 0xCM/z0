//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;
    
    using static zfunc;

    /// <summary>
    /// Classifies bitwise shift operators
    /// </summary>
    [Flags]
    public enum ShiftOpKind : uint
    {
        /// <summary>
        /// Logical left-shift
        /// </summary>
        Sll = 1,

        /// <summary>
        /// Logical right-shift
        /// </summary>
        Srl = 2,

        /// <summary>
        /// Left circular shift
        /// </summary>
        Rotl = 4,

        /// <summary>
        /// Right circular shift
        /// </summary>
        Rotr  = 8,

        Inc = 16,

        Dec = 32,

        

        
    }


}