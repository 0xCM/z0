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
            => new WfPaths(logConfig(controller().Id(), logRoot(), dbRoot()));
    }
}