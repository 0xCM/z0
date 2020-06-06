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
        
        readonly Span<InstructionExpression> Instructions;

        readonly Span<OpCodeExpression> OpCodes;

        readonly Span<MnemonicExpression> Mnemonics;

        readonly Span<CpuidExpression> Cpuid;

        readonly Span<OperatingMode> OperatingModes;

        readonly Span<int> MnemonicSeq;

        [MethodImpl(Inline)]
        OpCodeHandler(int count)
        {
            MnemonicSeq = new int[1];
            Instructions = new InstructionExpression[count];
            OpCodes = new OpCodeExpression[count];
            Mnemonics = new MnemonicExpression[count];
            Cpuid = new CpuidExpression[count];
            OperatingModes = new OperatingMode[count];
        }
        
        [MethodImpl(Inline), Op]
        public void Handle(int seq, in InstructionExpression src)
        {
            seek(Instructions, seq) = src;
        }

        [MethodImpl(Inline), Op]
        public void Handle(int seq, in OpCodeExpression src)
        {
            seek(OpCodes, seq) = src;
        }

        [MethodImpl(Inline), Op]
        void Include(in MnemonicExpression src)
            => seek(Mnemonics, head(MnemonicSeq)++) = src;

        ref readonly MnemonicExpression LastMnemonic
        {
            [MethodImpl(Inline)]
            get => ref skip(Mnemonics, head(MnemonicSeq) - 1);
        }
        
        [MethodImpl(Inline), Op]
        public void Handle(int seq, in MnemonicExpression src)
        {
            if(head(MnemonicSeq) > 0)
            {
                if(!LastMnemonic.Data.Equals(src.Data))
                    Include(src);
            }
            else
                Include(src);
        }

        [MethodImpl(Inline), Op]
        public void Handle(int seq, in CpuidExpression src)
        {
            seek(Cpuid, seq) = src;
        }

        [MethodImpl(Inline), Op]
        public void Handle(int seq, in OperatingMode src)
        {

            seek(OperatingModes,seq) = src;
        }

        public ReadOnlySpan<AsmCommandGroup> CommandGroups
            => Mnemonics.Slice(0, head(MnemonicSeq)).Map(group);

        public int ProcessedCount
        {
            [MethodImpl(Inline)]
            get => OpCodes.Length;
        }

        [MethodImpl(Inline), Op]
        public ref readonly MnemonicExpression Mnemonic(int seq)
            => ref skip(Mnemonics, seq);

        [MethodImpl(Inline), Op]
        public ref readonly OpCodeExpression OpCode(int seq)
            => ref skip(OpCodes, seq);

        [MethodImpl(Inline), Op]
        public ref readonly InstructionExpression Instruction(int seq)
            => ref skip(Instructions, seq);

        [MethodImpl(Inline), Op]
        static AsmCommandGroup group(MnemonicExpression expression)
            => new AsmCommandGroup(expression.Data);
    }
}