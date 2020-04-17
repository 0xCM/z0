//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    /// <summary>
    /// Defines literals that correspond to x86 registger widths
    /// </summary>
    [Flags]
    public enum RegisterWidth : uint
    {        
        /// <summary>
        /// Specifies the register with a 0-bit register
        ///</summary>
        None = 0,

        /// <summary>
        /// Specifies the width of an 8-bit register
        ///</summary>
        W8 = 8,

        /// <summary>
        /// Specifies the width of a 16-bit register
        ///</summary>
        W16 = 16,

        /// <summary>
        /// Specifies the width of a 32-bit register
        ///</summary>
        W32 = 32,

        /// <summary>
        /// Specifies the width of a 64-bit register
        ///</summary>
        W64 = 64,

        /// <summary>
        /// Specifies the width of an 80-bit register
        ///</summary>
        W80 = 80,

        /// <summary>
        /// Specifies the width of a 128-bit register
        ///</summary>
        W128 = 128,

        /// <summary>
        /// Specifies the width of a 256-bit register
        ///</summary>
        W256 = 256,

        /// <summary>
        /// Specifies the width of a 512-bit register
        ///</summary>
        W512 = 512
    }
}