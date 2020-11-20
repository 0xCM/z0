//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    partial class WfShell
    {
        [MethodImpl(Inline), Op]
        public static IWfPaths paths()
            => new WfPaths(WfLogs.configure(controller().Id(), WfEnv.dbRoot()));

        [MethodImpl(Inline), Op]
        public static IWfPaths<A> paths<A>()
            => new WfPaths<A>(WfLogs.configure(controller<A>().Id(), WfEnv.dbRoot()));
    }
}