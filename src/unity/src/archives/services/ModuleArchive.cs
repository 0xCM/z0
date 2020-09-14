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

    using static GlobalExtensions;

    public interface IModuleArchive : IFileArchive<ModuleArchive>

    {

    }


    public readonly struct ModuleArchive : IModuleArchive
    {
        [MethodImpl(Inline), Op]
        public static IModuleArchive create(FS.FolderPath root)
            => new ModuleArchive(root);

        public FS.FolderPath Root {get;}

        [MethodImpl(Inline)]
        public ModuleArchive(FS.FolderPath root)
        {
            Root = root;
        }

        IModuleArchive Base
            => this;

        public IEnumerable<FS.FileModule> Modules
        {
            get
            {
                foreach(var path in Root.Files(true))
                {
                   if(path.Is(Dll))
                   {
                        if(FS.managed(path, out var assname))
                            yield return new FS.ManagedDll(path, assname);
                        else
                            yield return new FS.NativeDll(path);
                   }
                   else if(path.Is(Exe))
                   {
                        if(FS.managed(path, out var assname))
                            yield return new FS.ManagedExe(path, assname);
                        else
                            yield return new FS.NativeExe(path);
                   }
                   else if(path.Is(Lib))
                        yield return new FS.NativeLib(path);
                }
            }
        }
    }
}