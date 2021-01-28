//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static AsmTokenMeaning;

    partial class AsmTokenIndex
    {
        public string[] Meaning
            = new string[TokenCount]{
                None, bnd, DST, ᛁerᛁ,  imm8, imm16, imm32, imm64, k1, m, AsmTokenMeaning.m8,
                AsmTokenMeaning.m16, AsmTokenMeaning.m32, AsmTokenMeaning.m64, AsmTokenMeaning.m128, m16ᙾ16, m16ᙾ32, m16ᙾ64, m16Ʌ32, m16Ʌ16,
                m32Ʌ32, m16Ʌ64, m32fp, m64fp, m80fp, m16int, m32int, m64int,
                mm, mmノm32, mmノm64, mib, moffs8, moffs16, moffs32, moffs64,
                ptr16ᙾ16, ptr16ᙾ32, r8, r16, r32, r64, rel8, rel16, rel32,
                rノm8, rノm16, rノm32,  rノm64, Sreg, ᛁsaeᛁ, SRC, SRC1, SRC2,
                SRC3, ST, STᐸ0ᐳ, xmm, xmmノ32, xmmノ64, xmmノ128, ᐸXMM0ᐳ,
                ymm, m256, ymmノm256, ᐸYMM0ᐳ, zmm, m512, zmmノm512,
                mV, m32bcst, m64bcst, zmmノm512ノm32bcst, zmmノm512ノm64bcst,
                ᐸZMM0ᐳ,
            };
    }
}