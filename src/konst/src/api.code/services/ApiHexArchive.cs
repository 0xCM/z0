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
    using static memory;

    public readonly struct ApiHexArchive
    {
        readonly IWfShell Wf {get;}

        public FS.FolderPath Root {get;}

        [MethodImpl(Inline)]
        public ApiHexArchive(IWfShell wf, FS.FolderPath root)
        {
            Wf = wf;
            Root = root;
        }

        [MethodImpl(Inline)]
        public ApiHexArchive(IWfShell wf)
        {
            Wf = wf;
            Root = wf.Db().ApiHexRoot();
        }

        FS.FileExt Ext
            => FileExtensions.Hex;

        public FS.Files Files()
            => Root.Files(Ext);

        /// <summary>
        /// Enumerates the archived files owned by a specified part
        /// </summary>
        public FS.Files Files(PartId owner)
            => Root.Files(owner, Ext, true);

        /// <summary>
        /// Enumerates the archived files owned by a specified part
        /// </summary>
        public FS.Files Files(ApiHostUri host)
            => Root.Files(host, Ext, true);

        public Deferred<FS.FilePath> Enumerate()
            => Root.EnumerateFiles(Ext, true);

        public Index<ApiCodeBlock> Read(ApiHostUri host)
        {
            var file = FS.file(host.Owner, host.Name, Ext);
            var path = Paths().Where(f => f.FileName.Name == file.Name).FirstOrDefault(FS.FilePath.Empty);
            if(path.IsEmpty)
            {
                Wf.Warn(Msg.HostFileMissing.Format(host,path));
                return sys.empty<ApiCodeBlock>();
            }
            var flow = Wf.Processing(path, host);
            var data = Read(path);
            Wf.Processed(flow, path, data.Length);
            return data;
        }

        public Index<ApiCodeBlock> Read(FS.FilePath src)
            => ApiCode.reader(Wf).Read(src).Where(x => x.IsNonEmpty);

        /// <summary>
        /// Enumerates the content of archived files owned by a specified part
        /// </summary>
        public IEnumerable<ApiCodeBlock> CodeBlocks(PartId owner)
        {
            foreach(var file in Files(owner))
            foreach(var item in Read(file))
                if(item.IsNonEmpty)
                    yield return item;
        }

        public void CodeBlocks(PartId owner, Receiver<ApiCodeBlock> dst)
        {
            var files = Files(owner).View;
            var count = files.Length;
            for(var i=0; i<count; i++)
            {
                ref readonly var file = ref skip(files,i);
                var blocks = Read(file).View;
                var kBlocks = blocks.Length;
                for(var j=0; j<kBlocks; j++)
                {
                    ref readonly var block = ref skip(blocks,j);
                    if(block.IsNonEmpty)
                        dst(block);
                }
            }
        }

        /// <summary>
        /// Reads the archived files with names that satisfy a specified predicate
        /// </summary>
        public IEnumerable<ApiCodeBlock> CodeBlocks(Func<FS.FileName,bool> predicate)
        {
            foreach(var file in Enumerate().Where(f => predicate(f.FileName)))
            foreach(var item in Read(file))
            {
                if(item.IsNonEmpty)
                    yield return item;
            }
        }

        FS.Files Paths()
            => Root.Files(Ext, true);
    }

    partial struct Msg
    {
        public static RenderPattern<ApiHostUri,FS.FilePath> HostFileMissing => "The {0} file {1} does not exist";
    }
}