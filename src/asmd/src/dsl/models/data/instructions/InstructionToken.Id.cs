//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
    using static InstructionTokenId;

    partial struct InstructionTokenInfo
    {
        public static string[] Identity
            => new string[TokenCount]{ 
                None, bnd, DST, ᛁerᛁ,  imm8, imm16, imm32, imm64, k1, m, m8, 
                m16, m32, m64, m128, m16ᙾ16, m16ᙾ32, m16ᙾ64, m16Ʌ32, m16Ʌ16,
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
    
    public class InstructionTokenId
    {
        public const string None = text.Empty;

        public const string bnd = "bnd";

        public const string DST = "DST";

        public const string ᛁerᛁ = "ᛁerᛁ";

        public const string imm8 = "imm8";

        public const string imm16 = "imm16";

        public const string imm32 = "imm32";

        public const string imm64 = "imm64";

        public const string k1 = "k1";

        public const string m = "m";

        public const string m8 = "m8";

        public const string m16 = "m16";

        public const string m32 = "m32";

        public const string m64 = "m64";

        public const string m128= "m128";

        public const string m16ᙾ16 = "m16ᙾ16";

        public const string m16ᙾ32 = "m16ᙾ32";

        public const string m16ᙾ64 = "m16ᙾ64";

        public const string m16Ʌ32 = "m16Ʌ32";

        public const string m16Ʌ16 = "m16Ʌ16";

        public const string m32Ʌ32 = "m32Ʌ32";

        public const string m16Ʌ64 = "m16Ʌ64";

        public const string m32fp  = "m32fp";

        public const string m64fp  = "m64fp";

        public const string m80fp  = "m80fp";

        public const string m16int = "m16int";

        public const string m32int = "m32int";

        public const string m64int = "m64int";

        public const string mm = "mm";

        public const string mmノm32 = "mmノm32";

        public const string mmノm64 = "mmノm64";

        public const string mib = "mib";

        public const string moffs8 = "moffs8";

        public const string moffs16 = "moffs16";

        public const string moffs32 = "moffs32";

        public const string moffs64 = "moffs64";

        public const string ptr16ᙾ16 = "ptr16ᙾ16";

        public const string ptr16ᙾ32 = "ptr16ᙾ32";
 
        public const string r8  = "r8";
 
        public const string r16 = "r16";
 
        public const string r32 = "r32";
 
        public const string r64 = "r64";
 
        public const string rel8  = "rel8";
 
        public const string rel16 = "rel16";
 
        public const string rel32 = "rel32";
 
        public const string rノm8 = "rノm8";
 
        public const string rノm16= "rノm16";
 
        public const string rノm32 = "rノm32";
 
        public const string rノm64 = "rノm64";
 
        public const string Sreg  = "Sreg";
 
        public const string ᛁsaeᛁ = "ᛁsaeᛁ";
 
        public const string SRC = "SRC";
 
        public const string SRC1  = "SRC1";
 
        public const string SRC2  = "SRC2";
 
        public const string SRC3  = "SRC3";
 
        public const string ST  = "ST";
 
        public const string STᐸ0ᐳ = "STᐸ0ᐳ";
 
        public const string xmm = "xmm";
 
        public const string xmmノ32 = "xmmノ32";
 
        public const string xmmノ64 = "xmmノ64";
 
        public const string xmmノ128 = "xmmノ128";
 
        public const string ᐸXMM0ᐳ= "ᐸXMM0ᐳ";
 
        public const string ymm = "ymm";
 
        public const string m256  = "m256";
 
        public const string ymmノm256 = "ymmノm256";
 
        public const string ᐸYMM0ᐳ = "ᐸYMM0ᐳ";
 
        public const string zmm = "zmm";
 
        public const string m512  = "m512";
 
        public const string zmmノm512 = "zmmノm512";
 
        public const string mV  = "mV";
 
        public const string m32bcst = "m32bcst";
 
        public const string m64bcst = "m64bcst";
 
        public const string zmmノm512ノm32bcst = "zmmノm512ノm32bcst";
 
        public const string zmmノm512ノm64bcst = "zmmノm512ノm64bcst";
 
        public const string ᐸZMM0ᐳ = "ᐸZMM0ᐳ";
    }


}