//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Konst;

    public enum BinaryResField : uint
    {
        Offset = 0 | (8 << WidthOffset),

        Address = 1 | (16 << WidthOffset),

        Size = 2 | (10 << WidthOffset),

        Uri = 3 | (40 << WidthOffset),

        Data = 4 | 1 << WidthOffset,
    }

    public struct BinaryResRow
    {
        public static TableFieldKind<BinaryResField> FieldKind => default;

        public Address16 Offset;

        public MemoryAddress Address;

        public ByteSize Size;

        public string Uri;

        public BinaryCode Data;
    }
}