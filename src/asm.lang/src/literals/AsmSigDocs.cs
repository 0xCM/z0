//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    [LiteralProvider]
    public readonly struct AsmSigDocs
    {
        public const string NE = "Not encodable";

        public const string NP = "Indicates the use of 66/F2/F3 prefixes (beyond those already part of the instructions opcode) are not allowed with the instruction";

        public const string NFx = "Indicates the use of F2/F3 prefixes (beyond those already part of the instructions opcode) are not allowed with the instruction.";

        public const string ᕀi = "A number used in floating-point instructions when one of the operands is ST(i) from the FPU register stack.";

        public const string bnd = "A 128-bit bounds register. BND0 through BND3";

        public const string DST = "The destination in an instruction; this field is encoded by reg_field";

        public const string ᛁerᛁ = "Indicates support for embedded rounding control, which is only applicable to the register-register form of the instruction. This also implies support for SAE (Suppress All Exceptions)";

        public const string m = "An operand in memory of width 16, 32 or 64 bits";

        public const string m8 = "A byte operand in memory ( usually expressed as a variable or array name) but pointed to by the DS:(E)SI or ES:(E)DI registers. In 64-bit mode, it is pointed to by the RSI or RDI registers";

        public const string m16  = "A word operand in memory (usually expressed as a variable or array name) but pointed to by the DS:(E)SI or ES:(E)DI registers. This nomenclature is used only with the string instructions";

        public const string m32  = "A doubleword operand in memory (usually expressed as a variable or array name) but pointed to by the DS:(E)SI or ES:(E)DI registers. This nomenclature is used only with the string instructions";


        public const string m16ᙾ16 = "A memory operand containing a far pointer composed of two numbers. The number to the left of the colon corresponds to the pointer's segment selector. The number to the right corresponds to its offset";

        public const string m16ᙾ32 = "A memory operand containing a far pointer composed of two numbers. The number to the left of the colon corresponds to the pointer's segment selector. The number to the right corresponds to its offset";

        public const string m16ᙾ64 = "A memory operand containing a far pointer composed of two numbers. The number to the left of the colon corresponds to the pointer's segment selector. The number to the right corresponds to its offset";

        public const string m16Ʌ16 = "A memory operand consisting of data item pairs whose sizes are indicated on the left and the right side of the ampersand. All memory addressing modes are allowed. The m16&16 and m32&32 operands are used by the BOUND instruction to provide an operand containing an upper and lower bounds for array indices. The m16&32 operand is used by LIDT and LGDT to provide a word with which to load the limit field, and a doubleword with which to load the base field of the corresponding GDTR and IDTR registers. The m16&64 operand is used by LIDT and LGDT in 64-bit mode to provide a word with which to load the limit field, and a quadword with which to load the base field of the corresponding GDTR and IDTR registers";

        public const string m16Ʌ32 = "A memory operand consisting of data item pairs whose sizes are indicated on the left and the right side of the ampersand. All memory addressing modes are allowed. The m16&16 and m32&32 operands are used by the BOUND instruction to provide an operand containing an upper and lower bounds for array indices. The m16&32 operand is used by LIDT and LGDT to provide a word with which to load the limit field, and a doubleword with which to load the base field of the corresponding GDTR and IDTR registers. The m16&64 operand is used by LIDT and LGDT in 64-bit mode to provide a word with which to load the limit field, and a quadword with which to load the base field of the corresponding GDTR and IDTR registers";

        public const string m32Ʌ32 = "A memory operand consisting of data item pairs whose sizes are indicated on the left and the right side of the ampersand. All memory addressing modes are allowed. The m16&16 and m32&32 operands are used by the BOUND instruction to provide an operand containing an upper and lower bounds for array indices. The m16&32 operand is used by LIDT and LGDT to provide a word with which to load the limit field, and a doubleword with which to load the base field of the corresponding GDTR and IDTR registers. The m16&64 operand is used by LIDT and LGDT in 64-bit mode to provide a word with which to load the limit field, and a quadword with which to load the base field of the corresponding GDTR and IDTR registers";

        public const string m16Ʌ64 = "A memory operand consisting of data item pairs whose sizes are indicated on the left and the right side of the ampersand. All memory addressing modes are allowed. The operand is used by LIDT and LGDT in 64-bit mode to provide a word with which to load the limit field, and a quadword with which to load the base field of the corresponding GDTR and IDTR registers";

        public const string ptr16ᙾ16 = "A far pointer typically to a code segment different from that of the instruction. The notation 16:16 indicates that the value of the pointer has two parts. The value to the left of the colon is a 16- bit selector or value destined for the code segment register. The value to the right corresponds to the offset within the destination segment. The ptr16:16 symbol is used when the instruction's operand-size attribute is 16 bits";

        public const string ptr16ᙾ32 = "A far pointer typically to a code segment different from that of the instruction and similar to ptr16:16 notation; in this case the ptr16:32 symbol is used when the operand-size attribute is 32 bits";

        public const string m32fp = "A single-precision floating-point operand in memory. These symbols designate floating-point values that are usedas operands for x87 FPU floating-point instructions";

        public const string m64fp = "A double-precision floating-point operand in memory. These symbols designate floating-point values that are used as operands for x87 FPU floating-point instructions";

        public const string m80fp = "A double extended-precision floating-point operand in memory. These symbols designate floating-point values that are used as operands for x87 FPU floating-point instructions";


        public const string mmノm32 = "The low order 32 bits of an MMX register or a 32-bit memory operand";

        public const string mmノm64 = "An MMX register or a 64-bit memory operand";

        public const string mib = "A memory operand using SIB addressing form, where the index register is not used in address calculation, Scale is ignored. Only the base and displacement are used in effective address calculation";

        public const string rm8 = "A byte operand that is either the contents of a byte general-purpose register: {AL CL DL BL AH CH DH BH BPL SPL DIL SIL}; or a byte from memory. Byte registers R8L - R15L are available using REX.R in 64-bit mode";

        public const string sae = "Indicates support for SAE (Suppress All Exceptions). This is used for instructions that support SAE, but do not support embedded rounding control";

        public const string SRC  = "The source in a single-source instruction";

        public const string SRC1 = "Denotes the first source operand in the instruction syntax of an instruction encoded with the VEX/EVEX prefix and having two or more source operands";

        public const string SRC2 = "Denotes the second source operand in the instruction syntax of an instruction encoded with the VEX/EVEX prefix and having two or more source operands";

        public const string SRC3 = "Denotes the third source operand in the instruction syntax of an instruction encoded with the VEX/EVEX prefix and having three source operands";

        public const string ST = "The top element of the FPU register stack; a synonym for ST(0)";

        public const string ST0 = "The top element of the FPU register stack";

        public const string xmm  = "An XMM register. The 128-bit XMM registers are: XMM0 through XMM7; XMM8 through XMM15 are available using REX.R in 64-bit mode.The contents of memory are found at the address provided by the effective address computation";

        public const string xmm32 = "An XMM register or a 32-bit memory operand. The 128-bit XMM registers are XMM0 through XMM7; XMM8 through XMM15 are available using REX.R in 64-bit mode. The contents of memory are found at the address provided by the effective address computation";

        public const string xmm64 = "An XMM register or a 64-bit memory operand. The 128-bit SIMD floating-point registers are XMM0 through XMM7; XMM8 through XMM15 are available using REX.R in 64-bit mode. The contents of memory are found at the address provided by the effective address computation";

        public const string xmm128 = "An XMM register or a 128-bit memory operand. The 128-bit XMM registers are XMM0 through XMM7; XMM8 through XMM15 are available using REX.R in 64-bit mode. The contents of memory are found at the address provided by the effective address computation";

        public const string ᐸXMM0ᐳ = "Indicates implied use of the XMM0 register. When there is ambiguity xmm1 indicates the first source operand using an XMM register and xmm2 the second source operand using an XMM register. Some instructions use the XMM0 register as the third source operand, indicated by <XMM0>. The use of the third XMM register operand is implicit in the instruction encoding and does not affect the ModR/M encoding";

        public const string ymmノm256 = "A YMM register or 256-bit memory operand";

        public const string ᐸYMM0ᐳ = "Indicates use of the YMM0 register as an implicit argument";

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