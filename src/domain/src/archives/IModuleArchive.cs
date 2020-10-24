//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IModuleArchive : IFileArchive<ModuleArchive>
    {
        IEnumerable<FileModule> ManagedDllFiles();

        IEnumerable<FileModule> NativeDllFiles();

        IEnumerable<FileModule> ManagedExeFiles();

        IEnumerable<FileModule> NativeExeFiles();

        IEnumerable<FileModule> StaticLibs();

        new IEnumerable<FileModule> Files();
    }
}