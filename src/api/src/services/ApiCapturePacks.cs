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
            => new ApiCapturePack(Db.CapturePackRoot() + FS.folder(ts.Format()));

        public ApiCapturePack Create()
            => Create(root.now());

        public Index<IApiCapturePack> List()
            => Db.CapturePackRoot().SubDirs(false).Select(x => (IApiCapturePack)(new ApiCapturePack(x)));
    }
}