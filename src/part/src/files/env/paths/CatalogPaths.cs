//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{

    using static EnvFolders;

    partial interface IEnvPaths
    {
        FS.FolderPath CatalogRoot()
            => DbRoot() + FS.folder(catalogs);

        FS.FolderPath AsmCatalogRoot()
            => CatalogRoot() + FS.folder(asm);

        FS.FolderPath CatalogDir(Identifier id)
            => CatalogRoot() + FS.folder(id.Format());

        FS.FilePath CatalogTable(Identifier catalog, TableId table)
            => CatalogDir(catalog) + FS.file(table.Format(), FS.Csv);

        FS.FilePath CatalogTable<T>(Identifier catalog)
            where T : struct, IRecord<T>
                => CatalogTable(catalog,  Z0.TableId.identify<T>());

        FS.FilePath AsmCatalogTable<T>()
            where T : struct, IRecord<T>
                => AsmCatalogRoot() + FS.file(TableId<T>(), FS.Csv);
    }
}