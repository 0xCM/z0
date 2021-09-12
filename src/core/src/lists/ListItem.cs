//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    [Record(TableId)]
    public struct ListItem : IRecord<ListItem>
    {
        public const string TableId = "listitems";

        public const byte FieldCount = 3;

        public uint Id;

        public Identifier Type;

        public TextBlock Value;

        public static ReadOnlySpan<byte> RenderWidths
            => new byte[FieldCount]{12,42,2};
    }
}