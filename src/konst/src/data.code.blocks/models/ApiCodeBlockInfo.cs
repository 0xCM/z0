//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential), Table(TableId, FieldCount)]
    public struct ApiCodeBlockInfo
    {
        public const string FormatPattern = "{0,-12} | {1,-32} | {2,-16} | {3,-10} | {4}";

        public const string TableId = nameof(ApiCodeBlockInfo);

        public const byte FieldCount = 5;

        public ApiPartKind Part;

        public Name Host;

        public MemoryAddress Base;

        public ByteSize Size;

        public ApiUri<string> Uri;
    }
}