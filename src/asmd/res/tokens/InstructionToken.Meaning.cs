//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
    using static InstructionTokenMeaning;

    readonly partial struct InstructionTokenInfo
    {
        public static string[] Meanings
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
    
    public class InstructionTokenMeaning
    {
        public const string None =          text.Empty;

        public const string bnd =           "A 128-bit bounds register. BND0 through BND3";

        public const string DST =           "The destination in an instruction; this field is encoded by reg_field";

        public const string ᛁerᛁ =           "Indicates support for embedded rounding control, which is only applicable to the register-register form of the instruction. This also implies support for SAE (Suppress All Exceptions)";

        public const string imm8 =          "An immediate 8-bit value in the inclusive range [–128, 127]. For instructions in which imm8 is combined with a word or doubleword operand, the immediate value is sign-extended to form a word or doubleword. The upper byte of the word is filled with the topmost bit of the immediate value";

        public const string imm16 =         "An immediate value for a 16-bit operand in the inclusive range [–32_768, 32_767]";

        public const string imm32 =         "An immediate value for a 32-bit operand in the inclusive range [–2_147_483_648, 2_147_483_647]";

        public const string imm64 =         "An immediate value for a 64-bit operand in the inclusive range [–9_223_372_036_854_775_808, 9_223_372_036_854_775_807]";

        public const string k1 =            "A mask register used as a regular operand (either destination or source). The 64-bit k registers are: k0 through k7";

        public const string m =             "An operand in memory of width 16, 32 or 64 bits";

        public const string m8 =            "A byte operand in memory ( usually expressed as a variable or array name) but pointed to by the DS:(E)SI or ES:(E)DI registers. In 64-bit mode, it is pointed to by the RSI or RDI registers";

        public const string m16  =          "A word operand in memory (usually expressed as a variable or array name) but pointed to by the DS:(E)SI or ES:(E)DI registers. This nomenclature is used only with the string instructions";

        public const string m32  =          "A doubleword operand in memory (usually expressed as a variable or array name) but pointed to by the DS:(E)SI or ES:(E)DI registers. This nomenclature is used only with the string instructions";

        public const string m64  =          "A memory quadword operand in memory";

        public const string m128 =          "A memory double quadword operand in memory";

        public const string m16ᙾ16 =        "A memory operand containing a far pointer composed of two numbers. The number to the left of the colon corresponds to the pointer's segment selector. The number to the right corresponds to its offset";

        public const string m16ᙾ32  =       "A memory operand containing a far pointer composed of two numbers. The number to the left of the colon corresponds to the pointer's segment selector. The number to the right corresponds to its offset";

        public const string m16ᙾ64 =        "A memory operand containing a far pointer composed of two numbers. The number to the left of the colon corresponds to the pointer's segment selector. The number to the right corresponds to its offset";

        public const string m16Ʌ32 =        "A memory operand consisting of data item pairs whose sizes are indicated on the left and the right side of the ampersand. All memory addressing modes are allowed. The m16&16 and m32&32 operands are used by the BOUND instruction to provide an operand containing an upper and lower bounds for array indices. The m16&32 operand is used by LIDT and LGDT to provide a word with which to load the limit field, and a doubleword with which to load the base field of the corresponding GDTR and IDTR registers. The m16&64 operand is used by LIDT and LGDT in 64-bit mode to provide a word with which to load the limit field, and a quadword with which to load the base field of the corresponding GDTR and IDTR registers";

        public const string m16Ʌ16 =        "A memory operand consisting of data item pairs whose sizes are indicated on the left and the right side of the ampersand. All memory addressing modes are allowed. The m16&16 and m32&32 operands are used by the BOUND instruction to provide an operand containing an upper and lower bounds for array indices. The m16&32 operand is used by LIDT and LGDT to provide a word with which to load the limit field, and a doubleword with which to load the base field of the corresponding GDTR and IDTR registers. The m16&64 operand is used by LIDT and LGDT in 64-bit mode to provide a word with which to load the limit field, and a quadword with which to load the base field of the corresponding GDTR and IDTR registers";

        public const string m32Ʌ32 =        "A memory operand consisting of data item pairs whose sizes are indicated on the left and the right side of the ampersand. All memory addressing modes are allowed. The m16&16 and m32&32 operands are used by the BOUND instruction to provide an operand containing an upper and lower bounds for array indices. The m16&32 operand is used by LIDT and LGDT to provide a word with which to load the limit field, and a doubleword with which to load the base field of the corresponding GDTR and IDTR registers. The m16&64 operand is used by LIDT and LGDT in 64-bit mode to provide a word with which to load the limit field, and a quadword with which to load the base field of the corresponding GDTR and IDTR registers";

        public const string m16Ʌ64 =        "A memory operand consisting of data item pairs whose sizes are indicated on the left and the right side of the ampersand. All memory addressing modes are allowed. The m16&16 and m32&32 operands are used by the BOUND instruction to provide an operand containing an upper and lower bounds for array indices. The m16&32 operand is used by LIDT and LGDT to provide a word with which to load the limit field, and a doubleword with which to load the base field of the corresponding GDTR and IDTR registers. The m16&64 operand is used by LIDT and LGDT in 64-bit mode to provide a word with which to load the limit field, and a quadword with which to load the base field of the corresponding GDTR and IDTR registers";

        public const string m32fp =         "A single-precision floating-point operand in memory. These symbols designate floating-point values that are usedas operands for x87 FPU floating-point instructions";

        public const string m64fp =         "A double-precision floating-point operand in memory. These symbols designate floating-point values that are used as operands for x87 FPU floating-point instructions";

        public const string m80fp =         "A double extended-precision floating-point operand in memory. These symbols designate floating-point values that are used as operands for x87 FPU floating-point instructions";

        public const string m16int = "A word integer operand in memory. These symbols designate integers that are used as operands for x87 FPU integer instructions";

        public const string m32int = "A doubleword integer operand in memory. These symbols designate integers that are used as operands for x87 FPU integer instructions";

        public const string m64int = "A quadword integer operand in memory. These symbols designate integers that are used as operands for x87 FPU integer instructions";

        public const string mm = "An MMX register. The 64-bit MMX registers are: MM0 through MM7. The 64-bit MMX registers are: MM0 through MM7. The contents of memory are found at the address provided by the effective address computation.";

        public const string mmノm32 = "The low order 32 bits of an MMX register or a 32-bit memory operand";

        public const string mmノm64 = "An MMX register or a 64-bit memory operand";

        public const string mib = "A memory operand using SIB addressing form, where the index register is not used in address calculation, Scale is ignored. Only the base and displacement are used in effective address calculation";

        public const string moffs8 = "A simple memory variable (memory offset) of type byte, word, or doubleword used by some variants of the MOV instruction. The actual address is given by a simple offset relative to the segment base. No ModR/M byte is used in the instruction. The number shown with moffs indicates its size, which is determined by the address-size attribute of the instruction";

        public const string moffs16 = "A simple memory variable (memory offset) of type byte, word, or doubleword used by some variants of the MOV instruction. The actual address is given by a simple offset relative to the segment base. No ModR/M byte is used in the instruction. The number shown with moffs indicates its size, which is determined by the address-size attribute of the instruction";

        public const string moffs32 = "A simple memory variable (memory offset) of type byte, word, or doubleword used by some variants of the MOV instruction. The actual address is given by a simple offset relative to the segment base. No ModR/M byte is used in the instruction. The number shown with moffs indicates its size, which is determined by the address-size attribute of the instruction";

        public const string moffs64 = "A simple memory variable (memory offset) of type byte, word, or doubleword used by some variants of the MOV instruction. The actual address is given by a simple offset relative to the segment base. No ModR/M byte is used in the instruction. The number shown with moffs indicates its size, which is determined by the address-size attribute of the instruction";

        public const string ptr16ᙾ16 = "A far pointer typically to a code segment different from that of the instruction. The notation 16:16 indicates that the value of the pointer has two parts. The value to the left of the colon is a 16- bit selector or value destined for the code segment register. The value to the right corresponds to the offset within the destination segment. The ptr16:16 symbol is used when the instruction's operand-size attribute is 16 bits";

        public const string ptr16ᙾ32 = "A far pointer typically to a code segment different from that of the instruction and similar to ptr16:16 notation; in this case the ptr16:32 symbol is used when the operand-size attribute is 32 bits";

        public const string r8   = "One of the byte general-purpose registers: {AL CL DL BL AH CH DH BH BPL SPL DIL SIL}; or one of the byte registers (R8L-R15L) available when using REX.R and 64-bit mode.";

        public const string r16  = "One of the word general-purpose registers: {AX CX DX BX SP BP SI DI}; or one of the word registers (R8-R15) available when using REX.R and 64-bit mode";

        public const string r32  = "One of the doubleword general-purpose registers: {EAX ECX EDX EBX ESP EBP ESI EDI}; or one of the doubleword registers (R8D - R15D) available when using REX.R in 64-bit mode";

        public const string r64  = "One of the quadword general-purpose registers: {RAX RBX RCX RDX RDI RSI RBP RSP R8–R15}; These are available when using REX.R and 64-bit mode";

        public const string rel8 = "A relative address in the range from 128 bytes before the end of the instruction to 127 bytes after the end of the instruction";

        public const string rel16 = "A relative address within the same code segment as the instruction assembled. The rel16 symbol applies to instructions with an operand-size attribute of 16 bits";

        public const string rel32 = "A relative address within the same code segment as the instruction assembled. The rel32 symbol applies to instructions with an operand-size attribute of 32 bits";

        public const string rノm8 = "A byte operand that is either the contents of a byte general-purpose register: {AL CL DL BL AH CH DH BH BPL SPL DIL SIL}; or a byte from memory. Byte registers R8L - R15L are available using REX.R in 64-bit mode";

        public const string rノm16 = "A word general-purpose register or memory operand used for instructions whose operand-size attribute is 16 bits. The word general-purpose registers are: AX, CX, DX, BX, SP, BP, SI, DI. The contents of memory are found at the address provided by the effective address computation. Word registers R8W - R15W are available using REX.R in 64-bit mode";

        public const string rノm32 = "A doubleword general-purpose register or memory operand used for instructions whose operand size attribute is 32 bits. The doubleword general-purpose registers are: EAX, ECX, EDX, EBX, ESP, EBP, ESI, EDI. The contents of memory are found at the address provided by the effective address computation. Doubleword registers R8D - R15D are available when using REX.R in 64-bit mode";

        public const string rノm64 = "A quadword general-purpose register or memory operand used for instructions whose operand-size attribute is 64 bits when using REX.W. Quadword general-purpose registers are: RAX, RBX, RCX, RDX, RDI, RSI, RBP, RSP, R8–R15; these are available only in 64-bit mode. The contents of memory are found at the address provided by the effective address computation";

        public const string Sreg = "A segment register. The segment register bit assignments are ES = 0, CS = 1, SS = 2, DS = 3, FS = 4, and GS = 5";

        public const string ᛁsaeᛁ = "Indicates support for SAE (Suppress All Exceptions). This is used for instructions that support SAE, but do not support embedded rounding control";

        public const string SRC  = "The source in a single-source instruction";

        public const string SRC1 = "Denotes the first source operand in the instruction syntax of an instruction encoded with the VEX/EVEX prefix and having two or more source operands";

        public const string SRC2 = "Denotes the second source operand in the instruction syntax of an instruction encoded with the VEX/EVEX prefix and having two or more source operands";

        public const string SRC3 = "Denotes the third source operand in the instruction syntax of an instruction encoded with the VEX/EVEX prefix and having three source operands";

        public const string ST   = "The top element of the FPU register stack; a synonym for ST(0)";

        public const string STᐸ0ᐳ= "The top element of the FPU register stack";

        public const string xmm  = "An XMM register. The 128-bit XMM registers are: XMM0 through XMM7; XMM8 through XMM15 are available using REX.R in 64-bit mode.";

        public const string xmmノ32 = "An XMM register or a 32-bit memory operand. The 128-bit XMM registers are XMM0 through XMM7; XMM8 through XMM15 are available using REX.R in 64-bit mode. The contents of memory are found at the address provided by the effective address computation";

        public const string xmmノ64 = "An XMM register or a 64-bit memory operand. The 128-bit SIMD floating-point registers are XMM0 through XMM7; XMM8 through XMM15 are available using REX.R in 64-bit mode. The contents of memory are found at the address provided by the effective address computation";

        public const string xmmノ128 = "An XMM register or a 128-bit memory operand. The 128-bit XMM registers are XMM0 through XMM7; XMM8 through XMM15 are available using REX.R in 64-bit mode. The contents of memory are found at the address provided by the effective address computation";

        public const string ᐸXMM0ᐳ = "Indicates implied use of the XMM0 register. When there is ambiguity xmm1 indicates the first source operand using an XMM register and xmm2 the second source operand using an XMM register. Some instructions use the XMM0 register as the third source operand, indicated by <XMM0>. The use of the third XMM register operand is implicit in the instruction encoding and does not affect the ModR/M encoding";

        public const string ymm  = "A YMM register. The 256-bit YMM registers are: YMM0 through YMM7; YMM8 through YMM15 are available in 64-bit mode";

        public const string m256 = "A 32-byte operand in memory. This nomenclature is used only with AVX instructions";

        public const string ymmノm256 = "A YMM register or 256-bit memory operand";

        public const string ᐸYMM0ᐳ = "Indicates use of the YMM0 register as an implicit argument";

        public const string zmm  = "A ZMM register";

        public const string m512 = "A 64-byte operand in memory";

        public const string zmmノm512 = "A ZMM register or 512-bit memory operand";

        public const string mV = "A vector memory operand; the operand size is dependent on the instruction";

        public const string m32bcst = "A broadcast from a 32-bit memory location ";

        public const string m64bcst = "A broadcast from a 64-bit memory location";

        public const string zmmノm512ノm32bcst = "An operand that can be a ZMM register, a 512-bit memory location or a 512-bit vector loaded from a 32-bit memory location";

        public const string zmmノm512ノm64bcst = "An operand that can be a ZMM register, a 512-bit memory location or a 512-bit vector loaded from a 64-bit memory location";

        public const string ᐸZMM0ᐳ = "Indicates use of the ZMM0 register as an implicit argument";
    }
}