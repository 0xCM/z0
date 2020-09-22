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

    using static Konst;

    using api = ApiArchives;

    public readonly struct ApiHexArchive
    {
        readonly FolderPath ArchiveRoot;

        [MethodImpl(Inline)]
        public ApiHexArchive(FS.FolderPath root)
        {
            ArchiveRoot = FolderPath.Define(root.Name);
        }

        [MethodImpl(Inline)]
        public ApiHexArchive(IWfShell wf)
        {
            ArchiveRoot = FolderPath.Define((wf.CaptureRoot + FS.folder("code")).Name);
        }

        public FS.FolderPath Root
        {
            [MethodImpl(Inline)]
            get => FS.dir(ArchiveRoot.Name);
        }

        /// <summary>
        /// Reads the archived files owned by a specified host
        /// </summary>
        public ApiCodeBlock[] Read(ApiHostUri host)
        {
            var hfn = FileName.define(host.Owner, host.Name, FileExtensions.HexLine);
            var path = files(ArchiveRoot).Where(f => f.FileName == hfn).FirstOrDefault(FilePath.Empty);
            return read(path);
        }

        public ApiCodeBlock[] Read(FS.FilePath src)
            => ApiHexReader.read(src).Where(x => x.IsNonEmpty);

        public ListedFiles List()
            => FS.dir(ArchiveRoot.Name).Files(GlobalExtensions.Hex);

        /// <summary>
        /// Enumerates the archived files
        /// </summary>
        public IEnumerable<FilePath> Files()
            => ArchiveRoot.Files(FileExtensions.HexLine, true);

        /// <summary>
        /// Enumerates the archived files owned by a specified part
        /// </summary>
        public IEnumerable<FilePath> Files(PartId owner)
            => ArchiveRoot.Files(owner, FileExtensions.HexLine, true);

        public IEnumerable<ApiHostCodeIndex> Indices(params PartId[] owners)
        {
            if(owners.Length != 0)
            {
                foreach(var owner in owners)
                foreach(var file in Files(owner))
                {
                    var idx = Index(file);
                    if(idx.IsNonEmpty)
                        yield return idx;
                }
            }
            else
            {
                foreach(var file in Files())
                {
                    var idx = Index(file);
                    if(idx.IsNonEmpty)
                        yield return idx;
                }
            }
        }

        /// <summary>
        /// Enumerates the content of all archived files
        /// </summary>
        public IEnumerable<ApiCodeBlock> Read()
        {
            var list = List();
            var iCount = list.Count;
            for(var i=0; i<iCount; i++)
            {
                var path = list[i].Path;
                var items = api.hex(path);
                var jCount = items.Length;
                for(var j=0; j<jCount; j++)
                    yield return items[j];            }
        }

        /// <summary>
        /// Enumerates the content of archived files owned by a specified part
        /// </summary>
        public IEnumerable<ApiCodeBlock> Read(PartId owner)
        {
            foreach(var file in Files(owner))
            foreach(var item in Read(file))
                if(item.IsNonEmpty)
                    yield return item;
        }

        /// <summary>
        /// Reads the archived files with names that satisfy a specified predicate
        /// </summary>
        public IEnumerable<ApiCodeBlock> Read(Func<FileName,bool> predicate)
        {
            foreach(var file in Files().Where(f => predicate(f.FileName)))
            foreach(var item in Read(file))
            {
                if(item.IsNonEmpty)
                    yield return item;
            }
        }

        /// <summary>
        /// Reads the code defined by a specified file
        /// </summary>
        /// <param name="src">The source path</param>
        public ApiCodeBlock[] Read(FilePath src)
            => ApiHexReader.Service.Read(src);

        /// <summary>
        /// Reads the bits of an identified operation
        /// </summary>
        /// <param name="id">The source path</param>
        public ApiCodeBlock[] Read(OpIdentity id)
            => Read(ArchiveRoot + FileName.define(id, FileExtensions.HexLine));

        public ApiHostCodeIndex Index(FilePath src)
        {
            var uri = ApiUriParser.host(src.FileName);
            if(uri.Failed || uri.Value.IsEmpty)
            {
                return ApiHostCodeIndex.Empty;
            }

            var dst = z.list<ApiCodeBlock>();
            foreach(var item in read(src))
                if(item.IsNonEmpty)
                    dst.Add(item);

            return EncodedX86.index(uri.Value, dst.Array());
        }

        static FilePath[] files(FolderPath root)
            => root.Files(FileExtensions.HexLine, true).Array();

        static ApiCodeBlock[] read(FilePath src)
            => ApiHexReader.Service.Read(src).Where(x => x.IsNonEmpty);
    }
}