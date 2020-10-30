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
            dst.Parts = builder.Wf.Api.PartIdentities;
            dst.Target = ApiSummaries.target(builder.Db);
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
        protected override CmdResult Execute(IWfShell wf, in EmitApiSummariesCmd spec)
        {
            var data = ApiSummaries.parts(wf, spec.Parts);
            wf.EmittingTable(typeof(ApiSummaryInfo), spec.Target);
            ApiSummaries.emit(data,spec.Target);
            wf.EmittedTable(typeof(ApiSummaryInfo), data.Length, spec.Target);
            return Win();
        }
    }
}