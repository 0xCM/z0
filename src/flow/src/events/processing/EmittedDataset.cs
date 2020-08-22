//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static RenderPatterns;
    
    [Event]
    public readonly struct EmittedDataset : IWfEvent<EmittedDataset>
    {                
        public const string EventName = nameof(EmittedDataset);

        public WfEventId EventId {get;}

        public string ActorName {get;}

        public string DatasetName {get;}

        public readonly uint RecordCount;

        public readonly FilePath TargetPath;

        [MethodImpl(Inline)]
        public EmittedDataset(string actor, string dataset, uint count, FilePath target, CorrelationToken ct)
        {
            EventId = z.evid(EventName, ct);
            ActorName = actor;
            DatasetName = dataset;
            RecordCount = count;
            TargetPath = target;
        }        

        public string Format()
            => text.format(PSx5, EventId, ActorName, DatasetName, RecordCount, TargetPath);
        
        public override string ToString()
            => Format();
    }
}