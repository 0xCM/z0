//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Control;

    [ApiHost]
    public struct OpCodeProcessor
    {
        [MethodImpl(Inline)]
        public static OpCodeProcessor Create(int seq = 0) 
            => new OpCodeProcessor(seq);

        int seq;

        [MethodImpl(Inline)]
        OpCodeProcessor(int seq)
        {
            this.seq = seq;
        }
        
        public int Sequence 
        {
            [MethodImpl(Inline)]
            get => seq;
        }

        [MethodImpl(Inline), Op]
        public void Process(ReadOnlySpan<CommandInfo> src, in OpCodeHandler handler)
        {
            for(var i=seq; i<src.Length; i++)
                Next(skip(src,i), handler);
        }

        [MethodImpl(Inline), Op]
        public void Next(in CommandInfo src, in OpCodeHandler handler)
        {
            Process(src, handler);
            seq++;
        }

        [MethodImpl(Inline)]
        void Process(in CommandInfo src, in OpCodeHandler handler)
        {
            Process(OpCode(src),handler);
            Process(Instruction(src),handler);
            Process(Mnemonic(src),handler);
            Process(Cpuid(src),handler);
        }


        [MethodImpl(Inline), Op]
        void Process(OperatingMode src, in OpCodeHandler handler)
        {
            handler.Handle(this, src);        
        }

        [MethodImpl(Inline), Op]
        void Process(in InstructionExpression src, in OpCodeHandler handler)
        {
            handler.Handle(this, src);
        }

        [MethodImpl(Inline), Op]
        void Process(in OpCodeExpression src, in OpCodeHandler handler)
        {
            handler.Handle(this, src);            
        }

        [MethodImpl(Inline), Op]
        void Process(in MnemonicExpression src, in OpCodeHandler handler)
        {
            handler.Handle(this, src);            
        }

        [MethodImpl(Inline), Op]
        void Process(in CpuidExpression src, in OpCodeHandler handler)
        {
            handler.Handle(this, src);            
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