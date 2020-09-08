//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IPartLogPaths : IPartFolderPaths, IPartFileExtensions
    {
        FilePath StatusLogPath(FolderPath root, PartId id)
            => ShellDataDir(root) + FileName.define(id.Format(), StatusLog);

        FilePath ErrorLogPath(FolderPath root, PartId id)
            => ShellDataDir(root) + FileName.define(id.Format(), ErrorLog);

        FilePath StatusLogPath(FolderPath root, ApiHostUri host)
            => LogDirPath(root) + FileName.define(host.Name, StatusLog);
    }
}