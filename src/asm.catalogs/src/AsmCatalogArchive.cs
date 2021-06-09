//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct AsmCatalogArchive : IFileArchive
    {
        public FS.FolderPath Root {get;}

        string TableId<T>()
            where T : struct, IRecord<T>
                => Z0.TableId.identify<T>().Identifier.Format();

        [MethodImpl(Inline)]
        public AsmCatalogArchive(FS.FolderPath root)
        {
            Root = root;
        }

        public FS.FolderPath XedCatalogRoot()
            => Root + FS.folder("xed");

        public FS.FilePath XedFormDetailPath()
            => XedCatalogRoot() + FS.file("xed.forms.details", FS.Csv);

        public FS.FilePath XedSymIndexPath()
            => XedCatalogRoot() + FS.file("xed.symbols", FS.Csv);

        public FS.FilePath AsmCatalogTable<T>(string subject)
            where T : struct, IRecord<T>
                => Root + FS.folder(subject) + FS.file(TableId<T>(), FS.Csv);

        public FS.FilePath XedFormAspectPath()
            => AsmCatalogTable<XedFormAspect>("xed");
    }
}