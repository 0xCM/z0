//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Threading;
    using System.Threading.Tasks;

    public abstract class FileProcessor<T> : AppWorker<T,FS.FolderPath,FS.FolderPath>
        where T : FileProcessor<T>,new()
    {
        public FileProcessor()
        {

        }

        public override Task Process(FS.FolderPath src, FS.FolderPath dst, CancellationToken cancel)
        {
            return root.run(() => Run(src,dst,cancel), cancel);
        }

        protected abstract void Run(FS.FolderPath src, FS.FolderPath dst, CancellationToken cancel);
    }
}