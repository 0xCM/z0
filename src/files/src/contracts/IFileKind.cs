//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IFileKind : IFileType
    {

    }

    [Free]
    public interface IFileKind<H> : IFileKind, IFileType<H>
        where H : struct, IFileKind<H>
    {
    }


}