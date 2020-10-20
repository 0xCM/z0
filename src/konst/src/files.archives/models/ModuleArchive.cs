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

    public readonly struct ModuleArchive : IModuleArchive
    {
        /// <summary>
        /// Creates an archive over both managed and unmanaged modules
        /// </summary>
        /// <param name="root">The archive root</param>
        [MethodImpl(Inline), Op]
        public static IModuleArchive create(ArchiveConfig config)
            => new ModuleArchive(config);

        /// <summary>
        /// Creates an archive over both managed and unmanaged modules
        /// </summary>
        /// <param name="root">The archive root</param>
        [MethodImpl(Inline), Op]
        public static IModuleArchive create(FS.FolderPath root)
            => new ModuleArchive(new ArchiveConfig(root));

        public FS.FolderPath Root => Config.Root;


        public ArchiveConfig Config {get;}

        [MethodImpl(Inline)]
        internal ModuleArchive(ArchiveConfig src)
            => Config= src;


        public IEnumerable<FileModule> ManagedDllFiles()
        {
            foreach(var path in Root.Files(true).Where(f => f.Is(Dll)))
                if(FS.managed(path, out var assname))
                    yield return new ManagedDll(path, assname);
        }

        public IEnumerable<FileModule> NativeDllFiles()
        {
            foreach(var path in Root.Files(true).Where(f => f.Is(Dll)))
                if(FS.native(path))
                    yield return new NativeDll(path);
        }

        public IEnumerable<FileModule> ManagedExeFiles()
        {
            foreach(var path in Root.Files(true).Where(f => f.Is(Exe)))
                if(FS.managed(path, out var assname))
                    yield return new ManagedExe(path, assname);
        }

        public IEnumerable<FileModule> NativeExeFiles()
        {
            foreach(var path in Root.Files(true).Where(f => f.Is(Exe)))
                if(FS.native(path))
                    yield return new NativeExe(path);
        }

        public IEnumerable<FileModule> StaticLibs()
        {
            foreach(var path in Root.Files(true))
                if(path.Is(Lib))
                    yield return new NativeLib(path);
        }

        public IEnumerable<FileModule> Files()
        {
            foreach(var path in Root.Files(true))
            {
                if(path.Is(Dll))
                {
                    if(FS.managed(path, out var assname))
                        yield return new ManagedDll(path, assname);
                    else
                        yield return new NativeDll(path);
                }
                else if(path.Is(Exe))
                {
                    if(FS.managed(path, out var assname))
                        yield return new ManagedExe(path, assname);
                    else
                        yield return new NativeExe(path);
                }
                else if(path.Is(Lib))
                    yield return new NativeLib(path);
            }
        }
    }
}