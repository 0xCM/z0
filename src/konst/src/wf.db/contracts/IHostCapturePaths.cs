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

        FS.FileName X86FileName
            => LegalFileName(Host, FileExtensions.Hex);

        FS.FilePath HostX86Path
            => HexDir + X86FileName;
    }
}