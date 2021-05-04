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

        FS.FolderPath CatalogDir(Identifier id, Identifier subject)
            => CatalogRoot() + FS.folder(id.Format()) + FS.folder(subject.Format());

        FS.FilePath CatalogTable(Identifier catalog, TableId table)
            => CatalogDir(catalog) + FS.file(table.Format(), FS.Csv);

        FS.FilePath CatalogTable(Identifier catalog, TableId table, Identifier subject)
            => CatalogDir(catalog,subject) + FS.file(table.Format(), FS.Csv);

        FS.FilePath CatalogTable<T>(Identifier catalog)
            where T : struct, IRecord<T>
                => CatalogTable(catalog, Z0.TableId.identify<T>());

        FS.FilePath CatalogTable<T>(Identifier catalog, Identifier subject)
            where T : struct, IRecord<T>
                => CatalogTable(catalog, Z0.TableId.identify<T>(), subject);

        FS.FilePath AsmCatalogTable<T>()
            where T : struct, IRecord<T>
                => AsmCatalogRoot() + FS.file(TableId<T>(), FS.Csv);

        FS.FilePath AsmCatalogTable<T>(string subject)
            where T : struct, IRecord<T>
                => AsmCatalogRoot() + FS.folder(subject) + FS.file(TableId<T>(), FS.Csv);

        FS.FilePath AsmCatalogPath<T>(T subject, FS.FileName name)
            => AsmCatalogRoot() + FS.folder(subject.ToString()) + name;
    }
}