//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    /// <summary>
    /// Defines literals that correspond to x86 immediate widths
    /// </summary>
    [Flags]
    public enum ImmWidth : uint
    {        
        /// <summary>
        /// Specifies the vaccuous constant
        ///</summary>
        None = 0,

        /// <summary>
        /// Specifies the width of an 8-bit immediate
        ///</summary>
        W8 = 8,

        /// <summary>
        /// Specifies the width of a 16-bit immediate
        ///</summary>
        W16 = 16,

        /// <summary>
        /// Specifies the width of a 32-bit immediate
        ///</summary>
        W32 = 32,

        /// <summary>
        /// Specifies the width of a 64-bit immediate
        ///</summary>
        W64 = 64,

    }
}