//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Flow;
    
    using static EmitParsedReportStep;
    
    [Step]
    public readonly ref struct EmitParsedReport
    {
        readonly WfState Wf ;        

        readonly CorrelationToken Ct;

        readonly ApiHostUri Host;

        readonly ParsedExtraction[] Source;

        readonly FilePath Target;
        
        [MethodImpl(Inline)]
        internal EmitParsedReport(WfState wf, ApiHostUri host, ParsedExtraction[] src, FilePath dst, CorrelationToken ct)
        {
            Wf = wf;
            Ct = ct;
            Host = host;
            Source = src;
            Target = dst;
            Wf.Created(WorkerName, Ct);
        }

        public void Run()
        {
            try
            {
                Wf.Running(WorkerName, Host, Ct);
                var report = MemberParseReport.Create(Host, Source);                    
                report.Save(Target);                
                Wf.Ran(WorkerName, text.format(PSx2, Host, report.RecordCount), Ct);
            }
            catch(Exception e)
            {
                Wf.Error(WorkerName, e, Ct);
            }
        }

        public void Dispose()
        {
            Wf.Finished(WorkerName, Ct);
        }
    }
}