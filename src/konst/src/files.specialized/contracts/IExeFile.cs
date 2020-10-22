//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IExeFile : IFileModule
    {
        FileModuleKind IFileModule.ModuleKind => FileModuleKind.Exe;
    }

    [Free]
    public interface IExeFile<T> : IExeFile
        where T : struct, IExeFile<T>
    {

    }
}