//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Konst;
    using static z;

    public readonly struct EncodedInstruction
    {
        readonly Vector128<byte> Storage;

        [MethodImpl(Inline)]
        internal EncodedInstruction(Vector128<byte> src)
        {
            Storage = src;
        }
    }

    public readonly struct AsmStatementCode : ITextual
    {
        public readonly asci64 Asm;

        [MethodImpl(Inline)]
        public static implicit operator AsmStatementCode(string src)
            => new AsmStatementCode(src);

        [MethodImpl(Inline)]
        public AsmStatementCode(in asci64 asm)
            => Asm = asm;

        [MethodImpl(Inline)]
        public string Format()
            => Asm.Format();
    }

    public readonly struct InstructionDetail : ITextual
    {
        readonly Vector256<byte> Data;

        [MethodImpl(Inline)]
        internal InstructionDetail(Vector256<byte> src)
        {
            Data = src;
        }

        public MemoryAddress NextRip
        {
            [MethodImpl(Inline)]
            get => vcell(v64u(vlo(Data)),0);
        }

        [MethodImpl(Inline)]
        public byte Register(N0 n)
            => vcell(Data,0);

        [MethodImpl(Inline)]
        public byte Register(N1 n)
            => vcell(Data,1);

        [MethodImpl(Inline)]
        public byte Register(N2 n)
            => vcell(Data,2);

        [MethodImpl(Inline)]
        public byte Register(N3 n)
            => vcell(Data,3);

        [MethodImpl(Inline)]
        public byte Register(byte index)
            => vcell(Data,index);

        public byte BaseRegister
        {
            get => vcell(Data,0);
        }

        [MethodImpl(Inline)]
        public string Format()
            => Data.FormatAsmHex();
    }

    public readonly struct AsmInstructionDetails
    {
        readonly TableSpan<InstructionDetail> Data;

        [MethodImpl(Inline)]
        public static implicit operator AsmInstructionDetails(InstructionDetail[] src)
            => new AsmInstructionDetails(src);

        [MethodImpl(Inline)]
        public AsmInstructionDetails(InstructionDetail[] src)
        {
            Data = src;
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Data.IsEmpty;
        }
    }

    public readonly struct AsmInstructionCode : ITextual
    {
        public readonly InstructionDetail Instruction;

        public readonly AsmStatementCode SourceCode;

        [MethodImpl(Inline)]
        public AsmInstructionCode(in InstructionDetail detail, in AsmStatementCode asm)
        {
            Instruction = detail;
            SourceCode = asm;
        }

        [MethodImpl(Inline)]
        public static implicit operator AsmInstructionCode(Paired<InstructionDetail,AsmStatementCode> src)
            => new AsmInstructionCode(src.Left, src.Right);

        public string Format()
            => Render.format(SourceCode, Instruction);
    }
}