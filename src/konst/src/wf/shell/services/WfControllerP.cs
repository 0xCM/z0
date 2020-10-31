//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Konst;

    public readonly struct WfController<P> : IWfControl<P>
        where P : IPart<P>, new()
    {
        public Assembly Component
        {
            [MethodImpl(Inline)]
            get => typeof(P).Assembly;
        }

        [MethodImpl(Inline)]
        public static implicit operator WfController(WfController<P> src)
            => new WfController(src.Component);
    }
}