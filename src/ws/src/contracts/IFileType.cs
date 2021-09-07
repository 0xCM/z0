//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static Blit;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IFileType
    {
        FileKind Kind {get;}

        FS.FileExt Ext {get;}
    }

    [Free]
    public interface IFileType<T> : IFileType
        where T : unmanaged, IFileType<T>
    {

    }
}