//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    public readonly ref struct AsmOpCodeGroup
    {
        [MethodImpl(Inline), Op]
        public static AsmOpCodeGroup Create(int count)
            => new AsmOpCodeGroup((uint)count);

        readonly Span<AsmInstructionPattern> instructions;

        readonly Span<AsmOpCodeExpression> codes;

        readonly Span<MnemonicExpression> mnemonics;

        readonly Span<CpuidExpression> cpuid;

        readonly Span<OperatingMode> modes;

        readonly Span<uint> MnemonicSeq;

        [MethodImpl(Inline)]
        internal AsmOpCodeGroup(uint count)
        {
            MnemonicSeq = new uint[1];
            instructions = new AsmInstructionPattern[count];
            codes = new AsmOpCodeExpression[count];
            mnemonics = new MnemonicExpression[count];
            cpuid = new CpuidExpression[count];
            modes = new OperatingMode[count];
        }

        [MethodImpl(Inline), Op]
        public void Include(uint seq, in AsmInstructionPattern src)
        {
            Instruction(seq) = src;
        }

        [MethodImpl(Inline), Op]
        public void Include(uint seq, in AsmOpCodeExpression src)
        {
            OpCode(seq) = src;
        }

        [MethodImpl(Inline), Op]
        public void Include(uint seq, in CpuidExpression src)
        {
            seek(cpuid, seq) = src;
        }

        [MethodImpl(Inline), Op]
        public void Include(uint seq, in OperatingMode src)
        {

            Mode(seq) = src;
        }

        [MethodImpl(Inline), Op]
        public void Include(in AsmOpCodePartitoner ocp, in AsmInstructionPattern src)
        {
            Instruction((uint)ocp.Sequence) = src;
        }

        [MethodImpl(Inline), Op]
        public void Include(in AsmOpCodePartitoner ocp, in AsmOpCodeExpression src)
        {
            OpCode((uint)ocp.Sequence) = src;
        }

        [MethodImpl(Inline), Op]
        void Include(in MnemonicExpression src)
            => z.seek(mnemonics, first(MnemonicSeq)++) = src;

        ref readonly MnemonicExpression LastMnemonic
        {
            [MethodImpl(Inline)]
            get => ref skip(mnemonics, first(MnemonicSeq) - 1);
        }

        [MethodImpl(Inline), Op]
        public void Include(AsmOpCodePartitoner ocp, in MnemonicExpression src)
        {
            if(first(MnemonicSeq) > 0)
            {
                if(!LastMnemonic.Value.Equals(src.Value))
                    Include(src);
            }
            else
                Include(src);
        }

        [MethodImpl(Inline), Op]
        public void Include(uint seq, in MnemonicExpression src)
        {
            if(first(MnemonicSeq) > 0)
            {
                if(!LastMnemonic.Value.Equals(src.Value))
                    Include(src);
            }
            else
                Include(src);
        }

        [MethodImpl(Inline), Op]
        public void Include(in AsmOpCodePartitoner ocp, in CpuidExpression src)
        {
            seek(cpuid, (uint)ocp.Sequence) = src;
        }

        [MethodImpl(Inline), Op]
        public void Include(AsmOpCodePartitoner ocp, in OperatingMode src)
        {

            Mode((uint)ocp.Sequence) = src;
        }

        public int ProcessedCount
        {
            [MethodImpl(Inline)]
            get => codes.Length;
        }

        public ReadOnlySpan<AsmInstructionPattern> Instructions
        {
            [MethodImpl(Inline)]
            get => instructions;
        }

        public ReadOnlySpan<AsmOpCodeExpression> OpCodes
        {
            [MethodImpl(Inline)]
            get => codes;
        }

        public ReadOnlySpan<CpuidExpression> CpuId
        {
            [MethodImpl(Inline)]
            get => cpuid;
        }

        public ReadOnlySpan<MnemonicExpression> Mnemonics
        {
            [MethodImpl(Inline)]
            get => mnemonics;
        }

        public ReadOnlySpan<OperatingMode> Modes
        {
            [MethodImpl(Inline)]
            get => modes;
        }

        [MethodImpl(Inline), Op]
        ref MnemonicExpression Mnemonic(uint seq)
            => ref seek(mnemonics, seq);

        [MethodImpl(Inline), Op]
        ref AsmOpCodeExpression OpCode(uint seq)
            => ref seek(codes, seq);

        [MethodImpl(Inline), Op]
        ref OperatingMode Mode(uint seq)
            => ref seek(modes, seq);

        [MethodImpl(Inline), Op]
        ref AsmInstructionPattern Instruction(uint seq)
            => ref seek(instructions, seq);

        // [MethodImpl(Inline), Op]
        // static AsmFxGroup group(MnemonicExpression expression)
        //     => new AsmFxGroup(expression.Value);
    }
}