//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;
    using System.Collections.Generic;

    using static Konst;
    using static z;

    partial struct ApiFiles
    {
        [MethodImpl(Inline), Op]
        public static ApiHostCodeBlocks index(ApiHostUri host, ApiCodeBlock[] code)
            => new ApiHostCodeBlocks(host,code);

        public static ApiHostCodeBlocks index(ApiCodeArchive src, FS.FilePath path)
        {
            var uri = ApiUri.host(path.Name);
            if(uri.Failed || uri.Value.IsEmpty)
                return default;

            var dst = z.list<ApiCodeBlock>();
            foreach(var item in read(src))
                if(item.IsNonEmpty)
                    dst.Add(item);

            return index(uri.Value, dst.Array());
        }

        public static IEnumerable<ApiHostCodeBlocks> indices(ApiCodeArchive src, params PartId[] owners)
        {
            if(owners.Length != 0)
            {
                foreach(var owner in owners)
                foreach(var file in src.Files(owner))
                {
                    var idx = src.Index(file);
                    if(idx.IsNonEmpty)
                        yield return idx;
                }
            }
            else
            {
                foreach(var file in src.Files())
                {
                    var idx = src.Index(file);
                    if(idx.IsNonEmpty)
                        yield return idx;
                }
            }
        }
    }
}