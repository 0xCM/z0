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
        public static ApiComments ApiComments(this IWfShell wf)
            => Z0.ApiComments.create(wf);

        [Op]
        public static ApiResProvider ApiResProvider(this IWfShell wf)
            => Z0.ApiResProvider.create(wf);

        [Op]
        public static ICmdRunner<ApiCmd> ApiCmdRunner(this IWfShell wf)
            => Z0.ApiCmdHost.create(wf);

        [Op]
        public static ApiServices ApiServices(this IWfShell wf)
            => Z0.ApiServices.create(wf);

        public static ApiHexArchive ApiHexArchive(this IWfShell wf)
            => Z0.ApiHexArchive.create(wf);

        /// <summary>
        /// Closes generic operations over the set of primal types that each operation supports
        /// </summary>
        /// <param name="generics">Metadata for generic operations</param>
        public static ApiIndexBuilder ApiIndexBuilder(this IWfShell wf)
             => Z0.ApiIndexBuilder.create(wf);

        public static BitMaskServices ApiBitMasks(this IWfShell wf)
            => BitMaskServices.create(wf);

        public static ApiAssets ApiAssets(this IWfShell wf)
            => Z0.ApiAssets.create(wf);

        public static SymLiterals SymLiterals(this IWfShell wf)
            => Z0.SymLiterals.create(wf);

        public static ApiHex ApiHex(this IWfShell wf)
            => Z0.ApiHex.create(wf);

        public static ApiCatalogs ApiCatalogs(this IWfShell wf)
            => Z0.ApiCatalogs.create(wf);

        public static ApiJit ApiJit(this IWfShell wf)
            => Z0.ApiJit.create(wf);

        public static ApiClassCatalog ApiClassCatalog(this IWfShell wf)
            => Z0.ApiClassCatalog.create(wf);
    }
}