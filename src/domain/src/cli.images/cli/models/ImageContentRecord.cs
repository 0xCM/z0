//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;
    using System.Runtime.CompilerServices;

    using static Konst;

    [StructLayout(LayoutKind.Sequential), Table(TableId, FieldCount)]
    public struct ImageContentRecord
    {
        public const string TableId = "image.content";

        public const byte FieldCount = 2;

        public const byte RowDataSize = 32;

        public ImageToken Source;

        public BinaryCode Data;
    }
}