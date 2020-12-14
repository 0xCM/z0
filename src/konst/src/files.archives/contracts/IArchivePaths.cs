//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IArchivePaths : IFileExtensions
    {
        FS.FolderPath Root {get;}
    }

    [Free]
    public interface IArchivePaths<H> : IArchivePaths
        where H : struct, IArchivePaths<H>
    {

    }
}