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

    partial class AsmSpecs
    {
        public struct operands<A0,A1>
            where A0 : unmanaged, IAsmOperand
            where A1 : unmanaged, IAsmOperand
        {
            public A0 a0;

            public A1 a1;

            [MethodImpl(Inline)]
            public operands(A0 a0, A1 a1)
            {
                this.a0 = a0;
                this.a1 = a1;
            }

            [MethodImpl(Inline)]
            public static implicit operator operands<A0,A1>((A0 a0, A1 a1) src)
                => new operands<A0,A1>(src.a0, src.a1);
        }

        public struct operands<A0,A1,A2>
            where A0 : unmanaged, IAsmOperand
            where A1 : unmanaged, IAsmOperand
            where A2 : unmanaged, IAsmOperand
        {
            public A0 a0;

            public A1 a1;

            public A2 a2;

            [MethodImpl(Inline)]
            public operands(A0 a0, A1 a1, A2 a2)
            {
                this.a0 = a0;
                this.a1 = a1;
                this.a2 = a2;
            }

            [MethodImpl(Inline)]
            public static implicit operator operands<A0,A1,A2>((A0 a0, A1 a1, A2 a2) src)
                => new operands<A0,A1,A2>(src.a0, src.a1, src.a2);
        }

        [StructLayout(LayoutKind.Sequential, Pack=1)]
        public struct operands<A0,A1,A2,A3>
            where A0 : unmanaged, IAsmOperand
            where A1 : unmanaged, IAsmOperand
            where A2 : unmanaged, IAsmOperand
            where A3 : unmanaged, IAsmOperand
        {
            public A0 a0;

            public A1 a1;

            public A2 a2;

            public A3 a3;

            [MethodImpl(Inline)]
            public operands(A0 a0, A1 a1, A2 a2, A3 a3)
            {
                this.a0 = a0;
                this.a1 = a1;
                this.a2 = a2;
                this.a3 = a3;
            }

            [MethodImpl(Inline)]
            public static implicit operator operands<A0,A1,A2,A3>((A0 a0, A1 a1, A2 a2, A3 a3) src)
                => new operands<A0,A1,A2,A3>(src.a0, src.a1, src.a2, src.a3);
        }
    }
}