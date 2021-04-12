//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static EnvFolders;

    partial interface IEnvPaths
    {
        FS.FolderPath CatalogRoot()
            => DbRoot() + FS.folder(catalogs);

        FS.FolderPath CatalogDir(Identifier id)
            => CatalogRoot() + FS.folder(id.Format());

        FS.FilePath CatalogTable(Identifier catalog, TableId table)
            => CatalogDir(catalog) + FS.file(table.Format(), FS.Csv);

        FS.FilePath CatalogTable<T>(Identifier catalog)
            where T : struct, IRecord<T>
                => CatalogTable(catalog, Tables.tableid<T>());

        FS.FilePath CatalogDoc(Identifier catalog, FS.FileName file)
            => CatalogDir(catalog) + file;
    }
}