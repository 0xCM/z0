//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static Limits;

    /// <summary>
    /// Assigns surrogate keys to instruction signature keywords
    /// </summary>
    public enum AsmSigKeywordId : byte
    {
        /// <summary>
        /// Indicates the absence of a keyword specification
        /// </summary>
        None = 0,

        /// <summary>
        /// A 128-bit bounds register. BND0 through BND3
        /// </summary>
        bnd,

        /// <summary>
        /// The destination in an instruction; this field is encoded by reg_field
        /// </summary>
        DST,

        /// <summary>
        /// Indicates support for embedded rounding control
        /// </summary>
        ᛁerᛁ,

        /// <summary>
        /// An immediate <see cref='W8'/> value in the inclusive range [<see cref='Min8i'/>, <see cref='Max8i'/>]
        /// </summary>
        /// <remarks>
        /// For instructions in which imm8 is combined with a word or doubleword operand, the immediate value is
        /// sign-extended to form a word or doubleword. The upper byte of the word is filled with the topmost
        /// bit of the immediate value
        /// </remarks>
        imm8,

        /// <summary>
        /// An immediate value for an operand of width <see cref='W16'/> in the inclusive range [<see cref='Min16i'/>, <see cref='Max16i'/>]
        /// </summary>
        imm16,

        /// <summary>
        /// An immediate value for an operand of width <see cref='W32'/> in the inclusive range [<see cref='Min32i'/>, <see cref='Max32i'/>]
        /// </summary>
        imm32,

        /// <summary>
        /// An immediate value for an operand of width <see cref='W64'/> in the inclusive range [<see cref='Min64i'/>, <see cref='Max64i'/>]
        /// </summary>
        imm64,

        /// <summary>
        /// A mask register used as a regular operand (either destination or source). The 64-bit k registers are: k0 through k7
        /// </summary>
        k1,

        /// <summary>
        /// An operand in memory of width <see cref='W16'/>, <see cref='W32'/> or <see cref='W64'/> bits
        /// </summary>
        m,

        /// <summary>
        /// An operand in memory of width <see cref='W8'/> pointed to by a register that <see cref='AsmOperatingMode'/> dependent
        /// </summary>
        /// <remarks>
        /// For <see cref='AsmOperatingMode.Non64'/> mode, is pointed to by one of
        /// <see cref='DS'/>:<see cref='SI'/>
        /// <see cref='DS'/>:<see cref='ESI'/>
        /// <see cref='ES'/>:<see cref='DI'/>
        /// <see cref='ES'/>:<see cref='EDI'/>
        /// For <see cref='AsmOperatingMode.Mode64'/>, it is pointed to by one of
        /// <see cref='RSI'/>
        /// <see cref='RDI'/>
        /// </remarks>
        m8,

        /// <summary>
        /// An operand in memory of width <see cref='W16'/>, pointed to by a register, and applicable only to string instructions
        /// </summary>
        /// <remarks>
        /// The register is one of
        /// <see cref='DS'/>:<see cref='SI'/>
        /// <see cref='DS'/>:<see cref='ESI'/>
        /// </remarks>
        m16,

        /// <summary>
        /// An operand in memory of width <see cref='W32'/>, pointed to by a register, and applicable only to string instructions
        /// </summary>
        /// <remarks>
        /// The register is one of
        /// <see cref='DS'/><see cref='SI'/>
        /// <see cref='DS'/>:<see cref='ESI'/>
        /// </remarks>
        m32,

        /// <summary>
        /// An operand in memory of width <see cref='W64'/>
        /// </summary>
        m64,

        /// <summary>
        /// An operand in memory of width <see cref='W128'/>
        /// </summary>
        m128,

        /// <summary>
        /// A memory operand containing a far pointer expressed as a segment-selector/offset pair
        /// </summary>
        /// <remarks>
        /// For the expression S:R, S denotes the pointer's segment selector and R designates the offset
        /// </remarks>
        m16ᙾ16,

        /// <summary>
        ///
        /// </summary>
        m16ᙾ32,

        /// <summary>
        ///
        /// </summary>
        m16ᙾ64,

        /// <summary>
        ///
        /// </summary>
        m16Ʌ32,

        /// <summary>
        ///
        /// </summary>
        m16Ʌ16,

        /// <summary>
        ///
        /// </summary>
        m32Ʌ32,

        /// <summary>
        ///
        /// </summary>
        m16Ʌ64,

        /// <summary>
        ///
        /// </summary>
        m32fp,

        /// <summary>
        ///
        /// </summary>
        m64fp,

        /// <summary>
        ///
        /// </summary>
        m80fp,

        /// <summary>
        ///
        /// </summary>
        m16int,

        /// <summary>
        ///
        /// </summary>
        m32int,

        /// <summary>
        ///
        /// </summary>
        m64int,

        /// <summary>
        ///
        /// </summary>
        mm,

        /// <summary>
        ///
        /// </summary>
        mmノm32,

        /// <summary>
        ///
        /// </summary>
        mmノm64,

        /// <summary>
        ///
        /// </summary>
        mib,

        /// <summary>
        ///
        /// </summary>
        moffs8,

        /// <summary>
        ///
        /// </summary>
        moffs16,

        /// <summary>
        ///
        /// </summary>
        moffs32,

        /// <summary>
        ///
        /// </summary>
        moffs64,

        /// <summary>
        ///
        /// </summary>
        ptr16ᙾ16,

        /// <summary>
        ///
        /// </summary>
        ptr16ᙾ32,

        /// <summary>
        ///
        /// </summary>
        r8 ,

        /// <summary>
        ///
        /// </summary>
        r16,

        /// <summary>
        ///
        /// </summary>
        r32,

        /// <summary>
        ///
        /// </summary>
        r64,

        /// <summary>
        ///
        /// </summary>
        rel8,

        /// <summary>
        ///
        /// </summary>
        rel16,

        /// <summary>
        ///
        /// </summary>
        rel32,

        /// <summary>
        ///
        /// </summary>
        rノm8,

        /// <summary>
        ///
        /// </summary>
        rノm16,

        /// <summary>
        ///
        /// </summary>
        rノm32,

        /// <summary>
        ///
        /// </summary>
        rノm64,

        /// <summary>
        ///
        /// </summary>
        Sreg,

        /// <summary>
        ///
        /// </summary>
        ᛁsaeᛁ,

        /// <summary>
        ///
        /// </summary>
        SRC,

        /// <summary>
        ///
        /// </summary>
        SRC1,

        /// <summary>
        ///
        /// </summary>
        SRC2,

        /// <summary>
        ///
        /// </summary>
        SRC3,

        /// <summary>
        ///
        /// </summary>
        ST ,

        /// <summary>
        ///
        /// </summary>
        STᐸ0ᐳ,

        /// <summary>
        ///
        /// </summary>
        xmm,

        /// <summary>
        ///
        /// </summary>
        xmmノ32,

        /// <summary>
        ///
        /// </summary>
        xmmノ64,

        /// <summary>
        ///
        /// </summary>
        xmmノ128,

        /// <summary>
        ///
        /// </summary>
        ᐸXMM0ᐳ,

        /// <summary>
        ///
        /// </summary>
        ymm,

        /// <summary>
        ///
        /// </summary>
        m256,

        /// <summary>
        ///
        /// </summary>
        ymmノm256,

        /// <summary>
        ///
        /// </summary>
        ᐸYMM0ᐳ,

        /// <summary>
        ///
        /// </summary>
        zmm,

        /// <summary>
        ///
        /// </summary>
        m512,

        /// <summary>
        ///
        /// </summary>
        zmmノm512,

        /// <summary>
        ///
        /// </summary>
        mV,

        /// <summary>
        ///
        /// </summary>
        m32bcst,

        /// <summary>
        ///
        /// </summary>
        m64bcst,

        /// <summary>
        ///
        /// </summary>
        zmmノm512ノm32bcst,

        /// <summary>
        ///
        /// </summary>
        zmmノm512ノm64bcst,

        /// <summary>
        ///
        /// </summary>
        ᐸZMM0ᐳ,

        TokenCount = ᐸZMM0ᐳ + 1,
    }
}