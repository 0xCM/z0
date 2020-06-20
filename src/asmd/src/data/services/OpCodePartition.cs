//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Root;

    [ApiHost]
    public readonly ref struct OpCodePartition  
    {
        [MethodImpl(Inline), Op]
        public static OpCodePartition Create(int count)
            => new OpCodePartition(count);
        
        readonly Span<InstructionExpression> instructions;

        readonly Span<OpCodeExpression> codes;

        readonly Span<MnemonicExpression> mnemonics;

        readonly Span<CpuidExpression> cpuid;

        readonly Span<OperatingMode> modes;

        readonly Span<int> MnemonicSeq;

        [MethodImpl(Inline)]
        OpCodePartition(int count)
        {
            MnemonicSeq = new int[1];
            instructions = new InstructionExpression[count];
            codes = new OpCodeExpression[count];
            mnemonics = new MnemonicExpression[count];
            cpuid = new CpuidExpression[count];
            modes = new OperatingMode[count];
        }
        
        [MethodImpl(Inline), Op]
        public void Include(in OpCodePartitoner ocp, in InstructionExpression src)
        {
            Instruction(ocp.Sequence) = src;
        }

        [MethodImpl(Inline), Op]
        public void Include(in OpCodePartitoner ocp, in OpCodeExpression src)
        {
            OpCode(ocp.Sequence) = src;
        }

        [MethodImpl(Inline), Op]
        void Include(in MnemonicExpression src)
            => seek(mnemonics, head(MnemonicSeq)++) = src;

        ref readonly MnemonicExpression LastMnemonic
        {
            [MethodImpl(Inline)]
            get => ref skip(mnemonics, head(MnemonicSeq) - 1);
        }
        
        [MethodImpl(Inline), Op]
        public void Include(OpCodePartitoner ocp, in MnemonicExpression src)
        {
            if(head(MnemonicSeq) > 0)
            {
                if(!LastMnemonic.Value.Equals(src.Value))
                    Include(src);
            }
            else
                Include(src);
        }

        [MethodImpl(Inline), Op]
        public void Include(in OpCodePartitoner ocp, in CpuidExpression src)
        {
            seek(cpuid, ocp.Sequence) = src;
        }

        [MethodImpl(Inline), Op]
        public void Include(OpCodePartitoner ocp, in OperatingMode src)
        {

            Mode(ocp.Sequence) = src;
        }

        public int ProcessedCount
        {
            [MethodImpl(Inline)]
            get => codes.Length;
        }

        public ReadOnlySpan<InstructionExpression> Instructions
        {
            [MethodImpl(Inline)]
            get => instructions;
        }

        public ReadOnlySpan<OpCodeExpression> OpCodes
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
        ref MnemonicExpression Mnemonic(int seq)
            => ref seek(mnemonics, seq);

        [MethodImpl(Inline), Op]
        ref OpCodeExpression OpCode(int seq)
            => ref seek(codes, seq);

        [MethodImpl(Inline), Op]
        ref OperatingMode Mode(int seq)
            => ref seek(modes, seq);

        [MethodImpl(Inline), Op]
        ref InstructionExpression Instruction(int seq)
            => ref seek(instructions, seq);

        [MethodImpl(Inline), Op]
        static AsmCommandGroup group(MnemonicExpression expression)
            => new AsmCommandGroup(expression.Value);
    }
}