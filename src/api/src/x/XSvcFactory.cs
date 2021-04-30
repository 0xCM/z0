//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    [ApiHost]
    public static class XSvcFactory
    {
        [Op]
        public static ApiComments ApiComments(this IWfRuntime wf)
            => Z0.ApiComments.create(wf);

        [Op]
        public static ApiResProvider ApiResProvider(this IWfRuntime wf)
            => Z0.ApiResProvider.create(wf);

        public static ApiHexArchive ApiHexArchive(this IWfRuntime wf)
            => Z0.ApiHexArchive.create(wf);

        /// <summary>
        /// Closes generic operations over the set of primal types that each operation supports
        /// </summary>
        /// <param name="generics">Metadata for generic operations</param>
        [Op]
        public static ApiIndexBuilder ApiIndexBuilder(this IWfRuntime wf)
             => Z0.ApiIndexBuilder.create(wf);

        [Op]
        public static BitMaskServices ApiBitMasks(this IWfRuntime wf)
            => BitMaskServices.create(wf);

        [Op]
        public static ApiAssets ApiAssets(this IWfRuntime wf)
            => Z0.ApiAssets.create(wf);

        [Op]
        public static Symbolism Symbolism(this IWfRuntime wf)
            => Z0.Symbolism.create(wf);

        [Op]
        public static ApiHex ApiHex(this IWfRuntime wf)
            => Z0.ApiHex.create(wf);

        [Op]
        public static ApiDataService ApiData(this IWfRuntime wf)
            => Z0.ApiDataService.create(wf);

        [Op]
        public static ApiJit ApiJit(this IWfRuntime wf)
            => Z0.ApiJit.create(wf);

        [Op]
        public static ApiExtractPipe ApiExtractPipe(this IWfRuntime wf)
            => Z0.ApiExtractPipe.create(wf);

        [Op]
        public static ApiQuery ApiQuery(this IWfRuntime wf)
            => Z0.ApiQuery.create(wf);

        [Op]
        public static HexPacks HexPacks(this IWfRuntime wf)
            => Z0.HexPacks.create(wf);
    }
}