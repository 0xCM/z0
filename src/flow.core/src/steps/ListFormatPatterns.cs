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
        public const WfStepKind Kind = WfStepKind.ListFormatPatterns;
            
        readonly IWfContext Wf;

        public readonly WfStepId Id;
        
        public readonly WfActor Actor;

        public readonly Type PatternSource;
    
        public ListFormatPatterns(IWfContext wf, Type src, [CallerMemberName] string caller = null)
        {
            Wf = wf;
            Id = api.step(Kind, typeof(ListFormatPatterns));   
            Actor = caller;
            PatternSource = src;
            Wf.Created(Actor);
        }

        public void Run()
        {
            Wf.Running(Actor, Id, Ct);

            try
            {
                var patterns = Render.patterns(PatternSource);
                foreach(var pattern in patterns.View)
                    Wf.Status(Actor, pattern.Format(), Ct);
            
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

        CorrelationToken Ct 
            => Wf.Ct;
    }
}