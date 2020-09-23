//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static Hex8Seq;

    public enum AsmPrefixCode : byte
    {
        LOCK = xf0,

        REPNE = xf2,

        REP = xf3,

        OP = x66,

        CS = x2e,

        DS = x3e,

        ES = x26,

        FS = x64,

        GS = x65,

        SS = x36,

        Address = x67,

        RexW = x48,

        RexWB = x49,

        RexWX = x4a,

        RexXB = x4b,

        RexWR = x4c,

        RexWRB = x4d,

        RexWRX = x4e,

        RexWRXB = x4f,
    }

    /// <summary>
    ///
    /// </summary>
    public enum ImageAddressModifier
    {
        /// <summary>
        /// An absolute address
        /// </summary>
        None = x00,

        /// <summary>
        /// A 64-bit virtual address
        /// </summary>
        Va64 = x01,

        /// <summary>
        /// A 32-bit virtual address
        /// </summary>
        Va32 = x02,

        /// <summary>
        /// An unbased 32-bit address (RVA)
        /// </summary>
        Rva32 = x03,

        /// <summary>
        /// A 32-bit RVA with a 1 byte offset
        /// </summary>
        Rva32x1 = x05,

        /// <summary>
        /// A 32-bit RVA with a 2 byte offset
        /// </summary>
        Rva32x2 = x06,

        /// <summary>
        /// A 32-bit RVA with a 3 byte offset
        /// </summary>
        Rva32x3 = x07,

        /// <summary>
        /// A 32-bit RVA with a 4 byte offset
        /// </summary>
        Rva32x4 = x08,

        /// <summary>
        /// A 32-bit RVA with a 5 byte offset
        /// </summary>
        Rva32x5 = x09,

        /// <summary>
        /// A section index
        /// </summary>
        Section =x0a,

        /// <summary>
        /// A section-relative 32-bit offset
        /// </summary>
        SectionOffset = x0b,

        /// <summary>
        /// A section-relative 7-bit offset
        /// </summary>
        SectionOffset7 = x0c,

        /// <summary>
        /// A 32-bit metadata token
        /// </summary>
        Token=x0d
    }

}