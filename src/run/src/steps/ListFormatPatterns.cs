//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using Z0.Asm;

    using static Konst;

    public ref struct ListFormatPatterns
    {
        readonly WfState Wf;

        public readonly WfStepId Id;
        
        public readonly string Caller;

        public readonly Type Source;
    
        public ListFormatPatterns(WfState wf, Type src, [CallerMemberName] string caller = null)
        {
            Wf = wf;
            Id = Flow.step(WfStepKind.AnalyzeCalls, src);   
            Caller = caller;
            Source = src;
            Wf.Created(Caller, Ct);
        }

        public void Run()
        {
            Wf.Running(Caller, Id, Ct);

            try
            {
                var patterns = DataFlow.patterns(Source);
                foreach(var pattern in patterns.Data)
                    Wf.Status(Caller, pattern.Description, Ct);
            
            }
            catch(Exception e)
            {
                Wf.Error(Caller, e,Ct);
            }
            
            Wf.Ran(Caller, Id, Ct);
        }

        public void Dispose()
        {
            Wf.Finished(Caller, Ct);
        }

        CorrelationToken Ct => Wf.Ct;

    }
}