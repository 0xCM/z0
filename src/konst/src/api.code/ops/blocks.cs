//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct ApiCode
    {
        [MethodImpl(Inline), Op]
        public static ApiCodeBlock[] blocks(IWfShell wf, ApiHostUri host)
            => new ApiHexArchive(wf).Read(host);

        [Op]
        public static ApiCodeBlock[] blocks(FS.FilePath src)
            => from line in src.ReadLines().Select(ApiHexParser.parse)
                where line.Succeeded
                select line.Value;
    }
}