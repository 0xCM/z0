//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct SFx
    {
        public readonly struct Projector<S,T> : IProjector<S,T>
        {
            readonly Func<S,T> Fx;

            [MethodImpl(Inline)]
            public Projector(Func<S,T> fx)
                => Fx = fx;

            [MethodImpl(Inline)]
            public T Invoke(S a)
                => Fx(a);
        }
    }
}