//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static core;

    using AsmId = llvm.AsmId;
    using static llvm.AsmId;

    public class AsmRunner
    {
        public static AsmRunner create()
            => new AsmRunner();

        bit Success;

        AsmRunner()
        {

        }

        public void Run(ReadOnlySpan<AsmInstruction> src)
        {
            var count = src.Length;
            for(var i=0; i<count; i++)
                Run(skip(src,i));
        }

        void and8i8(in AsmOperand op0, in AsmOperand op1)
        {

        }

        public void Run(in AsmInstruction src)
        {
            ref readonly var oc = ref src.OpCode;
            ref readonly var id = ref oc.AsmId;
            ref readonly var op0 = ref src.Op0;
            ref readonly var op0class = ref op0.OpClass;
            ref readonly var op0Size = ref op0.Size;
            ref readonly var op1 = ref src.Op1;
            ref readonly var op1class = ref op1.OpClass;
            ref readonly var op1Size = ref op1.Size;
            ref readonly var op2 = ref src.Op2;
            ref readonly var op2Size = ref op2.Size;
            ref readonly var op2class = ref op2.OpClass;
            ref readonly var op3 = ref src.Op3;
            ref readonly var op3class = ref op3.OpClass;
            ref readonly var op3Size = ref op3.Size;
            switch(id)
            {
                // (AND AL, imm8) = 24 ib
                case AND8i8:

                case AND8mi:
                case AND8mi8:
                case AND8mr:
                case AND8ri:
                case AND8ri8:
                case AND8rm:
                case AND8rr:
                case AND16i16:
                case AND16mi:
                case AND16mi8:
                case AND16mr:
                case AND16ri:
                case AND16ri8:
                case AND16rm:
                case AND16rr:
                case AND32i32:
                case AND32mi:
                case AND32mi8:
                case AND32mr:
                case AND32ri:
                case AND32ri8:
                case AND32rm:
                case AND32rr:
                case AND64i32:
                case AND64mi32:
                case AND64mi8:
                case AND64mr:
                case AND64ri32:
                case AND64ri8:
                case AND64rm:
                case AND64rr:
                break;
            }
        }

    }
}