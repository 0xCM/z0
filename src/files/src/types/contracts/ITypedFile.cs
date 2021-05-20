//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;
    using api = FileTypes;

    public interface ITypedFile : IFsEntry
    {

    }

    public interface ITypedFile<T> : ITypedFile
        where T : struct, IFileType
    {

    }

    public interface ITypedFile<F,T> : ITypedFile<T>, IFsEntry<F>
        where F : struct, ITypedFile<F,T>
        where T : struct, IFileType
    {

    }
}