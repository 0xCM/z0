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
        public void Partition(ReadOnlySpan<AsmOpCodeRowLegacy> src, in AsmOpCodeGroup handler)
        {
            for(var i=S0; i<src.Length; i++)
                Partition(skip(src,i), handler);
        }

        [MethodImpl(Inline), Op]
        public void Partition(in AsmOpCodeRowLegacy src, in AsmOpCodeGroup handler)
        {
            Process(src, handler);
            S0++;
        }

        [MethodImpl(Inline), Op]
        void Process(in AsmOpCodeRowLegacy src, in AsmOpCodeGroup handler)
        {
            Process(OpCode(src), handler);
            Process(Instruction(src), handler);
            Process(Mnemonic(src), handler);
            Process(Cpuid(src), handler);
        }

        [MethodImpl(Inline), Op]
        void Process(OperatingMode src, in AsmOpCodeGroup handler)
            => handler.Include(this, src);

        [MethodImpl(Inline), Op]
        void Process(in AsmSigExpr src, in AsmOpCodeGroup handler)
            => handler.Include(this, src);

        [MethodImpl(Inline), Op]
        void Process(in AsmOpCodeExprLegacy src, in AsmOpCodeGroup handler)
            => handler.Include(this, src);

        [MethodImpl(Inline), Op]
        void Process(in AsmMnemonicExpr src, in AsmOpCodeGroup handler)
            => handler.Include(this, src);

        [MethodImpl(Inline), Op]
        void Process(in Cpuid src, in AsmOpCodeGroup handler)
            => handler.Include(this, src);

        [MethodImpl(Inline), Op]
        static AsmMnemonicExpr Mnemonic(in AsmOpCodeRowLegacy src)
            => new AsmMnemonicExpr(src.Mnemonic);

        [MethodImpl(Inline), Op]
        static Cpuid Cpuid(in AsmOpCodeRowLegacy src)
            => new Cpuid(src.CpuId);

        [MethodImpl(Inline), Op]
        static AsmOpCodeExprLegacy OpCode(in AsmOpCodeRowLegacy src)
            => new AsmOpCodeExprLegacy(src.OpCode);

        [MethodImpl(Inline), Op]
        static AsmSigExpr Instruction(in AsmOpCodeRowLegacy src)
            => new AsmSigExpr(src.Instruction);
    }
}