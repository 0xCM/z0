//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    [Record(TableId)]
    public struct ListItemRecord : IRecord<ListItemRecord>
    {
        public const string TableId = "listitems";

        public const byte FieldCount = 3;

        public Identifier ListName;

        public uint Index;

        public TextBlock Value;

        public static ReadOnlySpan<byte> RenderWidths => new byte[FieldCount]{42,12,2};
    }
}