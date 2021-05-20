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
        Type Rep {get;}

        FileKind FileKind {get;}

        FS.FileExt FileExt {get;}

        FileType Untyped
            => api.type(Rep, FileKind, FileExt);
    }

    [Free]
    public interface IFileType<T> : IFileType
        where T : struct, IFileType<T>
    {
        Type IFileType.Rep
            => typeof(T);
    }
}