//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    [ApiHost]
    public sealed class ApiPacks : AppService<ApiPacks>
    {
        public IApiPack Create(Timestamp ts)
            => new ApiPack(Db.CapturePackRoot() + FS.folder(ts.Format()));

        public IApiPack Create()
            => Create(core.now());

        public Index<IApiPack> List()
            => Db.CapturePackRoot().SubDirs(false).Select(x => (IApiPack)(new ApiPack(x)));
    }
}