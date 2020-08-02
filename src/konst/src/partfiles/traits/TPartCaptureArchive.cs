//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{                
    using System;
    public interface TPartCaptureArchive : TPartFilePaths, TPartFileArchive, TPartImmArchive 
    {
        FolderPath ExtractDir 
            => ExtractDirPath(ArchiveRoot);

        FolderPath UnparsedDir 
            => UnparsedDirPath(ArchiveRoot);

        FolderPath ParsedDir 
            => ParsedDirPath(ArchiveRoot);
        
        FolderPath CodeDir 
            => HexDirPath(ArchiveRoot);
    
        FolderPath AsmDir 
            => AsmDirPath(ArchiveRoot);

        FolderPath LogDir 
            => LogDirPath(ArchiveRoot);

        FolderName AreaName 
            => FolderName.Empty;

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

        FilePath AsmPath(ApiHostUri host)
            => AsmFilePath(ArchiveRoot, host);

        FilePath ExtractPath(ApiHostUri host)
            => ExtractFilePath(ArchiveRoot, host);

        FilePath UnparsedPath(ApiHostUri host)
            => UnparsedFilePath(ArchiveRoot, host);

        FilePath ParseFilePath(ApiHostUri host)
            => ParseFilePath(ArchiveRoot, host);

        FilePath HostLogPath(ApiHostUri host)
            => HostLogPath(ArchiveRoot, host);

        FilePath[] AsmFiles 
            => AsmFilePaths(ArchiveRoot);

        FilePath[] HexFiles 
            => HexFilePaths(ArchiveRoot);

        FilePath[] ExtractFiles 
            => ExtractFilePaths(ArchiveRoot);

        FilePath[] ParseFiles 
            => ParseFilePaths(ArchiveRoot);

        FolderName SubjectName 
            => FolderName.Empty;

        FilePath[] ExtractFilePaths(params PartId[] parts)
            => PartFilePaths(ExtractDir, parts);

        FilePath[] ParseFilePaths(params PartId[] parts)
            => PartFilePaths(ParsedDir, parts);

        FilePath[] PartParseFilePaths(PartId[] parts,  PartId part)
            => PartFilePaths(ParsedDir, parts.Where(p => p == part));

        FilePath[] AsmFilePaths(params PartId[] parts)
            => PartFilePaths(AsmDir, parts);

        FilePath[] HexFilePaths(params PartId[] parts)
            => PartFilePaths(CodeDir, parts);
        
    }
}