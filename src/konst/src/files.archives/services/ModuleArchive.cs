//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static FileExtensions;

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

        IEnumerable<FileModule> dll_managed()
        {
            foreach(var path in Root.Files(true).Where(f => f.Is(Dll)))
                if(FS.managed(path, out var assname))
                    yield return new ManagedDllFile(path, assname);
        }

        IEnumerable<FileModule> dll_native()
        {
            foreach(var path in Root.Files(true).Where(f => f.Is(Dll)))
                if(FS.native(path))
                    yield return new NativeDllFile(path);
        }

        IEnumerable<FileModule> exe_managed()
        {
            foreach(var path in Root.Files(true).Where(f => f.Is(Exe)))
                if(FS.managed(path, out var assname))
                    yield return new ManagedExeFile(path, assname);
        }

        IEnumerable<FileModule> exe_native()
        {
            foreach(var path in Root.Files(true).Where(f => f.Is(Exe)))
                if(FS.native(path))
                    yield return new NativeExeFile(path);
        }

        IEnumerable<FileModule> lib_native()
        {
            foreach(var path in Root.Files(true))
                if(path.Is(Lib))
                    yield return new NativeLibFile(path);
        }

       IEnumerable<FileModule> modules()
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

        public IEnumerable<FileModule> ManagedDllFiles()
            => dll_managed();

        public IEnumerable<FileModule> NativeDllFiles()
            => dll_native();

        public IEnumerable<FileModule> ManagedExeFiles()
            => exe_managed();

        public IEnumerable<FileModule> NativeExeFiles()
            => exe_native();

        public IEnumerable<FileModule> StaticLibs()
            => lib_native();

        public IEnumerable<FileModule> Files()
            => modules();
    }
}