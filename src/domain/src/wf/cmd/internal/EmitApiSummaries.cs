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

    partial class XCmdFactory
    {
        [MethodImpl(Inline), Op]
        public static EmitApiSummariesCmd EmitApiSummaries(this CmdBuilder builder)
        {
            var dst = new EmitApiSummariesCmd();

            return dst;
        }
    }

    [Cmd(Code)]
    public struct EmitApiSummariesCmd : ICmdSpec<EmitApiSummariesCmd>
    {
        public const string Code = CmdCodes.EmitApiSummaries;

        public PartId[] Parts;

        public FS.FilePath Target;
    }

    public readonly struct EmitApiSummaries
    {
        public static EmitApiSummaries create()
            => default;

       [MethodImpl(Inline), Op]
        public static FS.FilePath target(IFileDb db, string id)
            => db.IndexFile(id);

        [Op]
        static void emit(ReadOnlySpan<ApiRuntimeSummary> src, FS.FilePath dst)
        {
            var count = src.Length;
            using var writer = dst.Writer();
            for(var i=0; i<count; i++)
                writer.WriteLine(ApiSummaryReport.format(skip(src,i)));
        }

            // var dst = target(db, ApiSummaryInfo.TableId);
            // var flow = wf.EmittingTable(typeof(ApiSummaryInfo), dst);
            // var records = buffer.ToArray();
            // emit(records, dst);
            // wf.EmittedTable(typeof(ApiSummaryInfo), records.Length, dst);
            // return Win();

    }

}