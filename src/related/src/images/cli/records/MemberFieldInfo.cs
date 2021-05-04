//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;

    partial struct ImageRecords
    {
        [Record(TableId), StructLayout(LayoutKind.Sequential)]
        public struct MemberFieldInfo : IRecord<MemberFieldInfo>
        {
            public const byte FieldCount = 4;

            public const string TableId = "image.fields";

            public CliToken Token;

            public Name FieldName;

            public string Attribs;

            public BinaryCode Sig;

            public static ReadOnlySpan<byte> RenderWidths
                => new byte[FieldCount]{10,48,24,64};
        }
    }
}