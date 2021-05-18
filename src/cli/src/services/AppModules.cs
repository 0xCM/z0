//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public class AppModules : AppService<AppModules>
    {
        public PdbSymbolSource SymbolSource(FileModule src)
        {
            try
            {
                var pdb = src.Path.ChangeExtension(FS.Pdb);
                return PdbServices.source(src.Path, pdb);
            }
            catch(Exception e)
            {
                Wf.Error(e);
                return PdbSymbolSource.Empty;
            }
        }

        public PdbSymbolSource SymbolSource(FS.FilePath module)
            => PdbServices.source(module);

        public ModuleArchive Archive()
            => ModuleArchive.create(FS.path(root.controller().Location).FolderPath);
    }
}