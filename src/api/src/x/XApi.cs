//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    [ApiHost]
    public static partial class XApi
    {
        [Op]
        public static IWfCmdHost<ApiCmd> ApiCmdHost(this IWfShell wf)
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
        public static ApiHexIndexer ApiHexIndexer(this IWfShell wf)
             => Z0.ApiHexIndexer.create(wf);

        public static BitMaskServices ApiBitMasks(this IWfShell wf)
            => BitMaskServices.create(wf);

        public static ApiAssets ApiAssets(this IWfShell wf)
            => Z0.ApiAssets.create(wf);
    }
}