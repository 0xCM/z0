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
        public readonly struct EventHandler<E> : IWfEventReceiver<E>
            where E : struct, IWfEvent<E>
        {
            readonly D.EventHandler<E> Fx;

            [MethodImpl(Inline)]
            internal EventHandler(D.EventHandler<E> fx)
                => Fx = fx;

            [MethodImpl(Inline)]
            public void Accept(in E src)
                => Fx(src);
        }
    }
}