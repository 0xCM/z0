//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Concurrent;

    using static Konst;

    public readonly struct CmdCatalog : ICmdCatalog<CmdCatalog>
    {
        public IWfShell Wf {get;}

        [MethodImpl(Inline)]
        public CmdCatalog(IWfShell wf)
            => Wf = wf;
    }
}