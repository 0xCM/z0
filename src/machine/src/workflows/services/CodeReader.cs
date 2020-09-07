//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static Konst;
    using static z;

    public readonly struct CodeReader
    {
        public static IEnumerable<ApiHexIndex> index(FolderPath src, IWfEventSink sink, params PartId[] owners)
        {
            if(owners.Length != 0)
            {
                foreach(var owner in owners)
                foreach(var file in Files(src, owner))
                {
                    var idx = index(file, sink);
                    if(idx.IsNonEmpty)
                        yield return idx;
                }
            }
            else
            {
                foreach(var file in Files(src))
                {
                    var idx = index(file, sink);
                    if(idx.IsNonEmpty)
                        yield return idx;
                }
            }
        }

        public static IEnumerable<FilePath> Files(FolderPath src)
            => src.Files(FileExtensions.HexLine, true);

        public static IEnumerable<FilePath> Files(FolderPath src, PartId owner)
            => src.Files(owner, FileExtensions.HexLine, true);

        public static FilePath[] files(FolderPath root, PartId owner)
            => root.Files(owner, FileExtensions.HexLine, true).Array();

        public static FilePath[] files(FolderPath root)
            => root.Files(FileExtensions.HexLine, true).Array();

        public static ApiHex[] read(FilePath src)
            => ApiHexReader.Service.Read(src).Where(x => x.IsNonEmpty).Array();

        public static ApiHex[] read(FolderPath root, ApiHostUri host)
        {
            var hfn = FileName.define(host.Owner, host.Name, FileExtensions.HexLine);
            var path = files(root).Where(f => f.FileName == hfn).FirstOrDefault(FilePath.Empty);
            return read(path);
        }

        static ApiHexIndex index(FilePath src, IWfEventSink status)
        {
            var uri = ApiUriParser.host(src.FileName);
            if(uri.Failed || uri.Value.IsEmpty)
            {
                status.Deposit(WfEvents.error(nameof(CodeReader), $"{src} not found", default));
                return ApiHexIndex.Empty;
            }

            var dst = z.list<ApiHex>();
            foreach(var item in read(src))
                if(item.IsNonEmpty)
                    dst.Add(item);

            return Encoded.index(uri.Value, dst.Array());
        }
    }
}