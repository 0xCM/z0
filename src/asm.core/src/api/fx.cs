//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    partial struct asm
    {
        [MethodImpl(Inline), Op]
        public static AsmInstruction fx(AsmId id)
        {
            var dst =  new AsmInstruction();
            dst.Id = id;
            return dst;
        }

        [MethodImpl(Inline), Op]
        public static AsmInstruction fx(AsmId id, AsmOperand op0)
        {
            var dst =  new AsmInstruction();
            dst.Id = id;
            dst.Op0 = op0;
            return dst;
        }

        [MethodImpl(Inline), Op]
        public static AsmInstruction fx(AsmId id, AsmOperand op0, AsmOperand op1)
        {
            var dst =  new AsmInstruction();
            dst.Id = id;
            dst.Op0 = op0;
            dst.Op1 = op1;
            return dst;
        }

        [MethodImpl(Inline), Op]
        public static AsmInstruction fx(AsmId id, AsmOperand op0, AsmOperand op1, AsmOperand op2)
        {
            var dst =  new AsmInstruction();
            dst.Id = id;
            dst.Op0 = op0;
            dst.Op1 = op1;
            dst.Op2 = op2;
            return dst;
        }

        [MethodImpl(Inline), Op]
        public static AsmInstruction fx(AsmId id, AsmOperand op0, AsmOperand op1, AsmOperand op2, AsmOperand op3)
        {
            var dst =  new AsmInstruction();
            dst.Id = id;
            dst.Op0 = op0;
            dst.Op1 = op1;
            dst.Op2 = op2;
            dst.Op3 = op3;
            return dst;
        }
    }
}