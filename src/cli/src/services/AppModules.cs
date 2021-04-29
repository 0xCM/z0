//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Part;
    using static memory;
    using static AppSymbolics;

    public class AppModules : AppService<AppModules>
    {
        public SymbolSource SymbolSource(FileModule src)
        {
            try
            {
                var pdb = src.Path.ChangeExtension(FS.Pdb);
                return AppSymbolics.source(src.Path, pdb);
            }
            catch(Exception e)
            {
                Wf.Error(e);
                return AppSymbolics.SymbolSource.Empty;
            }
        }

        public SymbolSource SymbolSource(FS.FilePath module)
            => AppSymbolics.source(module);

        public ModuleArchive Archive()
            => ModuleArchive.create(FS.path(root.controller().Location).FolderPath);
    }
}