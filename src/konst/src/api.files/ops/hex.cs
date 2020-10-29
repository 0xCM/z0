//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;
    using System.Collections.Generic;

    using static Konst;
    using static z;

    partial struct ApiFiles
    {
        [MethodImpl(Inline), Op]
        public static ApiCodeArchive hex(IWfShell wf)
            => new ApiCodeArchive(wf);

        [MethodImpl(Inline), Op]
        public static ApiCodeArchive hex(FS.FolderPath root)
            => new ApiCodeArchive(root);

        public static ApiCodeBlock[] hexblocks(FS.FilePath src)
            => from line in src.ReadLines().Select(ApiHexParser.parse)
                where line.Succeeded
                select line.Value;

        [MethodImpl(Inline), Op]
        public static ApiCodeBlock[] hexblocks(IWfShell wf, ApiHostUri host)
            => hex(wf).Read(host);
    }
}