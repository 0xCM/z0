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
    using static z;

    using static ArchiveExt;

    public readonly struct ModuleArchive : IModuleArchive
    {
        public FS.FolderPath Root => Config.Root;

        public ArchiveConfig Config {get;}

        [MethodImpl(Inline)]
        internal ModuleArchive(ArchiveConfig src)
            => Config= src;

        public void Query(Receiver<ManagedDll> dst)
        {
            foreach(var path in Root.Files(true).Where(f => f.Is(Dll)))
                if(FS.managed(path, out var assname))
                    dst(new ManagedDll(path, assname));
        }

        public void Query(Receiver<NativeDll> dst)
        {
            foreach(var path in Root.Files(true).Where(f => f.Is(Dll)))
                if(!FS.managed(path, out var assname))
                    dst(new NativeDll(path));
        }

        public  void Query(Receiver<ManagedExe> dst)
        {
            foreach(var path in Root.Files(true).Where(f => f.Is(Exe)))
                if(FS.managed(path, out var assname))
                    dst(new ManagedExe(path, assname));
        }

        public void Query(Receiver<NativeLib> dst)
        {
            foreach(var path in Root.Files(true))
                if(path.Is(Lib))
                    dst(new NativeLib(path));
        }

        public IEnumerable<FileModule> Query()
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