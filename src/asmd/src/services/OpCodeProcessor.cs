//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;
    using System.Collections.Generic;

    using static Seed;
    using static Memories;


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
        public void Process(ReadOnlySpan<OpCodeRecord> src, in OpCodeHandler handler)
        {
            for(var i=seq; i<src.Length; i++)
                Next(skip(src,i), handler);
        }

        [MethodImpl(Inline), Op]
        public void Next(in OpCodeRecord src, in OpCodeHandler handler)
        {
            Process(src, handler);
            seq++;
        }

        [MethodImpl(Inline)]
        void Process(in OpCodeRecord src, in OpCodeHandler handler)
        {
            Process(OpCode(src),handler);
            Process(Instruction(src),handler);
            Process(Mnemonic(src),handler);
            Process(src.M16, src.M32, src.M64,handler);
            Process(Cpuid(src),handler);
        }


        [MethodImpl(Inline), Op]
        void Process(OperatingMode src, in OpCodeHandler handler)
        {
            handler.Handle(seq, src);        
        }

        [MethodImpl(Inline), Op]
        void Process(YeaOrNea m16, YeaOrNea m32, YeaOrNea m64, in OpCodeHandler handler)
        {
            const OperatingMode none = OperatingMode.None;
            var mode = none;
            mode |= (m16 == YeaOrNea.Y ? OperatingMode.Mode16 : none);
            mode |= (m32 == YeaOrNea.Y ? OperatingMode.Mode32 : none);
            mode |= (m64 == YeaOrNea.Y ? OperatingMode.Mode64 : none);
            Process(mode,handler);
        }

        [MethodImpl(Inline), Op]
        void Process(in InstructionExpression src, in OpCodeHandler handler)
        {
            handler.Handle(seq, src);
        }

        [MethodImpl(Inline), Op]
        void Process(in OpCodeExpression src, in OpCodeHandler handler)
        {
            handler.Handle(seq, src);            
        }

        [MethodImpl(Inline), Op]
        void Process(in MnemonicExpression src, in OpCodeHandler handler)
        {
            handler.Handle(seq, src);            
        }

        [MethodImpl(Inline), Op]
        void Process(in CpuidExpression src, in OpCodeHandler handler)
        {
            handler.Handle(seq, src);            
        }

        [MethodImpl(Inline)]
        static MnemonicExpression Mnemonic(in OpCodeRecord src)
            => new MnemonicExpression(src.Mnemonic);

        [MethodImpl(Inline)]
        static CpuidExpression Cpuid(in OpCodeRecord src)
            => new CpuidExpression(src.CpuId);

        [MethodImpl(Inline)]
        static OpCodeExpression OpCode(in OpCodeRecord src)
            => new OpCodeExpression(src.Expression);

        [MethodImpl(Inline)]
        static InstructionExpression Instruction(in OpCodeRecord src)
            => new InstructionExpression(src.Instruction);
    }
}