//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct ApiHexArchive : IFileArchive
    {
        public FS.FolderPath Root {get;}

        [MethodImpl(Inline)]
        public ApiHexArchive(FS.FolderPath root)
            => Root = root;

        public FS.FileExt DefaultExt
            => FileExtensions.Hex;

        /// <summary>
        /// Reads the archived files owned by a specified host
        /// </summary>
        public ApiCodeBlock[] Read(ApiHostUri host)
        {
            var hfn = FS.file(host.Owner, host.Name, DefaultExt);
            var path = paths(Root, DefaultExt).Where(f => f.FileName.Name == hfn.Name).FirstOrDefault(FS.FilePath.Empty);
            return read(path);
        }

        public ApiCodeBlock[] Read(FS.FilePath src)
            => ApiHexReader.read(src).Where(x => x.IsNonEmpty);

        public ListedFiles List()
            => FS.list(Root.Files(DefaultExt));

        public Deferred<FS.FilePath> ArchiveFiles()
            => Root.EnumerateFiles(DefaultExt, true);

        /// <summary>
        /// Enumerates the archived files owned by a specified part
        /// </summary>
        public FS.FilePath[] Files(PartId owner)
            => Root.Files(owner, DefaultExt, true);

        /// <summary>
        /// Enumerates the content of all archived files
        /// </summary>
        public IEnumerable<ApiCodeBlock> ApiCode()
        {
            var list = List();
            var iCount = list.Count;
            for(var i=0; i<iCount; i++)
            {
                var path = list[i].Path;
                var items = Z0.ApiCode.extracts(path);
                var jCount = items.Length;
                for(var j=0; j<jCount; j++)
                    yield return items[j];            }
        }

        /// <summary>
        /// Enumerates the content of archived files owned by a specified part
        /// </summary>
        public IEnumerable<ApiCodeBlock> ApiCode(PartId owner)
        {
            foreach(var file in Files(owner))
            foreach(var item in Read(file))
                if(item.IsNonEmpty)
                    yield return item;
        }

        /// <summary>
        /// Reads the archived files with names that satisfy a specified predicate
        /// </summary>
        public IEnumerable<ApiCodeBlock> ApiCode(Func<FS.FileName,bool> predicate)
        {
            foreach(var file in ArchiveFiles().Where(f => predicate(f.FileName)))
            foreach(var item in Read(file))
            {
                if(item.IsNonEmpty)
                    yield return item;
            }
        }

        public ApiHostCode Index(FS.FilePath src)
        {
            var uri = ApiUri.host(src.FileName);
            if(uri.Failed || uri.Value.IsEmpty)
                return default;

            var dst = z.list<ApiCodeBlock>();
            foreach(var item in ApiCode())
                if(item.IsNonEmpty)
                    dst.Add(item);

            return new ApiHostCode(uri.Value, dst.Array());
        }

        static FS.FilePath[] paths(FS.FolderPath root, FS.FileExt ext)
            => root.Files(ext, true).Array();

        static ApiCodeBlock[] read(FS.FilePath src)
            => ApiHexReader.Service.Read(src).Where(x => x.IsNonEmpty);
    }
}