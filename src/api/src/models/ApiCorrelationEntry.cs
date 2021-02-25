//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static Sequential;

    [Record(TableId)]
    public struct ApiCorrelationEntry : IRecord<ApiCorrelationEntry>
    {
        public const string TableId = "api.correlations";

        public Seq16x2 Sequence;

        public MemoryAddress CaptureAddress;

        public MemoryAddress RuntimeAddress;

        public OpUri Id;
    }
}