//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static DataWidth;

    /// <summary>
    /// Defines register class identifiers
    /// </summary>
    [SymbolSource]
    public enum RegClass : byte
    {
        /// <summary>
        /// A general-purpose register of width <see cref='W8'/>, <see cref='W16'/>, <see cref='W32'/> or <see cref='W64'/>
        /// </summary>
        [Symbol("gp")]
        GP = 1,

        /// <summary>
        /// Identifies a segment register
        /// </summary>
        [Symbol("seg")]
        SEG = 2,

        /// <summary>
        /// An flag register of width <see cref='W16'/>, <see cref='W32'/> or <see cref='W64'/>
        /// </summary>
        [Symbol("flags")]
        FLAG = 3,

        /// <summary>
        /// Class identifier control registers
        /// </summary>
        [Symbol("cr")]
        CR = 4,

        /// <summary>
        /// Class identifier for debug registers
        /// </summary>
        [Symbol("db")]
        DB = 5,

        /// <summary>
        /// Classifies an instruction-pointer register of width <see cref='W16'/>, <see cref='W32'/> or <see cref='W64'/>
        /// </summary>
        [Symbol("iptr")]
        IPTR = 6,

        /// <summary>
        /// Class identifier for pointer table registers
        /// </summary>
        [Symbol("sptr")]
        SPTR = 7,

        /// <summary>
        /// Classifies an xmm vector register of width <see cref='W128'/>
        /// </summary>
        [Symbol("xmm")]
        XMM = 8,

        /// <summary>
        /// Classifies a ymm vector register of width <see cref='W256'/>
        /// </summary>
        [Symbol("ymm")]
        YMM = 9,

        /// <summary>
        /// Classifies a zmm vector register of width <see cref='W512'/>
        /// </summary>
        [Symbol("zmm")]
        ZMM = 10,

        /// <summary>
        /// Classifies a 64-bit mask register
        /// </summary>
        [Symbol("k")]
        MASK = 11,

        /// <summary>
        /// Classifies a 128-bit bounds register
        /// </summary>
        [Symbol("bnd")]
        BND = 12,

        /// <summary>
        /// Classifies an 80-bit fpu register
        /// </summary>
        [Symbol("st")]
        ST = 13,

        /// <summary>
        /// Classifies a 64-bit mmx register
        /// </summary>
        [Symbol("mmx")]
        MMX = 14,
    }
}