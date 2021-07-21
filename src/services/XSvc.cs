//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Svc = Z0;

    [ApiHost]
    public static class XSvc
    {
        [Op]
        public static ApiResProvider ApiResProvider(this IWfRuntime wf)
            => Svc.ApiResProvider.create(wf);

        [Op]
        public static AssetServices Assets(this IWfRuntime wf)
            => AssetServices.create(wf);

        [Op]
        public static CharMapper CharMapper(this IServiceContext context)
            => Svc.CharMapper.create(context);

        [Op]
        public static Symbolism Symbolism(this IWfRuntime wf)
            => Svc.Symbolism.create(wf);

        [Op]
        public static ApiHex ApiHex(this IWfRuntime wf)
            => Svc.ApiHex.create(wf);

        [Op]
        public static ApiHexPacks ApiHexPacks(this IWfRuntime wf)
            => Svc.ApiHexPacks.create(wf);

        [Op]
        public static ApiHexArchive ApiHexArchive(this IWfRuntime wf)
            => Svc.ApiHexArchive.create(wf);

        [Op]
        public static AsciBytes AsciBytes(this IServiceContext context)
            => Svc.AsciBytes.create(context);

        public static FileSplitter FileSplitter(this IWfRuntime wf)
            => Svc.FileSplitter.create(wf);

        [Op]
        public static ApiCaptureArchive ApiCaptureArchive(this IWfRuntime wf)
            => Z0.ApiCaptureArchive.create(wf);

        [Op]
        public static ApiPackages ApiPackages(this IEnvPaths src)
            => src.PackageRoot();

    }
}