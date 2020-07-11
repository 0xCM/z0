//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{                
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

        /// <summary>
        /// Obliterates all content in archive-owned directories, returning the obliteration subjects upon completion
        /// </summary>
        FolderPath[] Clear(params PartId[] parts)
        {
            if(parts.Length == 0)
            {
                var dst = Root.list<FolderPath>();
                dst.Add(ExtractDir.Clear());
                dst.Add(ParsedDir.Clear());
                dst.Add(AsmDir.Clear());
                dst.Add(CodeDir.Clear());
                dst.Add(UnparsedDir.Clear());
                return dst.ToArray();
            }
            else
            {
                for(var i=0; i<parts.Length; i++)
                {
                    var part = parts[i];
                    z.iter(ExtractDir.Files(part, Extract), f => f.Delete());
                    z.iter(ParsedDir.Files(part, Parsed), f => f.Delete());
                    z.iter(AsmDir.Files(part, Asm), f => f.Delete());
                    z.iter(CodeDir.Files(part, Hex), f => f.Delete());
                    z.iter(UnparsedDir.Files(part, Unparsed), f => f.Delete());
                }
                return sys.empty<FolderPath>();
            }
        }                
    }
}