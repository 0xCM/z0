//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using F = AsmOpCodeField;

    /// <summary>
    /// Defines an operand in the context of an opcode expression
    /// </summary>
    public readonly struct AsmOpCodeOperand : IExpressional<AsmOpCodeOperand,ushort>
    {

        [Op]
        public static ref readonly DatasetFormatter<F> format(in AsmOpCodeRow src, in DatasetFormatter<F> dst)
        {
            dst.Delimit(F.Sequence, src.Sequence);
            dst.Delimit(F.Mnemonic, src.Mnemonic);
            dst.Delimit(F.OpCode, src.OpCode);
            dst.Delimit(F.Instruction, src.Instruction);
            dst.Delimit(F.M16, src.M16);
            dst.Delimit(F.M32, src.M32);
            dst.Delimit(F.M64, src.M64);
            dst.Delimit(F.CpuId, src.CpuId);
            dst.Delimit(F.CodeId, src.CodeId);
            return ref dst;
        }

        readonly ushort Source;

        [MethodImpl(Inline)]
        public AsmOpCodeOperand(ushort data)
            => Source = data;

        public ushort Body
        {
            [MethodImpl(Inline)]
            get => Source;
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Source == 0;
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => Source != 0;
        }

        public AsmOpCodeOperand Zero
        {
            [MethodImpl(Inline)]
            get => Empty;
        }

        [MethodImpl(Inline)]
        public bool Equals(AsmOpCodeOperand src)
            => Source == src.Source;

        public string Format()
            => Source.ToString();

        public override string ToString()
            => Format();

        public static AsmOpCodeOperand Empty
            => new AsmOpCodeOperand(0);
    }
}