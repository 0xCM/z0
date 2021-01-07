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
        readonly Span<AsmSig> SigData;

        readonly Span<AsmOpCode> OpCodeData;

        readonly Span<MnemonicExpression> MnemonicData;

        readonly Span<CpuidExpression> CpuidData;

        readonly Span<OperatingMode> ModeData;

        readonly Span<uint> MnemonicSeq;

        [MethodImpl(Inline)]
        internal AsmOpCodeGroup(uint count)
        {
            MnemonicSeq = new uint[1];
            SigData = new AsmSig[count];
            OpCodeData = new AsmOpCode[count];
            MnemonicData = new MnemonicExpression[count];
            CpuidData = new CpuidExpression[count];
            ModeData = new OperatingMode[count];
        }

        [MethodImpl(Inline), Op]
        public void Include(uint seq, in AsmSig src)
            => Sig(seq) = src;

        [MethodImpl(Inline), Op]
        public void Include(uint seq, in AsmOpCode src)
            => OpCode(seq) = src;

        [MethodImpl(Inline), Op]
        public void Include(uint seq, in CpuidExpression src)
            => seek(CpuidData, seq) = src;

        [MethodImpl(Inline), Op]
        public void Include(uint seq, in OperatingMode src)
            => Mode(seq) = src;

        [MethodImpl(Inline), Op]
        public void Include(in AsmOpCodePartitoner ocp, in AsmSig src)
            => Sig((uint)ocp.Sequence) = src;

        [MethodImpl(Inline), Op]
        public void Include(in AsmOpCodePartitoner ocp, in AsmOpCode src)
            => OpCode((uint)ocp.Sequence) = src;

        [MethodImpl(Inline), Op]
        void Include(in MnemonicExpression src)
            => seek(MnemonicData, first(MnemonicSeq)++) = src;

        ref readonly MnemonicExpression LastMnemonic
        {
            [MethodImpl(Inline)]
            get => ref skip(MnemonicData, first(MnemonicSeq) - 1);
        }

        [MethodImpl(Inline), Op]
        public void Include(AsmOpCodePartitoner ocp, in MnemonicExpression src)
        {
            if(first(MnemonicSeq) > 0)
                if(!LastMnemonic.Value.Equals(src.Value))
                    Include(src);
            else
                Include(src);
        }

        [MethodImpl(Inline), Op]
        public void Include(uint seq, in MnemonicExpression src)
        {
            if(first(MnemonicSeq) > 0)
                if(!LastMnemonic.Value.Equals(src.Value))
                    Include(src);
            else
                Include(src);
        }

        [MethodImpl(Inline), Op]
        public void Include(in AsmOpCodePartitoner ocp, in CpuidExpression src)
            => seek(CpuidData, (uint)ocp.Sequence) = src;

        [MethodImpl(Inline), Op]
        public void Include(AsmOpCodePartitoner ocp, in OperatingMode src)
            => Mode((uint)ocp.Sequence) = src;

        public uint ProcessedCount
        {
            [MethodImpl(Inline)]
            get => (uint)OpCodeData.Length;
        }

        public ReadOnlySpan<AsmSig> Signatures
        {
            [MethodImpl(Inline)]
            get => SigData;
        }

        public ReadOnlySpan<AsmOpCode> OpCodes
        {
            [MethodImpl(Inline)]
            get => OpCodeData;
        }

        public ReadOnlySpan<CpuidExpression> CpuId
        {
            [MethodImpl(Inline)]
            get => CpuidData;
        }

        public ReadOnlySpan<MnemonicExpression> Mnemonics
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
        ref MnemonicExpression Mnemonic(uint seq)
            => ref seek(MnemonicData, seq);

        [MethodImpl(Inline), Op]
        ref AsmOpCode OpCode(uint seq)
            => ref seek(OpCodeData, seq);

        [MethodImpl(Inline), Op]
        ref OperatingMode Mode(uint seq)
            => ref seek(ModeData, seq);

        [MethodImpl(Inline), Op]
        ref AsmSig Sig(uint seq)
            => ref seek(SigData, seq);
    }
}