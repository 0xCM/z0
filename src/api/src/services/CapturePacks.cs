//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    [ApiHost]
    public sealed class ApiCapturePacks : AppService<ApiCapturePacks>
    {
        public ApiCapturePack Create(Timestamp ts)
            => new ApiCapturePack(Db.CapturePacks() + FS.folder(ts.Format()));

        public ApiCapturePack Create()
            => Create(root.now());
    }
}