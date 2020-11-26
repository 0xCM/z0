//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    internal struct WfContext<C> : IWfContext<C>
    {
        readonly IWfContext Root;

        public C State {get;}

        [MethodImpl(Inline)]
        public WfContext(IWfContext root, C state)
        {
            Root = root;
            State = state;
        }

        public IWfPaths Paths
            => Root.Paths;

        public IJsonSettings Settings
            => Root.Settings;

        public IApiParts ApiParts
            => Root.ApiParts;

        public WfController Controller
            => Root.Controller;

        public string[] Args
            => Root.Args;
    }
}