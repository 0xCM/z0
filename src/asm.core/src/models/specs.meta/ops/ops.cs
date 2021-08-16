//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial class AsmMetaSpecs
    {
        [MethodImpl(Inline)]
        public static operand<A0> op<A0>(A0 a0)
            where A0 : unmanaged, IOperand
                => new operand<A0>(a0);

        [MethodImpl(Inline)]
        public static operands<A0,A1> ops<A0,A1>(A0 a0, A1 a1)
            where A0 : unmanaged, IOperand
            where A1 : unmanaged, IOperand
                => new operands<A0,A1>(a0,a1);

        [MethodImpl(Inline)]
        public static operands<A0,A1,A2> ops<A0,A1,A2>(A0 a0, A1 a1, A2 a2)
            where A0 : unmanaged, IOperand
            where A1 : unmanaged, IOperand
            where A2 : unmanaged, IOperand
                => new operands<A0,A1,A2>(a0,a1,a2);
    }
}