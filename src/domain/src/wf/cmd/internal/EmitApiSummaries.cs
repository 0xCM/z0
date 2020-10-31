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

    public sealed class EmitApiSummaries : CmdHost<EmitApiSummaries, EmitApiSummariesCmd>
    {
        public static CmdResult exec(IWfShell wf, in EmitApiSummariesCmd spec)
        {
            var db = wf.Db();
            var hosts = @readonly(wf.Api.ApiHosts);
            var kHost = hosts.Length;
            var summaries = list<ApiSummaryInfo>();
            var stats = 0u;
            for(var i=0; i<kHost; i++)
            {
                var catalog = ApiCatalogs.members(skip(hosts,i));
                if(catalog.IsNonEmpty)
                {
                    var members = @readonly(catalog.Members.Storage);
                    var apicount = (uint)members.Length;

                    for(var j=0; j<apicount; j++)
                    {
                        ref readonly var member = ref skip(members,j);
                        try
                        {
                            var method = member.Method;
                            var summary = new ApiSummaryInfo();
                            summary.Address = member.Address;
                            summary.Uri = member.MetaUri;
                            summary.Genericity = method.GenericState();
                            summary.Sig = ClrSigs.resolve(method);
                            summary.Metadata = member.Method.Metadata();
                            summaries.Add(summary);

                        }
                        catch(Exception e)
                        {
                            wf.Error(e);
                        }
                    }

                    stats += apicount;

                    wf.Status(string.Format("{2} | {0} | {1} | Api summary accumulation", apicount, catalog.Host, stats));
                }
            }

            var dst = target(db, ApiSummaryInfo.TableId);
            var flow = wf.EmittingTable(typeof(ApiSummaryInfo), dst);
            var records = summaries.ToArray();
            emit(records, dst);
            wf.EmittedTable(typeof(ApiSummaryInfo), records.Length, dst);
            return Win();
       }

        [MethodImpl(Inline), Op]
        public static FS.FilePath target(IFileDb db, string id)
            => db.IndexFile(id);

        [Op]
        static void emit(ReadOnlySpan<ApiSummaryInfo> src, FS.FilePath dst)
        {
            var count = src.Length;
            using var writer = dst.Writer();
            for(var i=0; i<count; i++)
                writer.WriteLine(ApiSummaryReport.format(skip(src,i)));
        }

        protected override CmdResult Execute(IWfShell wf, in EmitApiSummariesCmd spec)
            => exec(wf, spec);
    }
}