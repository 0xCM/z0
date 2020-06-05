//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
    using System;

    public class InstructionTokenValue
    {
        public const string None = text.Empty;

        public const string bnd = "bnd";

        public const string DST = "DST";

        public const string ᛁerᛁ = "{er}";

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

        public const string m16ᙾ16 = "m16:16";

        public const string m16ᙾ32 = "m16:32";

        public const string m16ᙾ64 = "m16:64";

        public const string m16Ʌ32 = "m16&32";

        public const string m16Ʌ16 = "m16&16";

        public const string m32Ʌ32 = "m32&32";

        public const string m16Ʌ64 = "m16&64";

        public const string m32fp  = "m32fp";

        public const string m64fp  = "m64fp";

        public const string m80fp  = "m80fp";

        public const string m16int = "m16int";

        public const string m32int = "m32int";

        public const string m64int = "m64int";

        public const string mm = "mm";

        public const string mmノm32 = "mm/m32";

        public const string mmノm64 = "mm/m64";

        public const string mib = "mib";

        public const string moffs8 = "moffs8";

        public const string moffs16 = "moffs16";

        public const string moffs32 = "moffs32";

        public const string moffs64 = "moffs64";

        public const string ptr16ᙾ16 = "ptr16:16";

        public const string ptr16ᙾ32 = "ptr16:32";
 
        public const string r8  = "r8";
 
        public const string r16 = "r16";
 
        public const string r32 = "r32";
 
        public const string r64 = "r64";
 
        public const string rel8  = "rel8";
 
        public const string rel16 = "rel16";
 
        public const string rel32 = "rel32";
 
        public const string rノm8 = "r/m8";
 
        public const string rノm16= "r/m16";
 
        public const string rノm32= "r/m32";
 
        public const string rノm64= "r/m64";
 
        public const string Sreg  = "Sreg";
 
        public const string ᛁsaeᛁ = "{sae}";
 
        public const string SRC = "SRC";
 
        public const string SRC1  = "SRC1";
 
        public const string SRC2  = "SRC2";
 
        public const string SRC3  = "SRC3";
 
        public const string ST  = "ST";
 
        public const string STᐸ0ᐳ = "ST(0)";
 
        public const string xmm = "xmm";
 
        public const string xmmノ32 = "xmm/m32";
 
        public const string xmmノ64 = "xmm/m64";
 
        public const string xmmノ128 = "xmm/m128";
 
        public const string ᐸXMM0ᐳ= "<XMM0>";
 
        public const string ymm = "ymm";
 
        public const string m256  = "m256";
 
        public const string ymmノm256 = "ymm/m256";
 
        public const string ᐸYMM0ᐳ = "<YMM0>";
 
        public const string zmm = "zmm";
 
        public const string m512  = "m512";
 
        public const string zmmノm512 = "zmm/m512";
 
        public const string mV  = "mV";
 
        public const string m32bcst = "m32bcst";
 
        public const string m64bcst = "m64bcst";
 
        public const string zmmノm512ノm32bcst = "zmm/m512/m32bcst";
 
        public const string zmmノm512ノm64bcst = "zmm/m512/m64bcst";
 
        public const string ᐸZMM0ᐳ = "<ZMM0>";
    }
}