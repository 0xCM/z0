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
    using static z;

    partial class WfShell
    {
        public static WfLogConfig logs(PartId part, FS.FolderPath logRoot, FS.FolderPath dbRoot)
            => new WfLogConfig(part, logRoot, dbRoot);

        public static WfLogConfig logs(PartId part, FS.FolderPath root)
            => logs(part, root, DbRoot());
    }
}