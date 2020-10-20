//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;

    public interface IModuleArchive : IFileArchive<ModuleArchive,FileModule>
    {
        IEnumerable<FileModule> ManagedDllFiles();

        IEnumerable<FileModule> NativeDllFiles();

        IEnumerable<FileModule> ManagedExeFiles();

        IEnumerable<FileModule> NativeExeFiles();

        IEnumerable<FileModule> StaticLibs();

    }
}