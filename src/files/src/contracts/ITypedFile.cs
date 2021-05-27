//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface ITypedFile : IFsEntry
    {

    }

    [Free]
    public interface ITypedFile<T> : ITypedFile
        where T : struct, IFileType
    {

    }

    [Free]
    public interface ITypedFile<F,T> : ITypedFile<T>, IFsEntry<F>
        where F : struct, ITypedFile<F,T>
        where T : struct, IFileType
    {

    }
}