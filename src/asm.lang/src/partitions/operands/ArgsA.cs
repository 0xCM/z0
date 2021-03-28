//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    /// <summary>
    /// Captures an operand
    /// </summary>
    public struct Args<A> : IAsmOperands<Args<A>,A>
        where A : unmanaged, IAsmOp
    {
        public A _A;

        [MethodImpl(Inline)]
        public Args(A a)
            => _A = a;

        public A this[N0 n]
        {
            [MethodImpl(Inline)]
            get => _A;
        }

        [MethodImpl(Inline)]
        public static implicit operator Args<A>(A src)
            => new Args<A>(src);

        [MethodImpl(Inline)]
        public static implicit operator Args(Args<A> src)
            => new Args(src._A);
    }
}