//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    /// <summary>
    /// Defines literals that correspond to intrinsic x86 memory widths
    /// </summary>
    [Flags]
    public enum MemoryWidth : uint
    {        
        /// <summary>
        /// Specifies a segment of memory with a bit width of 0
        ///</summary>
        None = 0,

        /// <summary>
        /// Specifies the width of an 8-bit memory segment
        ///</summary>
        W8 = 8,

        /// <summary>
        /// Specifies the width of a 16-bit memory segment
        ///</summary>
        W16 = 16,

        /// <summary>
        /// Specifies the width of a 32-bit memory segment
        ///</summary>
        W32 = 32,

        /// <summary>
        /// Specifies the width of a 64-bit memory segment
        ///</summary>
        W64 = 64,

        /// <summary>
        /// Specifies the width of a 128-bit memory segment
        ///</summary>
        W128 = 128,

        /// <summary>
        /// Specifies the width of a 256-bit memory segment
        ///</summary>
        W256 = 256,

        /// <summary>
        /// Specifies the width of a 512-bit memory segment
        ///</summary>
        W512 = 512
    }
}