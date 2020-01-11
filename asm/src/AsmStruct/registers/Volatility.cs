//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{

    using System;
    using System.Runtime.InteropServices;
    using System.Runtime.CompilerServices;

    using static zfunc;

    /// <summary>
    /// Characterizes a register's intrinsic volatility. Volatile registers are
    /// often referred to as *scratch* registers because, beyond a function call,
    /// they are presumed to have no persistent state
    /// </summary>
    [Flags]
    public enum Volatility : uint
    {
        
        /// <summary>
        /// Volatility is unknown
        /// </summary>
        Unknown = 0,
        
        /// <summary>
        /// Reigister is volatile and thus has no persistent state beyoned a function call
        /// </summary>
        Volatile = 1,

        /// <summary>
        /// Reigister is non-volatile and thus has persistent state that is maintained
        /// between function calls; if used, caller must save/restore state upon function
        /// entry/exit
        /// </summary>
        NonVolatile = 2,

        
        /// <summary>
        /// Register has some segments that are volatile and some that are not
        /// </summary>
        Mixed = Volatile | NonVolatile

    }

}