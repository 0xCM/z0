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
    public interface ITypedFile<F> : ITypedFile
        where F : unmanaged, IFileType
    {
        new F FileType => default(F);

        IFileType ITypedFile.FileType
            => FileType;
    }
}