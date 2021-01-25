//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static Part;

    partial struct ApiQuery
    {
        [Op]
        public static ApiHostCatalog members(IWfShell wf, IApiHost src)
        {
            var service = ApiJit.service(wf);
            var members = service.Jit(src);
            return members.Length == 0 ? ApiHostCatalog.Empty : new ApiHostCatalog(src, members);
        }

        [Op]
        public static ApiHostMemberCode code(IWfShell wf, ISystemApiCatalog api, ApiHostUri host, FS.FolderPath root)
        {
            var catalog = members(wf, api.FindHost(host).Require());
            if(catalog.IsEmpty)
                return ApiHostMemberCode.Empty;

            var idx = index(catalog);
            var archive =  Archives.capture(root);
            var paths =  Archives.capture(FS.dir(root.Name), host);
            var code = ApiHexReader.Service.Read(paths.HostX86Path);
            var opIndex =  CodeBlockIndex(code);
            return new ApiHostMemberCode(host, index(idx, opIndex));
        }
    }
}