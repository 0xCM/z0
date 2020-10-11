//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct PairedEvents<S,T>
        where S : struct, IWfEvent<S>
        where T : struct, IWfEvent<T>
    {
        public readonly S A;

        public readonly T B;

        [MethodImpl(Inline)]
        public static implicit operator PairedEvents<S,T>((S a, T b) src)
            => new PairedEvents<S,T>(src.a, src.b);

        [MethodImpl(Inline)]
        public static implicit operator PairedEvents<S,T>(Paired<S,T> src)
            => new PairedEvents<S,T>(src.Left, src.Right);

        [MethodImpl(Inline)]
        public PairedEvents(S a, T b)
        {
            A = a;
            B = b;
        }
    }
}