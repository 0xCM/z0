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

    using X = ArchiveFileKinds;

    public readonly struct ApiCodeArchive
    {
        readonly FS.FolderPath ArchiveRoot;

        [MethodImpl(Inline)]
        public ApiCodeArchive(FS.FolderPath root)
        {
            ArchiveRoot = root;
        }

        [MethodImpl(Inline)]
        public ApiCodeArchive(IWfShell wf)
        {
            ArchiveRoot = wf.Db().CaptureRoot() + FS.folder("code");
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
            var path = files(ArchiveRoot).Where(f => f.FileName.Name == hfn.Name).FirstOrDefault(FS.FilePath.Empty);
            return read(path);
        }

        public ApiCodeBlock[] Read(FS.FilePath src)
            => ApiHexReader.read(src).Where(x => x.IsNonEmpty);

        public ListedFiles List()
            => FS.list(FS.dir(ArchiveRoot.Name).Files(X.Hex));

        /// <summary>
        /// Enumerates the archived files
        /// </summary>
        public IEnumerable<FS.FilePath> Files()
            => ArchiveRoot.Files(X.Hex, true);

        /// <summary>
        /// Enumerates the archived files owned by a specified part
        /// </summary>
        public IEnumerable<FilePath> Files(PartId owner)
            => FolderPath.Define(ArchiveRoot.Name).Files(owner, FileExtensions.HexLine, true);

        public IEnumerable<ApiHostCodeBlocks> Indices(params PartId[] owners)
            => ApiFiles.indices(this, owners);

        /// <summary>
        /// Enumerates the content of all archived files
        /// </summary>
        public IEnumerable<ApiCodeBlock> Read()
            => ApiFiles.read(this);

        /// <summary>
        /// Enumerates the content of archived files owned by a specified part
        /// </summary>
        public IEnumerable<ApiCodeBlock> Read(PartId owner)
            => ApiFiles.read(this, owner);

        /// <summary>
        /// Reads the archived files with names that satisfy a specified predicate
        /// </summary>
        public IEnumerable<ApiCodeBlock> Read(Func<FS.FileName,bool> predicate)
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
        {
            var dir = FolderPath.Define(ArchiveRoot.Name);
            var path = dir + FileName.define(id,FileExtension.Define("hex"));
            return Read(FS.path(path.Name));
        }

        public ApiHostCodeBlocks Index(FilePath src)
            => ApiFiles.index(this, src);

        public ApiHostCodeBlocks Index(FS.FilePath src)
            => ApiFiles.index(this, src);

        static FS.FilePath[] files(FS.FolderPath root)
            => root.Files(X.Hex, true).Array();

        static ApiCodeBlock[] read(FS.FilePath src)
            => ApiHexReader.Service.Read(src).Where(x => x.IsNonEmpty);
    }
}