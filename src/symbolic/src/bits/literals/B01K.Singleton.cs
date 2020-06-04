//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;

    /// <summary>
    /// Defines literals corresponding to the potential states of a bit
    /// </summary>
    public enum Singleton : byte
    {    
        /// <summary>
        /// Disabled
        /// </summary>
        b0 = 0b0,

        /// <summary>
        /// Enabled
        /// </summary>
        b1 = 0b1,

       /// <summary>
       /// The maximum singleton value
       /// </summary>       
        Max1 = b1,
        
       /// <summary>
       /// The bit width of a singleton
       /// </summary>       
        W1 = 1,        
    }
}