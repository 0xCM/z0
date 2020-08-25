//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using Z0.Tokens;

    using static Konst;
    using static z;
    using api = AsmOpCodes;

    public struct AsmOpCodePartitoner
    {
        int S0;

        [MethodImpl(Inline)]
        public AsmOpCodePartitoner(int seq)
            => S0 = seq;

        public int Sequence
        {
            [MethodImpl(Inline)]
            get => S0;
        }

        [MethodImpl(Inline), Op]
        public void Partition(ReadOnlySpan<AsmOpCodeTable> src, in AsmOpCodeGroup handler)
        {
            for(var i=S0; i<src.Length; i++)
                Partition(skip(src,i), handler);
        }

        [MethodImpl(Inline), Op]
        public void Partition(in AsmOpCodeTable src, in AsmOpCodeGroup handler)
        {
            Process(src, handler);
            S0++;
        }

        [MethodImpl(Inline), Op]
        void Process(in AsmOpCodeTable src, in AsmOpCodeGroup handler)
        {
            Process(OpCode(src), handler);
            Process(Instruction(src), handler);
            Process(Mnemonic(src), handler);
            Process(Cpuid(src), handler);
        }

        [MethodImpl(Inline), Op]
        void Process(OperatingMode src, in AsmOpCodeGroup handler)
        {
            handler.Include(this, src);
        }

        [MethodImpl(Inline), Op]
        void Process(in AsmFxPattern src, in AsmOpCodeGroup handler)
        {
            handler.Include(this, src);
        }

        [MethodImpl(Inline), Op]
        void Process(in AsmOpCode src, in AsmOpCodeGroup handler)
        {
            handler.Include(this, src);
        }

        [MethodImpl(Inline), Op]
        void Process(in MnemonicExpression src, in AsmOpCodeGroup handler)
        {
            handler.Include(this, src);
        }

        [MethodImpl(Inline), Op]
        void Process(in CpuidExpression src, in AsmOpCodeGroup handler)
        {
            handler.Include(this, src);
        }

        [MethodImpl(Inline), Op]
        static MnemonicExpression Mnemonic(in AsmOpCodeTable src)
            => new MnemonicExpression(src.Mnemonic);

        [MethodImpl(Inline), Op]
        static CpuidExpression Cpuid(in AsmOpCodeTable src)
            => new CpuidExpression(src.CpuId);

        [MethodImpl(Inline), Op]
        static AsmOpCode OpCode(in AsmOpCodeTable src)
            => new AsmOpCode(src.OpCode);

        [MethodImpl(Inline), Op]
        static AsmFxPattern Instruction(in AsmOpCodeTable src)
            => new AsmFxPattern(src.Instruction);
    }
}