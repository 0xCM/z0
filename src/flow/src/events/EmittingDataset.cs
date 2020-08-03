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
    using static EmittingDatasetEvent;

    [Event(true)]
    public readonly struct EmittingDatasetEvent
    {
        public const string EventName = nameof(EmittingDataset);

        /// <summary>
        /// Defines the literal "{0} | {1} | {2} | {3}"
        /// </summary>
        public const string Pattern = IdMarker + PS1x3;
    }

    [Event]
    public readonly struct EmittingDataset : IWfEvent<EmittingDataset>
    {        
        public WfEventId Id {get;}
        
        public string WorkerName {get;}

        public string DatasetName {get;}

        public readonly string TargetPath;

        [MethodImpl(Inline)]
        public EmittingDataset(string worker, string dsname, FilePath target, CorrelationToken ct)
        {
            WorkerName = worker;
            Id = wfid(EventName,ct);
            DatasetName = dsname;
            TargetPath = target.Name;
        }        

        [MethodImpl(Inline)]
        public EmittingDataset(string worker, string dsname, FolderPath target, CorrelationToken ct)
        {
            WorkerName = worker;
            Id = wfid(EventName,ct);
            DatasetName = dsname;
            TargetPath = target.Name;
        }        
        public string Format()
            => text.format(Pattern, Id, WorkerName, DatasetName, TargetPath);               
    }
}