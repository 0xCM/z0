//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    /// <summary>
    /// Defines 0 and 1
    /// </summary>
    [Flags]
    public enum Pow2Kind1 : byte
    {
        /// <summary> 
        /// 2^0 - 1 = 0
        /// </summary> 
        T00m1 = T00 & ~T00,

        /// <summary>
        /// 2^0 = 1
        /// </summary>
        T00 = 1,

        /// <summary>
        /// 2^1 - 1 = 1
        /// </summary>
        T01m1 = T00,

        /// <summary> 
        /// The maximum value representable by a 1-bit unsigned integer
        /// </summary> 
        Max1 = T01m1,
    }
}