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
        /// <summary>
        /// Creates an archive that contains csv-formatted image files
        /// </summary>
        /// <param name="wf">The workflow source</param>
        public static ImageArchive csv(IWfShell wf)
            => new ImageArchive(wf.Db().TableRoot<ImageContentRecord>(), ImageFormatKind.Csv);

        /// <summary>
        /// Creates an archive that contains build image artifacts
        /// </summary>
        /// <param name="wf">The workflow source</param>
        public static ImageArchive build(IWfShell wf)
            => new ImageArchive(wf.Db().BuildArchiveRoot(), ImageFormatKind.Binary);

        [Op]
        public static ImageArchive create(FS.FolderPath root, ImageFormatKind kind)
            => new ImageArchive(root, kind);

        [Op]
        public static ListedFiles react(IWfShell wf, PipeImageFilesCmd cmd)
            => create(cmd.ArchiveRoot, (ImageFormatKind)cmd.ArchiveKind).List();
    }
}