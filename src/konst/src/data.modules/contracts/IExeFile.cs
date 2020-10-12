//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static FS;

    public interface IExeFile : IFileModule
    {
        FileModuleKind IFileModule.Kind => FileModuleKind.Exe;
    }

    public interface IExeFile<T> : IExeFile
        where T : struct, IExeFile<T>
    {

    }
}