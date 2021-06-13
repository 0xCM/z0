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
    [SymbolSource]
    public enum RegWidth : ushort
    {
        /// <summary>
        /// Specifies the width with a 0-bit register
        ///</summary>
        None = 0,

        /// <summary>
        /// Specifies the width of an 8-bit register
        ///</summary>
        [Symbol("w8", "Specifies the width of an 8-bit register")]
        W8 = W.W8,

        /// <summary>
        /// Specifies the width of a 16-bit register
        ///</summary>
        [Symbol("w16", "Specifies the width of a 16-bit register")]
        W16 = W.W16,

        /// <summary>
        /// Specifies the width of a 32-bit register
        ///</summary>
        [Symbol("w32" ,"Specifies the width of a 32-bit register")]
        W32 = W.W32,

        /// <summary>
        /// Specifies the width of a 64-bit register
        ///</summary>
        [Symbol("w64", "Specifies the width of a 64-bit register")]
        W64 = W.W64,

        /// <summary>
        /// Specifies the width of an 80-bit register
        ///</summary>
        [Symbol("w80", "Specifies the width of an 80-bit register")]
        W80 = W.W80,

        /// <summary>
        /// Specifies the width of a 128-bit register
        ///</summary>
        [Symbol("w128", "Specifies the width of a 128-bit register")]
        W128 = W.W128,

        /// <summary>
        /// Specifies the width of a 256-bit register
        ///</summary>
        [Symbol("w256", "Specifies the width of a 256-bit register")]
        W256 = 256,

        /// <summary>
        /// Specifies the width of a 512-bit register
        ///</summary>
        [Symbol("w512", "Specifies the width of a 512-bit register")]
        W512 = W.W512,
    }
}