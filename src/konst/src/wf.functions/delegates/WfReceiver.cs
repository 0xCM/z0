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

    public readonly struct WfReceiver : IWfEventReceiver
    {
        readonly D.EventHandler Fx;

        [MethodImpl(Inline)]
        internal WfReceiver(D.EventHandler fx)
            => Fx = fx;

        [MethodImpl(Inline)]
        public void Accept(in IWfEvent src)
            => Fx(src);
    }
}