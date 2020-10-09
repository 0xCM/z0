//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;
    using api = Table;

    [ApiHost]
    public readonly struct DbArchives
    {
        [MethodImpl(Inline), Op]
        public static ITableArchive tables<S>(IWfShell wf, S subject)
            => new DbTableArchive<S>(wf.Db(), subject);

        [MethodImpl(Inline), Op]
        public static FS.FolderPath tableRoot(FS.FolderPath root)
            => root + FS.folder("tables");

        [MethodImpl(Inline), Op]
        public static FS.FolderPath docRoot(FS.FolderPath root)
            => root + FS.folder("docs");

        [MethodImpl(Inline), Op]
        public static FS.FilePath table<D>(FS.FolderPath root, string id, D subject, string type = null)
            => tableRoot(root) + FS.folder(id) + FS.file(text.format("{0}.{1}", id, subject), type ?? ArchiveExt.Csv.Name);

        [MethodImpl(Inline), Op]
        public static FS.FilePath table(FS.FolderPath root, FS.FileName file)
            => tableRoot(root) + file;

        [MethodImpl(Inline), Op]
        public static FS.FilePath table(FS.FolderPath root, string id, PartId part, string type = null)
            => tableRoot(root) +  FS.folder(id) + FS.file(string.Format(RP.SlotDot2, id, part.Format()), type ?? FileKind.Csv.Name);

        public static Option<FilePath> deposit<F,R,S>(FS.FolderPath root, R[] src, string id, S subject, FS.FileExt type)
            where F : unmanaged, Enum
            where R : struct, ITabular
                => api.store<F,R>().Save(src, api.renderspec<F>(), (FS.dir(root.Name) + FS.folder(id) + FS.file($"{id}.{subject}",type)));
    }
}
