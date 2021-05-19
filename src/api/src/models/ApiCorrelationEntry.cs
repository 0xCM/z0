//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.InteropServices;

    using static Sequential;

    [Record(TableId), StructLayout(LayoutKind.Sequential)]
    public struct ApiCorrelationEntry : IRecord<ApiCorrelationEntry>
    {
        public const string TableId = "api.correlations";

        public Seq16x2 Sequence;

        public MemoryAddress CaptureAddress;

        public MemoryAddress RuntimeAddress;

        public OpUri Id;
    }
}