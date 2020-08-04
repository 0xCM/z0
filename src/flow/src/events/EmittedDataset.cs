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
    
    [Event]
    public readonly struct EmittedDataset : IWfEvent<EmittedDataset>
    {                
        public const string EventName = nameof(EmittedDataset);

        public WfEventId Id {get;}

        public string ActorName {get;}

        public string DatasetName {get;}

        public readonly uint RecordCount;

        public readonly FilePath TargetPath;

        [MethodImpl(Inline)]
        public EmittedDataset(string worker, string dsname, uint count, FilePath target, CorrelationToken ct)
        {
            Id = wfid(EventName, ct);
            ActorName = worker;
            DatasetName = dsname;
            RecordCount = count;
            TargetPath = target;
        }        

        public string Format()
            => text.format(PSx5, Id, ActorName, DatasetName, RecordCount, TargetPath);
        
        public override string ToString()
            => Format();
    }
}