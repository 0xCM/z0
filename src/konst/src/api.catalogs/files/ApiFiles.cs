//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using static Konst;
    using static z;

    [ApiHost]
    public readonly partial struct ApiFiles
    {
        public static Dictionary<PartId,PartFile[]> index(ArchiveFileKindId kind, PartFiles src, params PartId[] parts)
        {
            switch(kind)
            {
                case ArchiveFileKindId.Parsed:
                    return select(ArchiveFileKindId.Parsed, src.Parsed, parts);
                default:
                    return dict<PartId,PartFile[]>();
            }
        }

        static Dictionary<PartId,PartFile[]> select(ArchiveFileKindId kind, FS.Files src, PartId[] parts)
        {
            var partSet = parts.ToHashSet();
            var files = (from f in src
                        let part = f.Owner
                        where part != PartId.None && partSet.Contains(part)
                        let pf = new PartFile(part, kind, f)
                        group pf by pf.Part).ToDictionary(x => x.Key, y => y.ToArray());
            return files;
        }
    }
}