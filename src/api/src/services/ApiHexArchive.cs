//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    using static Part;
    using static memory;

    public class ApiHexArchive : WfService<ApiHexArchive>
    {
        FS.FolderPath Root;

        protected override void OnInit()
        {
            Root = Db.ApiHexRoot();
        }

        FS.FileExt Ext
            => FS.Extensions.Hex;

        public FS.Files Files()
            => Root.Files(Ext);

        public FS.FilePath HostFile<T>()
            => HostFile(typeof(T).HostUri());

        public FS.FilePath HostFile(Type host)
            => HostFile(host.HostUri());

        /// <summary>
        /// Enumerates the archived files owned by a specified part
        /// </summary>
        public FS.Files PartFiles(PartId owner)
            => Root.Files(owner, Ext, true);

        public FS.FilePath HostFile(ApiHostUri host)
            => Root + FS.file(host.Part, host.Name, Ext);

        public Deferred<FS.FilePath> Enumerate()
            => Root.EnumerateFiles(Ext, true);

        public Index<ApiCodeBlock> Read(ApiHostUri host)
        {
            var file = FS.file(host.Part, host.Name, Ext);
            var path = Paths().Where(f => f.FileName.Name == file.Name).FirstOrDefault(FS.FilePath.Empty);
            if(path.IsEmpty)
            {
                Wf.Warn(Msg.HostFileMissing.Format(host,path));
                return sys.empty<ApiCodeBlock>();
            }
            var flow = Wf.Running(path);
            var data = Read(path);
            Wf.Ran(flow, data.Length);
            return data;
        }

        public Index<ApiCodeBlock> Read(FS.FilePath src)
            => ApiHex.reader(Wf).ReadHexBlocks(src).Where(x => x.IsNonEmpty);

        /// <summary>
        /// Enumerates the content of archived files owned by a specified part
        /// </summary>
        public IEnumerable<ApiCodeBlock> PartBlocks(PartId part)
        {
            foreach(var file in PartFiles(part))
            foreach(var item in Read(file))
                if(item.IsNonEmpty)
                    yield return item;
        }

        /// <summary>
        /// Enumerates the content of archived files owned by a specified part
        /// </summary>
        public IEnumerable<ApiCodeBlock> HostBlocks(ApiHostUri host)
        {
            var file = HostFile(host);
            if(file.Exists)
            {
                foreach(var item in Read(file))
                    if(item.IsNonEmpty)
                        yield return item;
            }
        }

        /// <summary>
        /// Enumerates the content of archived files owned by a specified part
        /// </summary>
        public IEnumerable<ApiCodeBlock> HostBlocks<T>()
            => HostBlocks(typeof(T).HostUri());

        public void CodeBlocks(PartId owner, Receiver<ApiCodeBlock> dst)
        {
            var files = PartFiles(owner).View;
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
}