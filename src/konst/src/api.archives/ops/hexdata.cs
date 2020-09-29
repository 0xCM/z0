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

    partial struct ApiArchives
    {
        [MethodImpl(Inline), Op]
        public static ApiCodeBlock[] hexdata(IWfShell wf, ApiHostUri host)
            => hex(wf).Read(host);
    }
}