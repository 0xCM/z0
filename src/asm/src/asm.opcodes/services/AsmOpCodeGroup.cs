//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static z;

    public readonly ref struct AsmOpCodeGroup
    {
        readonly Span<AsmSigExpr> SigData;

        readonly Span<AsmOpCodeExpr> OpCodeData;

        readonly Span<AsmMnemonicExpr> MnemonicData;

        readonly Span<Cpuid> CpuidData;

        readonly Span<OperatingMode> ModeData;

        readonly Span<uint> MnemonicSeq;

        [MethodImpl(Inline)]
        internal AsmOpCodeGroup(uint count)
        {
            MnemonicSeq = new uint[1];
            SigData = new AsmSigExpr[count];
            OpCodeData = new AsmOpCodeExpr[count];
            MnemonicData = new AsmMnemonicExpr[count];
            CpuidData = new Cpuid[count];
            ModeData = new OperatingMode[count];
        }

        [MethodImpl(Inline), Op]
        public void Include(uint seq, in AsmSigExpr src)
            => Sig(seq) = src;

        [MethodImpl(Inline), Op]
        public void Include(uint seq, in AsmOpCodeExpr src)
            => OpCode(seq) = src;

        [MethodImpl(Inline), Op]
        public void Include(uint seq, in Cpuid src)
            => seek(CpuidData, seq) = src;

        [MethodImpl(Inline), Op]
        public void Include(uint seq, in OperatingMode src)
            => Mode(seq) = src;

        [MethodImpl(Inline), Op]
        public void Include(in AsmOpCodePartitoner ocp, in AsmSigExpr src)
            => Sig((uint)ocp.Sequence) = src;

        [MethodImpl(Inline), Op]
        public void Include(in AsmOpCodePartitoner ocp, in AsmOpCodeExpr src)
            => OpCode((uint)ocp.Sequence) = src;

        [MethodImpl(Inline), Op]
        void Include(in AsmMnemonicExpr src)
            => seek(MnemonicData, first(MnemonicSeq)++) = src;

        ref readonly AsmMnemonicExpr LastMnemonic
        {
            [MethodImpl(Inline)]
            get => ref skip(MnemonicData, first(MnemonicSeq) - 1);
        }

        [MethodImpl(Inline), Op]
        public void Include(AsmOpCodePartitoner ocp, in AsmMnemonicExpr src)
        {
            if(first(MnemonicSeq) > 0)
                if(!LastMnemonic.Content.Equals(src.Content))
                    Include(src);
            else
                Include(src);
        }

        [MethodImpl(Inline), Op]
        public void Include(uint seq, in AsmMnemonicExpr src)
        {
            if(first(MnemonicSeq) > 0)
                if(!LastMnemonic.Content.Equals(src.Content))
                    Include(src);
            else
                Include(src);
        }

        [MethodImpl(Inline), Op]
        public void Include(in AsmOpCodePartitoner ocp, in Cpuid src)
            => seek(CpuidData, (uint)ocp.Sequence) = src;

        [MethodImpl(Inline), Op]
        public void Include(AsmOpCodePartitoner ocp, in OperatingMode src)
            => Mode((uint)ocp.Sequence) = src;

        public uint ProcessedCount
        {
            [MethodImpl(Inline)]
            get => (uint)OpCodeData.Length;
        }

        public ReadOnlySpan<AsmSigExpr> Signatures
        {
            [MethodImpl(Inline)]
            get => SigData;
        }

        public ReadOnlySpan<AsmOpCodeExpr> OpCodes
        {
            [MethodImpl(Inline)]
            get => OpCodeData;
        }

        public ReadOnlySpan<Cpuid> CpuId
        {
            [MethodImpl(Inline)]
            get => CpuidData;
        }

        public ReadOnlySpan<AsmMnemonicExpr> Mnemonics
        {
            [MethodImpl(Inline)]
            get => MnemonicData;
        }

        public ReadOnlySpan<OperatingMode> Modes
        {
            [MethodImpl(Inline)]
            get => ModeData;
        }

        [MethodImpl(Inline), Op]
        ref AsmMnemonicExpr Mnemonic(uint seq)
            => ref seek(MnemonicData, seq);

        [MethodImpl(Inline), Op]
        ref AsmOpCodeExpr OpCode(uint seq)
            => ref seek(OpCodeData, seq);

        [MethodImpl(Inline), Op]
        ref OperatingMode Mode(uint seq)
            => ref seek(ModeData, seq);

        [MethodImpl(Inline), Op]
        ref AsmSigExpr Sig(uint seq)
            => ref seek(SigData, seq);
    }
}