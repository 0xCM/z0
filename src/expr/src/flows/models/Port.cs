//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Flows
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct Port : IPort
    {
        readonly Index<Channel> Ins;

        readonly Index<Channel> Outs;

        [MethodImpl(Inline)]
        public Port(Channel[] ins, Channel[] outs)
        {
            Ins = ins;
            Outs = outs;
        }

        public ReadOnlySpan<Channel> Inputs
        {
            [MethodImpl(Inline)]
            get => Ins.View;
        }

        public ReadOnlySpan<Channel> Outputs
        {
            [MethodImpl(Inline)]
            get => Outs.View;
        }
    }
}