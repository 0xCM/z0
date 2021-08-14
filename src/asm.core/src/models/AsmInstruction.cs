//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Root;

    [StructLayout(LayoutKind.Sequential, Pack=1, Size =(int)SZ), Blittable(SZ)]
    public struct AsmInstruction
    {
        public const uint SZ = AsmOpCode.SZ + 4*AsmOperand.SZ;

        public AsmOpCode OpCode;

        public AsmOperand Op0;

        public AsmOperand Op1;

        public AsmOperand Op2;

        public AsmOperand Op3;
    }
}