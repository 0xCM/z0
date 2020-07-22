//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    public interface TPartLogPaths : TPartFolderPaths, TPartLogExtensions  
    {
        FilePath PartMessagLogPath(FolderPath root, PartId id)
            => PartExeRoot(root) + FileName.Define(id.Format(), StdOut);

        FilePath PartErrorLogPath(FolderPath root, PartId id)
            => PartExeRoot(root) + FileName.Define(id.Format(), ErrOut);

        FilePath HostLogPath(FolderPath root, ApiHostUri host)
            => LogDirPath(root) + FileName.Define(host.Name, Log);
    }
}