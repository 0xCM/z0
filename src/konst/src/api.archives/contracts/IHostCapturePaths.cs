//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IHostCapturePaths : IPartCapturePaths
    {
        ApiHostUri Host {get;}

        FS.FolderPath HostAsmDir
            => FS.dir((AsmDir + PartFolderName(Host.Owner)).Name);

        FileName X86FileName
            => LegalFileName(Host, HexLine);

        FilePath HostX86Path
            => X86Dir + X86FileName;

        FS.FileName AsmFile
            => FS.file(LegalFileName(Host, Asm).Name);

        FS.FilePath HostAsmPath
            => HostAsmDir + AsmFile;

        FS.FileName CilFile
            => FS.file(LegalFileName(Host, IlData).Name);

        FS.FilePath CilPath
            => CilDir + CilFile;
    }
}