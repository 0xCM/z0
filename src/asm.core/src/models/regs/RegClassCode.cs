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
    [SymSource]
    public enum RegClassCode : byte
    {
        None = 0,

        /// <summary>
        /// A general-purpose register of width <see cref='W8'/>, <see cref='W16'/>, <see cref='W32'/> or <see cref='W64'/>
        /// </summary>
        [Symbol("gp", "A general purpose register of bit-width 8,16,32 or 64")]
        GP,

        /// <summary>
        /// Classifies a 64-bit mask register
        /// </summary>
        [Symbol("k")]
        MASK,

        /// <summary>
        /// Classifies an xmm vector register of width <see cref='W128'/>
        /// </summary>
        [Symbol("xmm")]
        XMM ,

        /// <summary>
        /// Classifies a ymm vector register of width <see cref='W256'/>
        /// </summary>
        [Symbol("ymm")]
        YMM,

        /// <summary>
        /// Classifies a zmm vector register of width <see cref='W512'/>
        /// </summary>
        [Symbol("zmm")]
        ZMM,

        /// <summary>
        /// Classifies a 64-bit mmx register
        /// </summary>
        [Symbol("mmx")]
        MMX,

        /// <summary>
        /// Identifies a segment register
        /// </summary>
        [Symbol("seg", "A segment regitser")]
        SEG,

        /// <summary>
        /// An flag register of width <see cref='W16'/>, <see cref='W32'/> or <see cref='W64'/>
        /// </summary>
        [Symbol("flags", "A system flags register of bit-width 16,32 or 64")]
        FLAG,

        /// <summary>
        /// Class identifier control registers
        /// </summary>
        [Symbol("cr")]
        CR,

       /// <summary>
        /// Classifies a 64-bit extended control register
        /// </summary>
        [Symbol("xcr")]
        XCR,

        /// <summary>
        /// Class identifier for debug registers
        /// </summary>
        [Symbol("db")]
        DB,

        /// <summary>
        /// Classifies an 80-bit fpu register
        /// </summary>
        [Symbol("st")]
        ST,

        /// <summary>
        /// Classifies a 128-bit bounds register
        /// </summary>
        [Symbol("bnd")]
        BND,

        /// <summary>
        /// Class identifier for pointer table registers
        /// </summary>
        [Symbol("sptr")]
        SPTR,

        /// <summary>
        /// Classifies an instruction-pointer register of width <see cref='W16'/>, <see cref='W32'/> or <see cref='W64'/>
        /// </summary>
        [Symbol("iptr")]
        IPTR,

        /// <summary>
        /// Classifies the upper four bits of the gp byte registers
        /// </summary>
        [Symbol("gp8hi")]
        GP8HI,
    }
}