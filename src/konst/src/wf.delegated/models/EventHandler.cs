//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static WfDelegates;

    using D = WfDelegates;

    partial struct Delegated
    {
        public readonly struct EventHandler : IEventHandler
        {
            readonly D.EventHandler Fx;

            [MethodImpl(Inline)]
            internal EventHandler(D.EventHandler fx)
                => Fx = fx;

            [MethodImpl(Inline)]
            public void Accept(in IWfEvent src)
                => Fx(src);
        }
    }
}