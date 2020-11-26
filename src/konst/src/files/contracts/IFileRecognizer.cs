//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IFileRecognizer
    {
        bool Test(FS.FilePath src);

        Type SupportedType {get;}
    }

    [Free]
    public interface IFileRecognizer<T> : IFileRecognizer
        where T : struct, IFileType<T>
    {
        Type IFileRecognizer.SupportedType
            => typeof(T);
    }
}