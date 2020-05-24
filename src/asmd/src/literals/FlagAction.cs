//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{        
    using System;

    /// <summary>
    /// Specifies an instruction's impact on eflags
    /// </summary>
    [Flags]
    public enum FlagAction : byte
    {        
        /// <summary>
        /// Flags neither read nor molested
        /// </summary>
        None,
        
        /// <summary>
        /// Flag state is queried
        /// </summary>
        Test,
        
        /// <summary>
        /// Flag state is cleared, i.e. disabled
        /// </summary>
        Clear,

        /// <summary>
        /// Flag state is set, i.e. enabled
        /// </summary>
        Set,
        
        /// <summary>
        /// Flag state is cleared or set
        /// </summary>
        Modify = Clear | Set,

        /// <summary>
        /// Flag is restored to prior state
        /// </summary>
        Restore
    }
}