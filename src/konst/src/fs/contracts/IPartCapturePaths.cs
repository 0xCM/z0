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

        FolderPath CodeDir
            => HexDirPath(ArchiveRoot);

        FolderPath CilDataDir
            => CilDataDirPath(ArchiveRoot);

        FolderPath AsmDir
            => AsmDirPath(ArchiveRoot);

        FolderPath PartAsmDir(PartId part)
            => AsmDir + PartFolderName(part);

        FilePath AsmPath(FileName name)
            => AsmFilePath(ArchiveRoot, name);

        FilePath AsmPath<T>()
            => AsmFilePath<T>(ArchiveRoot);

        FilePath HexPath<T>()
            => HexFilePath<T>(ArchiveRoot);

        FilePath HexPath(FileName name)
            => HexFilePath(ArchiveRoot, name);

        FilePath HexPath(ApiHostUri host)
            => HexFilePath(ArchiveRoot, host);

        FilePath UnparsedPath(ApiHostUri host)
            => UnparsedFilePath(ArchiveRoot, host);

        FS.FilePath[] AsmPaths
            => AsmFilePaths(ArchiveRoot).Select(x => FS.path(x.Name));

        FS.FilePath[] HexPaths
            => HexFilePaths(ArchiveRoot).Select(x => FS.path(x.Name));

        FS.FilePath[] ParsePaths
            => ParseFilePaths(ArchiveRoot).Select(x => FS.path(x.Name));
    }
}