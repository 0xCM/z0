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
    public enum RegClass : byte
    {
        /// <summary>
        /// A general-purpose register of width <see cref='W8'/>, <see cref='W16'/>, <see cref='W32'/> or <see cref='W64'/>
        /// </summary>
        GP = 1,

        /// <summary>
        /// Identifies a segment register
        /// </summary>
        SEG = 2,

        /// <summary>
        /// An flag register of width <see cref='W16'/>, <see cref='W32'/> or <see cref='W64'/>
        /// </summary>
        FLAG = 3,

        /// <summary>
        /// Class identifier control registers
        /// </summary>
        Control = 4,

        /// <summary>
        /// Class identifier for debug registers
        /// </summary>
        Debug = 5,

        /// <summary>
        /// Classifies an instruction-pointer register of width <see cref='W16'/>, <see cref='W32'/> or <see cref='W64'/>
        /// </summary>
        IPTR = 6,

        /// <summary>
        /// Class identifier for pointer table registers
        /// </summary>
        SPTR = 7,

        /// <summary>
        /// Classifies an xmm vector register of width <see cref='W128'/>
        /// </summary>
        XMM = 8,

        /// <summary>
        /// Classifies a ymm vector register of width <see cref='W256'/>
        /// </summary>
        YMM = 9,

        /// <summary>
        /// Classifies a zmm vector register of width <see cref='W512'/>
        /// </summary>
        ZMM = 10,

        /// <summary>
        /// Classifies a 64-bit mask register
        /// </summary>
        Mask = 11,
    }
}