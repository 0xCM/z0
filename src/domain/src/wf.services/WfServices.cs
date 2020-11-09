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
    using api = Z0;

    [ApiHost(ApiNames.WfServices, true)]
    public static partial class WfServices
    {
        [Op]
        public static RuntimeArchive RuntimeArchive(this IWfShell wf)
            => api.RuntimeArchive.create();

        [Op]
        public static RuntimeArchive RuntimeArchive(this IWfShell wf, FS.FolderPath src)
            => api.RuntimeArchive.create(src);
    }
}