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

    partial struct ApiHexArchives
    {
        public static ApiCodeBlock[] blocks(FS.FilePath src)
            => from line in src.ReadLines().Select(ApiCodeParser.parse)
                where line.Succeeded
                select line.Value;

        [MethodImpl(Inline), Op]
        public static ApiCodeBlock[] blocks(IWfShell wf, ApiHostUri host)
            => create(wf).Read(host);
    }
}