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
    public struct CliField
    {
        public const byte FieldCount = 7;

        public static ReadOnlySpan<byte> RenderWidths
            => new byte[FieldCount]{16,60,12,12,16,40,30};

        public const string TableId = "cli.fields";

        public Count Sequence;

        public BinaryCode Sig;

        public ByteSize HeapSize;

        public Count Length;

        public Address32 Offset;

        public string Value;

        public string Attribs;

        [MethodImpl(Inline)]
        public CliField(Count seq, CliLiteral field, CliBlob sig, string attribs)
        {
            Sequence = seq;
            Sig = sig.Data;
            HeapSize = field.HeapSize;
            Length = field.Length;
            Offset = field.Offset;
            Value = field.Value;
            Sig = sig.Data;
            Attribs = attribs;
        }
    }
}