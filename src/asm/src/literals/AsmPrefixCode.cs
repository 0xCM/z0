//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static Hex8Kind;

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

    /*
#define IMAGE_REL_AMD64_ABSOLUTE        0x0000  // Reference is absolute, no relocation is necessary
#define IMAGE_REL_AMD64_ADDR64          0x0001  // 64-bit address (VA).
#define IMAGE_REL_AMD64_ADDR32          0x0002  // 32-bit address (VA).
#define IMAGE_REL_AMD64_ADDR32NB        0x0003  // 32-bit address w/o image base (RVA).
#define IMAGE_REL_AMD64_REL32           0x0004  // 32-bit relative address from byte following reloc
#define IMAGE_REL_AMD64_REL32_1         0x0005  // 32-bit relative address from byte distance 1 from reloc
#define IMAGE_REL_AMD64_REL32_2         0x0006  // 32-bit relative address from byte distance 2 from reloc
#define IMAGE_REL_AMD64_REL32_3         0x0007  // 32-bit relative address from byte distance 3 from reloc
#define IMAGE_REL_AMD64_REL32_4         0x0008  // 32-bit relative address from byte distance 4 from reloc
#define IMAGE_REL_AMD64_REL32_5         0x0009  // 32-bit relative address from byte distance 5 from reloc
#define IMAGE_REL_AMD64_SECTION         0x000A  // Section index
#define IMAGE_REL_AMD64_SECREL          0x000B  // 32 bit offset from base of section containing target
#define IMAGE_REL_AMD64_SECREL7         0x000C  // 7 bit unsigned offset from base of section containing target
#define IMAGE_REL_AMD64_TOKEN           0x000D  // 32 bit metadata token


    */

}