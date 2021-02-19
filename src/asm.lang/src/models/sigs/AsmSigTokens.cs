//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using K = AsmSigOpKind;

    public readonly struct AsmSigTokens
    {
        public readonly struct Al : IAsmSigToken<Al>
        {
            public K Kind => K.AL;

            public string Symbol => "al";

            public string Description => "";
        }

        public readonly struct Ax : IAsmSigToken<Ax>
        {
            public K Kind => K.AX;

            public string Symbol => "ax";

            public string Description => "";
        }

        public readonly struct Eax : IAsmSigToken<Eax>
        {
            public K Kind => K.EAX;

            public string Symbol => "eax";

            public string Description => "";
        }

        public readonly struct Rax : IAsmSigToken<Rax>
        {
            public K Kind => K.RAX;

            public string Symbol => "rax";

            public string Description => "";
        }

        public readonly struct Bnd : IAsmSigToken<Bnd>
        {
            public K Kind => K.BND;

            public string Symbol => "bnd";

            public string Description => "A 128-bit bounds register, BND0 through BND3";
        }

        public readonly struct Imm8 : IAsmSigToken<Imm8>
        {
            public K Kind => K.Imm8;

            public string Symbol => "imm8";

            public string Description => "An 8-bit immediate operand";
        }

        public readonly struct Imm16 : IAsmSigToken<Imm16>
        {
            public K Kind => K.Imm16;

            public string Symbol => "imm16";

            public string Description => "A 16-bit immediate operand";
        }

        public readonly struct Imm32 : IAsmSigToken<Imm32>
        {
            public K Kind => K.Imm32;

            public string Symbol => "imm32";

            public string Description => "A 32-bit immediate operand";
        }

        public readonly struct Imm64: IAsmSigToken<Imm64>
        {
            public K Kind => K.Imm64;

            public string Symbol => "imm64";

            public string Description => "A 64-bit immediate operand";
        }

        public readonly struct R8 : IAsmSigToken<R8>
        {
            public K Kind => K.R8;

            public string Symbol => "r8";

            public string Description => "One of the byte general-purpose registers {AL CL DL BL AH CH DH BH BPL SPL DIL SIL} or one of the byte registers (R8L-R15L) when using REX.R and 64-bit mode.";
        }

        public readonly struct R16 : IAsmSigToken<R16>
        {
            public K Kind => K.R16;

            public string Symbol => "r16";

            public string Description => "One of the word general-purpose registers {AX CX DX BX SP BP SI DI} or one of the word registers (R8-R15) when using REX.R and 64-bit mode";
        }

        public readonly struct R32 : IAsmSigToken<R32>
        {
            public K Kind => K.R32;

            public string Symbol => "r32";

            public string Description => "One of the doubleword general-purpose registers {EAX ECX EDX EBX ESP EBP ESI EDI} or one of the doubleword registers (R8D - R15D) when using REX.R in 64-bit mode";
        }

        public readonly struct R64: IAsmSigToken<R64>
        {
            public K Kind => K.R64;

            public string Symbol => "r64";

            public string Description => "One of the quadword general-purpose registers {RAX RBX RCX RDX RDI RSI RBP RSP} or one of the (R8 - R15) registers when using REX.R and 64-bit mode";
        }

        public readonly struct Rm8 : IAsmSigToken<Rm8>
        {
            public K Kind => K.Rm8;

            public string Symbol => "r/m8";

            public string Description => "A byte operand that is either the contents of a byte general-purpose register or a byte from memory";
        }

        public readonly struct Rm16 : IAsmSigToken<Rm16>
        {
            public K Kind => K.Rm16;

            public string Symbol => "r/m16";

            public string Description => "A word general-purpose register or memory operand used for instructions whose operand-size attribute is 16 bits.";
        }

        public readonly struct Rm32 : IAsmSigToken<Rm32>
        {
            public K Kind => K.Rm32;

            public string Symbol => "r/m32";

            public string Description => "A doubleword general-purpose register or memory operand used for instructions whose operand size attribute is 32 bits.";
        }

        public readonly struct Rm64: IAsmSigToken<Rm64>
        {
            public K Kind => K.Rm64;

            public string Symbol => "r/m64";

            public string Description => "A quadword general-purpose register or memory operand used for instructions whose operand-size attribute is 64 bits when using REX.W.";
        }

        public readonly struct M : IAsmSigToken<M>
        {
            public K Kind => K.M;

            public string Symbol => "m";

            public string Description => "An operand in memory of width 16, 32 or 64 bits";
        }

        public readonly struct M8 : IAsmSigToken<M8>
        {
            public K Kind => K.M8;

            public string Symbol => "m8";

            public string Description => "An 8-bit operand in memory of width pointed to by a register that is operating-mode dependent";
        }

        public readonly struct M16 : IAsmSigToken<M16>
        {
            public K Kind => K.M16;

            public string Symbol => "m16";

            public string Description => "A 16-bit operand in memory pointed to by a register, and applicable only to string instructions";
        }

        public readonly struct M32 : IAsmSigToken<M32>
        {
            public K Kind => K.M32;

            public string Symbol => "m32";

            public string Description => "A 32-bit operand in memory pointed to by a register, and applicable only to string instructions";
        }

        public readonly struct M64: IAsmSigToken<M64>
        {
            public K Kind => K.M64;

            public string Symbol => "m64";

            public string Description => "A 64-bit operand in memory";
        }

        public readonly struct M128: IAsmSigToken<M128>
        {
            public K Kind => K.M128;

            public string Symbol => "m128";

            public string Description => "A 128-bit operand in memory";
        }

        public readonly struct M256: IAsmSigToken<M256>
        {
            public K Kind => K.M256;

            public string Symbol => "m256";

            public string Description => "A 256-bit operand in memory";
        }

        public readonly struct Rel8 : IAsmSigToken<Rel8>
        {
            public K Kind => K.Rel8;

            public string Symbol => "rel8";

            public string Description => "A relative address in the range from 128 bytes before the end of the instruction to 127 bytes after the end of the instruction";
        }

        public readonly struct Rel16 : IAsmSigToken<Rel16>
        {
            public K Kind => K.Rel16;

            public string Symbol => "rel16";

            public string Description => "A relative address within the same code segment as the instruction assembled and applicable to instructions with an operand-size attribute of 16 bits";
        }

        public readonly struct Rel32 : IAsmSigToken<Rel32>
        {
            public K Kind => K.Rel32;

            public string Symbol => "rel32";

            public string Description => "A relative address within the same code segment as the instruction assembled; applicable to instructions with an operand-size attribute of 32 bits";
        }

        public readonly struct Sreg : IAsmSigToken<Sreg>
        {
            public K Kind => K.Sreg;

            public string Symbol => "Sreg";

            public string Description => "A segment register, where the register bit assignments are ES = 0, CS = 1, SS = 2, DS = 3, FS = 4, and GS = 5";
        }


        public readonly struct Moffs8 : IAsmSigToken<Moffs8>
        {
            public K Kind => K.Moffs8;

            public string Symbol => "moffs8";

            public string Description => "";
        }

        public readonly struct Moffs16 : IAsmSigToken<Moffs16>
        {
            public K Kind => K.Moffs16;

            public string Symbol => "moffs16";

            public string Description => "";
        }

        public readonly struct Moffs32 : IAsmSigToken<Moffs32>
        {
            public K Kind => K.Moffs32;

            public string Symbol => "moffs32";

            public string Description => "";
        }

        public readonly struct Moffs64: IAsmSigToken<Moffs64>
        {
            public K Kind => K.Moffs64;

            public string Symbol => "moffs64";

            public string Description => "";
        }
    }
}