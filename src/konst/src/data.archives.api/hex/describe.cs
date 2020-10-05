//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;

    using static Konst;
    using static z;

    partial struct ApiHexArchives
    {
        public static ApiCodeBlockInfo[] describe(FS.FolderPath root)
        {
            var archive = ApiHexArchives.create(root);
            var files = archive.List();
            var dst = list<ApiCodeBlockInfo>();
            foreach(var file in files.Storage)
                dst.AddRange(archive.Read(file.Path).Select(x => x.Describe()));
            return dst.OrderBy(x => x.Base).ToArray();
        }
    }
}