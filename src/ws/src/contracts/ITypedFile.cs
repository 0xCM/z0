//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface ITypedFile : IFile
    {
        IFileType FileType {get;}
    }

    [Free]
    public interface ITypedFile<T> : ITypedFile
        where T : struct, IFileType
    {
        IFileType ITypedFile.FileType
            => default(T);
    }

}