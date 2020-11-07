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

    partial struct Cmd
    {
        public static FS.FilePath enqueue<T>(CmdJob<T> job, IFileDb db)
            where T : struct, ITextual
        {
            var dst = db.JobQueue() + FS.file(job.Name.Format(), ArchiveFileKinds.Cmd);
            dst.Overwrite(job.Format());
            return dst;
        }
    }
}