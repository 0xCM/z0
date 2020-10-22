//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static Konst;
    using static z;
    using static ArchiveFileKinds;

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

    public struct ModuleArchive : IModuleArchive
    {
        /// <summary>
        /// Creates an archive over both managed and unmanaged modules
        /// </summary>
        /// <param name="root">The archive root</param>
        [MethodImpl(Inline), Op]
        public static IModuleArchive create(FS.FolderPath root)
            => new ModuleArchive(root);

        public FS.FolderPath Root;

        FS.FolderPath IFileArchivePaths.Root
            => Root;

        [MethodImpl(Inline)]
        internal ModuleArchive(FS.FolderPath root)
            => Root = root;

        public IEnumerable<FileModule> ManagedDllFiles()
        {
            foreach(var path in Root.Files(true).Where(f => f.Is(Dll)))
                if(FS.managed(path, out var assname))
                    yield return new ManagedDllFile(path, assname);
        }

        public IEnumerable<FileModule> NativeDllFiles()
        {
            foreach(var path in Root.Files(true).Where(f => f.Is(Dll)))
                if(FS.native(path))
                    yield return new NativeDllFile(path);
        }

        public IEnumerable<FileModule> ManagedExeFiles()
        {
            foreach(var path in Root.Files(true).Where(f => f.Is(Exe)))
                if(FS.managed(path, out var assname))
                    yield return new ManagedExeFile(path, assname);
        }

        public IEnumerable<FileModule> NativeExeFiles()
        {
            foreach(var path in Root.Files(true).Where(f => f.Is(Exe)))
                if(FS.native(path))
                    yield return new NativeExeFile(path);
        }

        public IEnumerable<FileModule> StaticLibs()
        {
            foreach(var path in Root.Files(true))
                if(path.Is(Lib))
                    yield return new NativeLibFile(path);
        }

        public IEnumerable<FileModule> Files()
        {
            foreach(var path in Root.Files(true))
            {
                if(path.Is(Dll))
                {
                    if(FS.managed(path, out var assname))
                        yield return new ManagedDllFile(path, assname);
                    else
                        yield return new NativeDllFile(path);
                }
                else if(path.Is(Exe))
                {
                    if(FS.managed(path, out var assname))
                        yield return new ManagedExeFile(path, assname);
                    else
                        yield return new NativeExeFile(path);
                }
                else if(path.Is(Lib))
                    yield return new NativeLibFile(path);
            }
        }
    }
}