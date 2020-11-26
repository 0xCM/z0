//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;


    [Free]
    public interface IFileType
    {
        Type FileType {get;}
    }

    [Free]
    public interface IFileType<T> : IFileType
        where T : struct, IFileType<T>
    {
        Type IFileType.FileType
            => typeof(T);
    }

    [Free]
    public interface IFileKind : IFileType
    {

    }

    [Free]
    public interface IFileKind<K> : IFileKind
        where K : struct
    {
        K Kind {get;}

        Type IFileType.FileType
            => typeof(K);
    }
}