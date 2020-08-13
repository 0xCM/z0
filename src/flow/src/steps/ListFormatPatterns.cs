//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using api = Flow;

    public ref struct ListFormatPatterns
    {
        readonly IWfContext Wf;

        public readonly WfStepId Id;
        
        public readonly WfActor Actor;

        public readonly Type Source;
    
        public ListFormatPatterns(IWfContext wf, Type src, [CallerMemberName] string caller = null)
        {
            Wf = wf;
            Id = Flow.step(WfStepKind.ListFormatPatterns, src);   
            Actor = caller;
            Source = src;
            Wf.Created(Actor);
        }

        public void Run()
        {
            Wf.Running(Actor, Id, Ct);

            try
            {
                var patterns = api.patterns(Source);
                foreach(var pattern in patterns.Data)
                    Wf.Status(Actor, pattern.Description, Ct);
            
            }
            catch(Exception e)
            {
                Wf.Error(Actor, e, Ct);
            }
            
            Wf.Ran(Actor, Id, Ct);
        }

        public void Dispose()
        {
            Wf.Finished(Actor, Ct);
        }

        CorrelationToken Ct => Wf.Ct;
    }
}