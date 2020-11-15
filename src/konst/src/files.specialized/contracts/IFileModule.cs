//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IFileModule : IFile<FileModuleKind>
    {
        FileModuleKind ModuleKind {get;}

        FileModuleKind IFile<FileModuleKind>.Kind
            => ModuleKind;

        string ITextual.Format()
            => Path.Name;
    }

    [Free]
    public interface IFileModule<T> : IFileModule
        where T : struct, IFileModule<T>
    {

    }

    [Free]
    public interface IFileModule<F,T> : IFileModule<T>
        where F : struct, IFileModule<F,T>
        where T : struct, IFileModule<T>
    {

    }
}