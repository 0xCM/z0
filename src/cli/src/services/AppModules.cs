//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static PdbServices;

    public class AppModules : AppService<AppModules>
    {
        public SymbolSource SymbolSource(FileModule src)
        {
            try
            {
                var pdb = src.Path.ChangeExtension(FS.Pdb);
                return PdbServices.source(src.Path, pdb);
            }
            catch(Exception e)
            {
                Wf.Error(e);
                return PdbServices.SymbolSource.Empty;
            }
        }

        public SymbolSource SymbolSource(FS.FilePath module)
            => PdbServices.source(module);

        public ModuleArchive Archive()
            => ModuleArchive.create(FS.path(root.controller().Location).FolderPath);
    }
}