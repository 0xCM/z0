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
        FileKind FileKind {get;}
    }

    [Free]
    public interface ITypedFile<F> : ITypedFile
        where F : struct, ITypedFile<F>
    {

    }
}