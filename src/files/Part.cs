//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: PartId(PartId.Files)]
namespace Z0.Parts
{
    public sealed class Files : Part<Files>
    {

    }
}

namespace Z0
{
    using Svc = Z0;

    [ApiHost]
    public static partial class XTend
    {
    }

    [ApiHost]
    public static class XSvc
    {
        [Op]
        public static FileCatalog FileCatalog(this IWfRuntime wf)
            => Svc.FileCatalog.create(wf);

        [Op]
        public static FileCatalog FileCatalog(this IWfRuntime wf, FS.FolderPath root)
            => wf.FileCatalog().Scoped(root);
    }
}