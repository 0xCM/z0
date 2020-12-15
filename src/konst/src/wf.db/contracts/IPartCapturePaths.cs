//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface IPartCapturePaths : IPartFilePaths, IPartImmPaths
    {
        FS.FolderPath X86Dir
            => X86DirPath(ArchiveRoot);

        FS.FilePath AsmPath(FS.FileName name)
            => FS.path(AsmFilePath(ArchiveRoot, name).Name);

        FilePath HexPath(FS.FileName name)
            => HexFilePath(ArchiveRoot, name);

        FilePath HexPath(ApiHostUri host)
            => HexFilePath(ArchiveRoot, host);
    }
}