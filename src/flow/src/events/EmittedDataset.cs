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
    using static EmittedDatasetEvent;

    [Event(true)]
    public readonly struct EmittedDatasetEvent
    {
        public const string EventName = nameof(EmittedDataset);

        /// <summary>
        /// Defines the literal "{0} | {1} | {2} | {3} | {4}"
        /// </summary>
        public const string Pattern = IdMarker + PS1x4;
    }
    
    [Event]
    public readonly struct EmittedDataset : IWfEvent<EmittedDataset>
    {                
        public WfEventId Id {get;}

        public string WorkerName {get;}

        public string DatasetName {get;}

        public readonly uint RecordCount;

        public readonly FilePath TargetPath;

        [MethodImpl(Inline)]
        public EmittedDataset(string worker, string dsname, uint count, FilePath target, CorrelationToken ct)
        {
            Id = wfid(EventName, ct);
            WorkerName = worker;
            DatasetName = dsname;
            RecordCount = count;
            TargetPath = target;
        }        

        public string Format()
            => text.format(Pattern, Id, WorkerName, DatasetName, RecordCount, TargetPath);
        
        public override string ToString()
            => Format();
    }
}