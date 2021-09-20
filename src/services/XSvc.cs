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
        public static BitMaskServices ApiBitMasks(this IWfRuntime wf)
            => Svc.BitMaskServices.create(wf);

        [Op]
        public static HexCsvReader HexCsvReader(this IWfRuntime wf)
            => Svc.HexCsvReader.create(wf);

        [Op]
        public static HexCsvWriter HexCsvWriter(this IWfRuntime wf)
            => Svc.HexCsvWriter.create(wf);

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

        public static FileSplitter FileSplitter(this IWfRuntime wf)
            => Svc.FileSplitter.create(wf);

        [Op]
        public static ApiCaptureArchive ApiCaptureArchive(this IWfRuntime wf)
            => Svc.ApiCaptureArchive.create(wf);

        [Op]
        public static StringTables StringTables(this IWfRuntime wf)
            => Svc.StringTables.create(wf);

        [Op]
        public static ApiPackages ApiPackages(this IEnvPaths src)
            => src.PackageRoot();

        [Op]
        public static SymServices SymServices(this IWfRuntime wf)
            => Svc.SymServices.create(wf);
    }
}