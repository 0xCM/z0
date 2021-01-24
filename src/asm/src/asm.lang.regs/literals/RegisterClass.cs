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
    public enum RegisterClass : byte
    {
        /// <summary>
        /// A non-numbered general-purpose register of width <see cref='W8'/>, <see cref='W16'/>, <see cref='W32'/> or <see cref='W64'/>
        /// </summary>
        GP = 1,

        /// <summary>
        /// A numbered general-purpose register of width <see cref='W8'/>, <see cref='W16'/>, <see cref='W32'/> or <see cref='W64'/>
        /// </summary>
        GPN = 2,

        /// <summary>
        /// Identifies a segment register
        /// </summary>
        SEG = 3,

        /// <summary>
        /// An flag register of width <see cref='W16'/>, <see cref='W32'/> or <see cref='W64'/>
        /// </summary>
        FLAG = 4,

        /// <summary>
        /// Classifies a control register
        /// </summary>
        Control = 5,

        /// <summary>
        /// Classifies a debug register
        /// </summary>
        Debug = 6,

        /// <summary>
        /// Classifies an xmm vector register of width <see cref='W128'/>
        /// </summary>
        XMM = 10,

        /// <summary>
        /// Classifies a ymm vector register of width <see cref='W256'/>
        /// </summary>
        YMM = 11,

        /// <summary>
        /// Classifies a zmm vector register of width <see cref='W512'/>
        /// </summary>
        ZMM = 12,

        /// <summary>
        /// Classifies a 64-bit mask register
        /// </summary>
        Mask = 13,
    }
}