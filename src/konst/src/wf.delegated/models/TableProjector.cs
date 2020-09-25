//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using D = WfDelegates;

    partial struct Delegated
    {
        public readonly struct TableProjector<S,T> : IDataProjector<S,T>
            where S : struct
        {
            readonly D.TableProjector<S,T> Fx;

            [MethodImpl(Inline)]
            internal TableProjector(D.TableProjector<S,T> fx)
                => Fx = fx;

            [MethodImpl(Inline)]
            public T Map(in S src)
                => Fx(src);
        }
    }
}