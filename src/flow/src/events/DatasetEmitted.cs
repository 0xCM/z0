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

    public readonly struct DatasetEmitted : IWfEvent<DatasetEmitted>
    {        
        const string Pattern = IdMarker + "Emitted {1} {2} records to {3}";

        public WfEventId Id {get;}

        public readonly StringRef DataType;

        public readonly uint RecordCount;

        public readonly FilePath TargetPath;

        [MethodImpl(Inline)]
        public DatasetEmitted(WfEventId id, string type, uint count, FilePath target)
        {
            Id = id;
            DataType = type;
            RecordCount = count;
            TargetPath = target;
        }        

        public string Format()
            => text.format(Pattern, Id, RecordCount, DataType, TargetPath);
        
        public override string ToString()
            => Format();
    }
}