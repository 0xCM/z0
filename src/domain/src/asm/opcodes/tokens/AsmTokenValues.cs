//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Tokens
{    
    public readonly struct AsmTokenValues
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
 
        /// <example>
        /// 017ah mov [rdi+7ff9h],gs ; MOV r32/m16, Sreg || o32 8C /r || encoded[6]{8c af f9 7f 00 00}
        /// </example>
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

        /// <example>
        /// located://bitmatrix/api?rnot#rnot_g[16u](bm16x16u~in,bm16x16u~in,bm16x16u~in)
        /// 0000h sub rsp,38h                             ; SUB r/m64, imm8 || REX.W 83 /5 ib || encoded[4]{48 83 ec 38}
        /// 0004h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
        /// 0007h mov rax,[rdx]                           ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b 02}
        /// 000ah mov rdx,[r8]                            ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{49 8b 10}
        /// 000dh vxorps ymm0,ymm0,ymm0                   ; VXORPS ymm1, ymm2, ymm3/m256 || VEX.256.0F.WIG 57 /r || encoded[4]{c5 fc 57 c0}
        /// 0011h vmovupd [rsp],ymm0                      ; VMOVUPD ymm2/m256, ymm1 || VEX.256.66.0F.WIG 11 /r || encoded[5]{c5 fd 11 04 24}
        /// 0016h vlddqu ymm0,ymmword ptr [rax]           ; VLDDQU ymm1, m256 || VEX.256.F2.0F.WIG F0 /r || encoded[4]{c5 ff f0 00}
        /// 001ah vmovupd [rsp],ymm0                      ; VMOVUPD ymm2/m256, ymm1 || VEX.256.66.0F.WIG 11 /r || encoded[5]{c5 fd 11 04 24}
        /// 001fh vmovupd ymm0,[rsp]                      ; VMOVUPD ymm1, ymm2/m256 || VEX.256.66.0F.WIG 10 /r || encoded[5]{c5 fd 10 04 24}
        /// 0024h vpcmpeqw ymm1,ymm0,ymm0                 ; VPCMPEQW ymm1, ymm2, ymm3/m256 || VEX.256.66.0F.WIG 75 /r || encoded[4]{c5 fd 75 c8}
        /// 0028h vpxor ymm0,ymm0,ymm1                    ; VPXOR ymm1, ymm2, ymm3/m256 || VEX.256.66.0F.WIG EF /r || encoded[4]{c5 fd ef c1}
        /// 002ch vmovdqu ymmword ptr [rdx],ymm0          ; VMOVDQU ymm2/m256, ymm1 || VEX.256.F3.0F.WIG 7F /r || encoded[4]{c5 fe 7f 02}
        /// 0030h mov rax,r8                              ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{49 8b c0}
        /// 0033h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
        /// 0036h add rsp,38h                             ; ADD r/m64, imm8 || REX.W 83 /0 ib || encoded[4]{48 83 c4 38}
        /// 003ah ret                                     ; RET || C3 || encoded[1]{c3}
        /// </example>
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