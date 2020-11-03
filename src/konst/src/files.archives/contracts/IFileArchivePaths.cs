//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IFileArchivePaths : IFileExtensions
    {
        FS.FolderPath Root {get;}
    }

    [Free]
    public interface IFileArchivePaths<H> : IFileArchivePaths
        where H : struct, IFileArchivePaths<H>
    {

    }
}