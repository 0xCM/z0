//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static Konst;
    using static z;

    [ApiHost]
    public readonly struct ImageArchives
    {
        public static ImageArchive create(IWfShell wf, ImageFormatKind kind)
        {
            var db = wf.Db();
            if(kind == ImageFormatKind.Csv)
                create(db.TableRoot<ImageContentRecord>(), kind);
            else if(kind == ImageFormatKind.Binary)
                return default;

            return create(db.TableRoot(kind.ToString()), kind);
        }

        [Op]
        public static ImageArchive create(FS.FolderPath root, ImageFormatKind kind)
            => new ImageArchive(root, kind);

        [Op]
        public static ListedFiles react(IWfShell wf, ListImageFilesCmd cmd)
            => create(cmd.ArchiveRoot, (ImageFormatKind)cmd.ArchiveKind).List();
    }
}