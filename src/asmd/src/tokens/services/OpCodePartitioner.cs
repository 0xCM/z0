//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
    using System;
    using System.Runtime.CompilerServices;

    using Z0.Tokens;

    using static Konst;
    using static Root;

    [ApiHost]
    public struct OpCodePartitoner
    {
        [MethodImpl(Inline)]
        public static OpCodePartitoner Create(int seq = 0) 
            => new OpCodePartitoner(seq);

        int S0;

        [MethodImpl(Inline)]
        internal OpCodePartitoner(int seq)
        {
            S0 = seq;
        }
        
        public int Sequence 
        {
            [MethodImpl(Inline)]
            get => S0;
        }

        [MethodImpl(Inline), Op]
        public void Partition(ReadOnlySpan<OpCodeRecord> src, in OpCodePartition handler)
        {
            for(var i=S0; i<src.Length; i++)
                Partition(skip(src,i), handler);
        }

        [MethodImpl(Inline), Op]
        public void Partition(in OpCodeRecord src, in OpCodePartition handler)
        {
            Process(src, handler);
            S0++;
        }

        [MethodImpl(Inline)]
        void Process(in OpCodeRecord src, in OpCodePartition handler)
        {
            Process(OpCode(src), handler);
            Process(Instruction(src), handler);
            Process(Mnemonic(src), handler);
            Process(Cpuid(src), handler);
        }

        [MethodImpl(Inline), Op]
        void Process(OperatingMode src, in OpCodePartition handler)
        {
            handler.Include(this, src);        
        }

        [MethodImpl(Inline), Op]
        void Process(in InstructionExpression src, in OpCodePartition handler)
        {
            handler.Include(this, src);
        }

        [MethodImpl(Inline), Op]
        void Process(in OpCodeExpression src, in OpCodePartition handler)
        {
            handler.Include(this, src);            
        }

        [MethodImpl(Inline), Op]
        void Process(in MnemonicExpression src, in OpCodePartition handler)
        {
            handler.Include(this, src);            
        }

        [MethodImpl(Inline), Op]
        void Process(in CpuidExpression src, in OpCodePartition handler)
        {
            handler.Include(this, src);            
        }

        [MethodImpl(Inline)]
        static MnemonicExpression Mnemonic(in OpCodeRecord src)
            => new MnemonicExpression(src.Mnemonic);

        [MethodImpl(Inline)]
        static CpuidExpression Cpuid(in OpCodeRecord src)
            => new CpuidExpression(src.CpuId);

        [MethodImpl(Inline)]
        static OpCodeExpression OpCode(in OpCodeRecord src)
            => new OpCodeExpression(src.OpCode);

        [MethodImpl(Inline)]
        static InstructionExpression Instruction(in OpCodeRecord src)
            => new InstructionExpression(src.Instruction);
    }
}