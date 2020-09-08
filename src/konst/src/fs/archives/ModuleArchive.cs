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

    using static FS.Extensions;

    public readonly struct ModuleArchive
    {
        public readonly FS.FolderPath Root;

        [MethodImpl(Inline)]
        public ModuleArchive(FS.FolderPath root)
        {
            Root = root;
        }

        public IEnumerable<FS.FileModule> Members
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