//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface IPartCapturePaths : IPartFilePaths, IPartImmPaths
    {
        FolderPath ExtractDir
            => ExtractDirPath(ArchiveRoot);

        FolderPath ParsedDir
            => ParsedDirPath(ArchiveRoot);

        FolderPath X86Dir
            => X86DirPath(ArchiveRoot);

        FolderPath CilDir
            => CilDirPath(ArchiveRoot);

        FolderPath AsmDir
            => AsmDirPath(ArchiveRoot);

        FS.FilePath AsmPath(FileName name)
            => FS.path(AsmFilePath(ArchiveRoot, name).Name);

        FilePath HexPath(FileName name)
            => HexFilePath(ArchiveRoot, name);

        FilePath HexPath(ApiHostUri host)
            => HexFilePath(ArchiveRoot, host);

        FS.FilePath[] AsmPaths
            => AsmFilePaths(ArchiveRoot).Select(x => FS.path(x.Name));

        FS.FilePath[] HexPaths
            => HexFilePaths(ArchiveRoot).Select(x => FS.path(x.Name));

        FS.FilePath[] ParsePaths
            => ParseFilePaths(ArchiveRoot).Select(x => FS.path(x.Name));
    }
}