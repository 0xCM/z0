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
    public struct OpCodePartitoner
    {
        [MethodImpl(Inline)]
        public static OpCodePartitoner Create(int seq = 0) 
            => new OpCodePartitoner(seq);

        int seq;

        [MethodImpl(Inline)]
        OpCodePartitoner(int seq)
        {
            this.seq = seq;
        }
        
        public int Sequence 
        {
            [MethodImpl(Inline)]
            get => seq;
        }

        [MethodImpl(Inline), Op]
        public void Partition(ReadOnlySpan<CommandInfo> src, in OpCodePartition handler)
        {
            for(var i=seq; i<src.Length; i++)
                Partition(skip(src,i), handler);
        }

        [MethodImpl(Inline), Op]
        public void Partition(in CommandInfo src, in OpCodePartition handler)
        {
            Process(src, handler);
            seq++;
        }

        [MethodImpl(Inline)]
        void Process(in CommandInfo src, in OpCodePartition handler)
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
        static MnemonicExpression Mnemonic(in CommandInfo src)
            => new MnemonicExpression(src.Mnemonic);

        [MethodImpl(Inline)]
        static CpuidExpression Cpuid(in CommandInfo src)
            => new CpuidExpression(src.CpuId);

        [MethodImpl(Inline)]
        static OpCodeExpression OpCode(in CommandInfo src)
            => new OpCodeExpression(src.OpCode);

        [MethodImpl(Inline)]
        static InstructionExpression Instruction(in CommandInfo src)
            => new InstructionExpression(src.InstructionCode);
    }
}