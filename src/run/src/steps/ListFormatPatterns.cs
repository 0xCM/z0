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
        
        public readonly string ActorName;

        public readonly Type Source;
    
        public ListFormatPatterns(WfState wf, Type src, [CallerMemberName] string caller = null)
        {
            Wf = wf;
            Id = Flow.step(WfStepKind.AnalyzeCalls, src);   
            ActorName = caller;
            Source = src;
            Wf.Created(ActorName, Ct);
        }

        public void Run()
        {
            Wf.Running(ActorName, Id, Ct);

            try
            {
                var patterns = DataFlow.patterns(Source);
                foreach(var pattern in patterns.Data)
                    Wf.Status(ActorName, pattern.Description, Ct);
            
            }
            catch(Exception e)
            {
                Wf.Error(ActorName, e,Ct);
            }
            
            Wf.Ran(ActorName, Id, Ct);
        }

        public void Dispose()
        {
            Wf.Finished(ActorName, Ct);
        }

        CorrelationToken Ct => Wf.Ct;

    }
}