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

        [Op]
        public static ICmdRunner<ApiCmd> ApiCmdRunner(this IWfRuntime wf)
            => Z0.ApiCmdHost.create(wf);

        public static ApiHexArchive ApiHexArchive(this IWfRuntime wf)
            => Z0.ApiHexArchive.create(wf);

        /// <summary>
        /// Closes generic operations over the set of primal types that each operation supports
        /// </summary>
        /// <param name="generics">Metadata for generic operations</param>
        public static ApiIndexBuilder ApiIndexBuilder(this IWfRuntime wf)
             => Z0.ApiIndexBuilder.create(wf);

        public static BitMaskServices ApiBitMasks(this IWfRuntime wf)
            => BitMaskServices.create(wf);

        public static ApiAssets ApiAssets(this IWfRuntime wf)
            => Z0.ApiAssets.create(wf);

        public static Symbolism Symbolism(this IWfRuntime wf)
            => Z0.Symbolism.create(wf);

        public static ApiHex ApiHex(this IWfRuntime wf)
            => Z0.ApiHex.create(wf);

        public static ApiCatalogs ApiCatalogs(this IWfRuntime wf)
            => Z0.ApiCatalogs.create(wf);

        public static ApiJit ApiJit(this IWfRuntime wf)
            => Z0.ApiJit.create(wf);

        public static ApiClassCatalog ApiClassCatalog(this IWfRuntime wf)
            => Z0.ApiClassCatalog.create(wf);
    }
}