//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IHostCapturePaths : IPartCapturePaths
    {
        ApiHostUri Host {get;}

        FileName ExtractFileName
            => LegalFileName(Host, Extract);

        new FilePath ExtractPath
            => ExtractDir + ExtractFileName;

        FileName ParsedFileName
            => LegalFileName(Host, Parsed);

        FilePath ParsedPath
            => ParsedDir + ParsedFileName;

        new FileName HexFileName
            => LegalFileName(Host, HexLine);

        new FilePath HexPath
            => CodeDir + HexFileName;

        FileName AmsFileName
            => LegalFileName(Host, Asm);

        FilePath CilDataPath
            => CilDataDir + CilFileName;

        new FilePath AsmPath
            => AsmDir + AmsFileName;

        new FileName CilFileName
            => LegalFileName(Host, Il);
    }
}