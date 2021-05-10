//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Svc = Z0;

    [ApiHost]
    public static class XSvcFactory
    {
        [Op]
        public static ApiComments ApiComments(this IWfRuntime wf)
            => Svc.ApiComments.create(wf);

        [Op]
        public static ApiResProvider ApiResProvider(this IWfRuntime wf)
            => Svc.ApiResProvider.create(wf);

        [Op]
        public static ApiHexArchive ApiHexArchive(this IWfRuntime wf)
            => Svc.ApiHexArchive.create(wf);

        /// <summary>
        /// Closes generic operations over the set of primal types that each operation supports
        /// </summary>
        /// <param name="generics">Metadata for generic operations</param>
        [Op]
        public static ApiIndexBuilder ApiIndexBuilder(this IWfRuntime wf)
             => Svc.ApiIndexBuilder.create(wf);

        [Op]
        public static BitMaskServices ApiBitMasks(this IWfRuntime wf)
            => Svc.BitMaskServices.create(wf);

        [Op]
        public static ApiAssets ApiAssets(this IWfRuntime wf)
            => Svc.ApiAssets.create(wf);

        [Op]
        public static Symbolism Symbolism(this IWfRuntime wf)
            => Svc.Symbolism.create(wf);

        [Op]
        public static ApiHex ApiHex(this IWfRuntime wf)
            => Svc.ApiHex.create(wf);

        [Op]
        public static ApiCatalogs ApiCatalogs(this IWfRuntime wf)
            => Svc.ApiCatalogs.create(wf);

        [Op]
        public static ApiJit ApiJit(this IWfRuntime wf)
            => Svc.ApiJit.create(wf);

        [Op]
        public static ApiExtractPipe ApiExtractPipe(this IWfRuntime wf)
            => Svc.ApiExtractPipe.create(wf);

        [Op]
        public static ApiQuery ApiQuery(this IWfRuntime wf)
            => Svc.ApiQuery.create(wf);

        [Op]
        public static HexPacks HexPacks(this IWfRuntime wf)
            => Svc.HexPacks.create(wf);

        [Op]
        public static SymServices SymServices(this IWfRuntime wf)
            => Svc.SymServices.create(wf);

        [Op]
        public static MemoryEmitter MemoryEmitter(this IWfRuntime wf)
            => Svc.MemoryEmitter.create(wf);
    }
}