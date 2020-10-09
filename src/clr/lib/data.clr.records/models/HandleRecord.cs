//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;
    using System.Reflection;

    using static Konst;

    partial struct ClrRecords
    {
        [StructLayout(LayoutKind.Sequential), Table(TableId, FieldCount)]
        public struct HandleRecord
        {
            public const byte FieldCount = 3;

            public static ReadOnlySpan<byte> RenderWidths
                => new byte[FieldCount]{16, 16, 16};

            public const string TableId = "clr.handles";

            public ClrArtifactKind Kind;

            public ClrArtifactKey Key;

            public MemoryAddress Address;
        }
    }
}