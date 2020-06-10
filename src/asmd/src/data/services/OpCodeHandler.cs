//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static Memories;

    [ApiHost]
    public readonly ref struct OpCodeHandler  
    {
        [MethodImpl(Inline), Op]
        public static OpCodeHandler Create(int count)
            => new OpCodeHandler(count);
        
        readonly Span<InstructionExpression> instructions;

        readonly Span<OpCodeExpression> codes;

        readonly Span<MnemonicExpression> mnemonics;

        readonly Span<CpuidExpression> cpuid;

        readonly Span<OperatingMode> modes;

        readonly Span<int> MnemonicSeq;

        [MethodImpl(Inline)]
        OpCodeHandler(int count)
        {
            MnemonicSeq = new int[1];
            instructions = new InstructionExpression[count];
            codes = new OpCodeExpression[count];
            mnemonics = new MnemonicExpression[count];
            cpuid = new CpuidExpression[count];
            modes = new OperatingMode[count];
        }
        
        [MethodImpl(Inline), Op]
        public void Handle(in OpCodeProcessor ocp, in InstructionExpression src)
        {
            seek(instructions, ocp.Sequence) = src;
        }

        [MethodImpl(Inline), Op]
        public void Handle(in OpCodeProcessor ocp, in OpCodeExpression src)
        {
            seek(codes, ocp.Sequence) = src;
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
        public void Handle(OpCodeProcessor ocp, in MnemonicExpression src)
        {
            if(head(MnemonicSeq) > 0)
            {
                if(!LastMnemonic.Body.Equals(src.Body))
                    Include(src);
            }
            else
                Include(src);
        }

        [MethodImpl(Inline), Op]
        public void Handle(in OpCodeProcessor ocp, in CpuidExpression src)
        {
            seek(cpuid, ocp.Sequence) = src;
        }

        [MethodImpl(Inline), Op]
        public void Handle(OpCodeProcessor ocp, in OperatingMode src)
        {

            seek(modes,ocp.Sequence) = src;
        }

        public ReadOnlySpan<AsmCommandGroup> CommandGroups
            => mnemonics.Slice(0, head(MnemonicSeq)).Map(group);

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
        public ref readonly MnemonicExpression Mnemonic(int seq)
            => ref skip(mnemonics, seq);

        [MethodImpl(Inline), Op]
        public ref readonly OpCodeExpression OpCode(int seq)
            => ref skip(codes, seq);

        [MethodImpl(Inline), Op]
        public ref readonly InstructionExpression Instruction(int seq)
            => ref skip(instructions, seq);

        [MethodImpl(Inline), Op]
        static AsmCommandGroup group(MnemonicExpression expression)
            => new AsmCommandGroup(expression.Body);
    }
}