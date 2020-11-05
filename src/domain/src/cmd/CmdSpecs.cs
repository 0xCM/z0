//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    [ApiHost(ApiNames.CmdSpecs, true)]
    public readonly partial struct CmdSpecs
    {
        [MethodImpl(Inline), Op]
        public static ICmdCatalog catalog(IWfShell wf)
            => new CmdCatalog(wf);

        [MethodImpl(Inline), Op]
        public static CmdBuilder builder(IWfShell wf)
            => new CmdBuilder(wf);
    }
}