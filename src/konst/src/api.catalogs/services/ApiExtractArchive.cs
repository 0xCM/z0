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

    public readonly struct ApiExtractArchive : IFileArchive
    {
        readonly IWfShell Wf {get;}

        public FS.FolderPath Root {get;}

        [MethodImpl(Inline)]
        public ApiExtractArchive(IWfShell wf, FS.FolderPath root)
        {
            Wf = wf;
            Root = root;
        }

        [MethodImpl(Inline)]
        public ApiExtractArchive(IWfShell wf)
        {
            Wf = wf;
            Root = wf.Db().CapturedHexDir();
        }

        public FS.FileExt DefaultExt
            => FileExtensions.Hex;

        /// <summary>
        /// Reads the archived files owned by a specified host
        /// </summary>
        public Index<ApiCodeBlock> Read(ApiHostUri host)
        {
            var filename = FS.file(host.Owner, host.Name, DefaultExt);
            var path = paths(Root, DefaultExt).Where(f => f.FileName.Name == filename.Name).FirstOrDefault(FS.FilePath.Empty);
            if(path.IsEmpty)
            {
                Wf.Warn($"The {host} file {path} does not exist");
                return sys.empty<ApiCodeBlock>();
            }
            var flow = Wf.Processing(path, host);
            var data = read(path);
            Wf.Processed(flow, path, data.Length);
            return data;
        }

        public Index<ApiCodeBlock> Read(FS.FilePath src)
            => ApiExtractReader.read(src).Where(x => x.IsNonEmpty);

        public ListedFiles List()
            => FS.list(Root.Files(DefaultExt));

        public Deferred<FS.FilePath> ArchiveFiles()
            => Root.EnumerateFiles(DefaultExt, true);

        /// <summary>
        /// Enumerates the archived files owned by a specified part
        /// </summary>
        public FS.Files Files(PartId owner)
            => Root.Files(owner, DefaultExt, true);

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

        static Index<FS.FilePath> paths(FS.FolderPath root, FS.FileExt ext)
            => root.Files(ext, true);

        static ApiCodeBlock[] read(FS.FilePath src)
            => ApiExtractReader.Service.Read(src).Where(x => x.IsNonEmpty);
    }
}