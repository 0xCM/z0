//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IHostCapturePaths : IPartCapturePaths
    {
        ApiHostUri Host {get;}

        FolderPath HostAsmDir
            => AsmDir + PartFolderName(Host.Owner);

        FileName ExtractFileName
            => LegalFileName(Host, Extract);

        FilePath HostExtractPath
            => ExtractDir + ExtractFileName;

        FileName ParsedFileName
            => LegalFileName(Host, Parsed);

        FilePath ParsedPath
            => ParsedDir + ParsedFileName;

        FileName HexFileName
            => LegalFileName(Host, HexLine);

        FilePath HostHexPath
            => CodeDir + HexFileName;

        FileName AsmFile
            => LegalFileName(Host, Asm);

        FilePath HostAsmPath
            => HostAsmDir + AsmFile;

        FileName CilFile
            => LegalFileName(Host, Il);

        FileName CilDataFile
            => LegalFileName(Host, IlData);

        FilePath CilDataPath
            => CilDataDir + CilDataFile;
    }
}