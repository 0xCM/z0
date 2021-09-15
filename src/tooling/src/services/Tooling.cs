//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    using SQ = SymbolicQuery;
    using SR = SymbolicRender;

    [ApiHost]
    public readonly partial struct Tooling
    {
        const NumericKind Closure = UnsignedInts;

        [MethodImpl(Inline), Op]
        public static Toolset toolset(FS.FolderPath @base, ToolId[] members)
            => new Toolset(@base, members);

        public static ReadOnlySpan<CmdFlagSpec> flags(FS.FilePath src)
        {
            var k = z16;
            var dst = list<CmdFlagSpec>();
            using var reader = src.AsciLineReader();
            while(reader.Next(out var line))
            {
                var content = line.Content;
                var i = SQ.index(content, AsciCode.Colon);
                var name = SR.format(SQ.left(content,i)).Trim();
                var desc = SR.format(SQ.right(content,i)).Trim();
                var flag = Cmd.flagspec(k++, name, desc);
                dst.Add(flag);
            }
            return dst.ViewDeposited();
        }

        public static FS.FilePath enqueue<T>(CmdJob<T> job, IWfDb db)
            where T : struct, ITextual
        {
            var dst = db.JobQueue() + FS.file(job.Name.Format(), FS.Cmd);
            dst.Overwrite(job.Format());
            return dst;
        }
    }
}