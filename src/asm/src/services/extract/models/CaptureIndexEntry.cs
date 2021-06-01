//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    [Record(TableId)]
    public struct CaptureIndexEntry : IRecord<CaptureIndexEntry>
    {
        public const string TableId = "capture.index";

        public const byte FieldCount = 5;

        public uint Sequence;

        public MemoryAddress BaseAddress;

        public ApiHostUri Host;

        public string DisplaySig;

        public OpUri Uri;

        public static ReadOnlySpan<byte> RenderWidths => new byte[FieldCount]{12,16,24,120,40};
    }
}