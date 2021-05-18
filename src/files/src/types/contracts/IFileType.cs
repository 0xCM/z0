//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;
    using api = FileTypes;

    [Free]
    public interface IFileType
    {
        Type RuntimeType {get;}

        FileKind FileKind {get;}

        Index<FS.FileExt> Extensions {get;}

        FileType Untyped
            => api.type(RuntimeType,FileKind, Extensions);
    }

    [Free]
    public interface IFileType<T> : IFileType
        where T : struct, IFileType<T>
    {
        Type IFileType.RuntimeType
            => typeof(T);
    }
}