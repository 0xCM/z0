//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Flow;

    public readonly struct WorkflowError : IWfEvent<WorkflowError>
    {
        public const string EventName = nameof(WorkflowError);
        
        public WfEventId Id {get;}

        public string ActorName {get;}
        
        public string Description {get;}        

        [MethodImpl(Inline)]
        public WorkflowError(string worker, string description, Exception e, CorrelationToken ct)
        {
            Id = wfid(EventName, ct);
            ActorName = worker;
            Description = $"{description}{e}";
        }

        [MethodImpl(Inline)]
        public WorkflowError(string worker, Exception e, CorrelationToken ct)
        {
            Id = wfid(EventName, ct);
            ActorName = worker;
            Description = $"{e}";
        }

        public string Format()
            => Description;    
    }
}