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

        FS.FileName HexFileName
            => LegalFileName(Host, FileExtensions.Hex);

        FS.FilePath HostHexPath
            => HexDir() + HexFileName;
    }
}