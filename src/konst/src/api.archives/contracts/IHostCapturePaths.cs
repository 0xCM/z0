//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IHostCapturePaths : IPartCapturePaths
    {
        ApiHostUri Host {get;}

        FS.FolderPath HostAsmDir
            => FS.dir((AsmDir + PartFolderName(Host.Owner)).Name);

        FileName ExtractFileName
            => LegalFileName(Host, Extract);

        FilePath HostExtractPath
            => ExtractDir + ExtractFileName;

        FileName ParsedFileName
            => LegalFileName(Host, Parsed);

        FilePath ParsedPath
            => ParsedDir + ParsedFileName;

        FileName X86FileName
            => LegalFileName(Host, HexLine);

        FilePath HostX86Path
            => X86Dir + X86FileName;

        FS.FileName AsmFile
            => FS.file(LegalFileName(Host, Asm).Name);

        FS.FilePath HostAsmPath
            => HostAsmDir + AsmFile;

        FileName CilFile
            => LegalFileName(Host, IlData);

        FilePath CilPath
            => CilDir + CilFile;
    }
}