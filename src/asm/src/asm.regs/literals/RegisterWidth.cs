//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using W = DataWidth;

    /// <summary>
    /// Defines a <see cref='DataWidth' subset that corresponds to x86 register widths and
    /// </summary>
    public enum RegisterWidth : ushort
    {
        /// <summary>
        /// Specifies the register with a 0-bit register
        ///</summary>
        None = 0,

        /// <summary>
        /// Specifies the width of an 8-bit register
        ///</summary>
        W8 = W.W8,

        /// <summary>
        /// Specifies the width of a 16-bit register
        ///</summary>
        W16 = W.W16,

        /// <summary>
        /// Specifies the width of a 32-bit register
        ///</summary>
        W32 = W.W32,

        /// <summary>
        /// Specifies the width of a 64-bit register
        ///</summary>
        W64 = W.W64,

        /// <summary>
        /// Specifies the width of an 80-bit register
        ///</summary>
        W80 = W.W80,

        /// <summary>
        /// Specifies the width of a 128-bit register
        ///</summary>
        W128 = W.W128,

        /// <summary>
        /// Specifies the width of a 256-bit register
        ///</summary>
        W256 = 256,

        /// <summary>
        /// Specifies the width of a 512-bit register
        ///</summary>
        W512 = W.W512,
    }
}