//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IApiHostPaths : IApiPartPaths
    {
        ApiHostUri Host {get;}

        FS.FileName HexFileName
            => LegalFileName(Host, FS.Extensions.Hex);

        FS.FilePath HostHexPath
            => HexDir() + HexFileName;
    }
}