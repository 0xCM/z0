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
            => new ApiPack(ApiPackSettings.init(Db.CapturePackRoot(), ts));

        public IApiPack Create(ApiPackSettings settings)
            => new ApiPack(settings);

        public IApiPack Create()
            => Create(core.now());

        public IApiPack Create(FS.FolderPath root)
            => new ApiPack(ApiPackSettings.init(root));

        public IApiPack Latest()
            => List().Last;

        public Index<IApiPack> List()
            => Db.CapturePackRoot().SubDirs(false).Select(x => (IApiPack)(Create(x)));
    }
}