//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential, Pack=1), Record(TableId)]
    public struct ApiLiteralSpec : IRecord<ApiLiteralSpec>
    {
        public const string TableId = "api.literals";

        public const byte FieldCount = 4;

        public string Source;

        public string Name;

        public string Kind;

        public ApiLiteralValue Value;

        public static ReadOnlySpan<byte> RenderWidths => new byte[FieldCount]{16,16,12,1};
    }
}