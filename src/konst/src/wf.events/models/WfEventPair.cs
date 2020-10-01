//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.IO;

    using static Konst;
    using static Render;
    using static WfCore;

    public readonly struct WfEventPair<S,T>
        where S : struct, IWfEvent<S>
        where T : struct, IWfEvent<T>
    {
        public readonly S A;

        public readonly T B;

        [MethodImpl(Inline)]
        public static implicit operator WfEventPair<S,T>((S a, T b) src)
            => new WfEventPair<S,T>(src.a, src.b);

        [MethodImpl(Inline)]
        public static implicit operator WfEventPair<S,T>(Paired<S,T> src)
            => new WfEventPair<S,T>(src.Left, src.Right);

        [MethodImpl(Inline)]
        public WfEventPair(S a, T b)
        {
            A = a;
            B = b;
        }
    }
}