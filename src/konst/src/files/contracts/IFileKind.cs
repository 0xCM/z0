//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IFileKind : IFileType
    {
        FS.FileExt DefaultExt {get;}
    }

    [Free]
    public interface IFileKind<H> : IFileKind, IFileType<H>
        where H : struct, IFileKind<H>
    {
    }

    [Free]
    public interface IFileKind<H,K> : IFileKind<H>
        where H : struct, IFileKind<H,K>
        where K : unmanaged
    {
        K Classifier {get;}
    }
}