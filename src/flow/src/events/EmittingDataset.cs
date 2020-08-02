//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct EmittingDataset : IWfEvent<EmittingDataset>
    {
        const string EventName = nameof(EmittingDataset) + "{0}";
        
        const string Pattern = "{0}: Emitting {1} dataset to {2}";

        public WfEventId Id {get;}

        public readonly StringRef DataType;

        public readonly string TargetPath;

        [MethodImpl(Inline)]
        public EmittingDataset(WfEventId id, string type, FilePath target)
        {
            Id = id;
            DataType = type;
            TargetPath = target.Name;
        }        

        [MethodImpl(Inline)]
        public EmittingDataset(WfEventId id, string type, FolderPath target)
        {
            Id = id;
            DataType = type;
            TargetPath = target.Name;
        }        

        public string Format()
            => text.format(Pattern, Id, DataType, TargetPath);
        
        public override string ToString()
            => Format();
    }
}