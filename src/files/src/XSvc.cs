//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    [ApiHost]
    public static class XSvc
    {
        [Op]
        public static FileCatalog Catalog(this FS.FolderPath root)
            => new FileCatalog(root);
    }
}