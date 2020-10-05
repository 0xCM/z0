//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static Konst;
    using static z;

    partial struct ApiHexArchives
    {
        [MethodImpl(Inline), Op]
        public static ApiCodeArchive create(IWfShell wf)
            => new ApiCodeArchive(wf);

        [MethodImpl(Inline), Op]
        public static ApiCodeArchive create(FS.FolderPath root)
            => new ApiCodeArchive(root);
    }
}
