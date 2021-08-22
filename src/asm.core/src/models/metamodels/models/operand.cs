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

    partial class AsmMetamodels
    {
        [StructLayout(LayoutKind.Sequential,Pack=1)]
        public struct operand
        {
            public AsmOpClass OpClass {get;}

            public AsmSizeKind Size {get;}

            public byte Refinement {get;}

            [MethodImpl(Inline)]
            public operand(AsmOpClass opclass, AsmSizeKind size)
            {
                OpClass = opclass;
                Size = size;
                Refinement = 0;
            }

            [MethodImpl(Inline)]
            public operand(AsmOpClass opclass, AsmSizeKind size, byte refinement)
            {
                OpClass = opclass;
                Size = size;
                Refinement = refinement;
            }

        }

        public struct operand<A0>
            where A0 : unmanaged, IOperand
        {
            public A0 a0;

            [MethodImpl(Inline)]
            public operand(A0 a0)
            {
                this.a0 = a0;
            }

            [MethodImpl(Inline)]
            public static implicit operator operand<A0>(A0 src)
                => new operand<A0>(src);
        }
    }
}