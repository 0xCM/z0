//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IPartLogPaths : IPartFolderPaths, IPartLogExtensions
    {
        FilePath StatusLogPath(FolderPath root, PartId id)
            => PartExeRoot(root) + FileName.Define(id.Format(), StatusLog);

        FilePath ErrorLogPath(FolderPath root, PartId id)
            => PartExeRoot(root) + FileName.Define(id.Format(), ErrorLog);

        FilePath StatusLogPath(FolderPath root, ApiHostUri host)
            => LogDirPath(root) + FileName.Define(host.Name, StatusLog);
    }
}