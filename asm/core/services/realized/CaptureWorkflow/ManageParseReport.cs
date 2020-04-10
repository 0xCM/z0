//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;

    using static Seed;
    using static Memories;

    partial class HostCaptureSteps
    {
        public readonly struct ManageParseReport
        {
            readonly HostCaptureContext Context;

            [MethodImpl(Inline)]
            internal static ManageParseReport Create(HostCaptureContext context)
                => new ManageParseReport(context);

            [MethodImpl(Inline)]
            ManageParseReport(HostCaptureContext context)
            {
                this.Context = context;
            }

            public void SaveReport(MemberParseReport src, FilePath dst)
            {
                var context = Context;
                src.Save(dst)
                    .OnSome(f => context.Raise(ExtractReportSaved.Define(src.ApiHost, src.GetType(), src.RecordCount, f)));
            }

            public MemberParseReport CreateReport(in ApiHost host, ParsedExtract[] src)
            {
                var report = MemberParseReport.Create(host,src);                    
                Context.Raise(report.CreatedEvent());
                return report;
            }

        }
    }
}