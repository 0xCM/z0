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
    public readonly struct EmittingDataset : IWfEvent<EmittingDataset>
    {        
        public const string EventName = nameof(EmittingDataset);

        public WfEventId EventId {get;}
        
        public string ActorName {get;}

        public string DatasetName {get;}

        public string TargetPath {get;}

        [MethodImpl(Inline)]
        public EmittingDataset(string worker, string dsname, FilePath target, CorrelationToken ct)
        {
            ActorName = worker;
            EventId = wfid(EventName,ct);
            DatasetName = dsname;
            TargetPath = target.Name;        }        

        [MethodImpl(Inline)]
        public EmittingDataset(string worker, string dsname, FolderPath target, CorrelationToken ct)
        {
            ActorName = worker;
            EventId = wfid(EventName,ct);
            DatasetName = dsname;
            TargetPath = target.Name;
        }        
        public string Format()
            => text.format(PSx4, EventId, ActorName, DatasetName, TargetPath);               
    }
}