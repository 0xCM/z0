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

    [StructLayout(LayoutKind.Sequential, Pack=1)]
    public struct AsmInstruction
    {
        public AsmId OpCode;

        public AsmOperand Op0;

        public AsmOperand Op1;

        public AsmOperand Op2;

        public AsmOperand Op3;

        public byte OpCount
        {
            [MethodImpl(Inline)]
            get => (byte)((byte)Op0.IsNonEmpty + (byte)Op1.IsNonEmpty + (byte)Op2.IsNonEmpty + (byte)Op3.IsNonEmpty);
        }
    }
}