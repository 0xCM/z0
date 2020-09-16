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

    [StructLayout(LayoutKind.Sequential), Table(TableName)]
    public struct ImageFieldTable
    {
        public const string TableName = "image.fields";

        public Count Sequence;

        public BinaryCode Sig;

        public ByteSize HeapSize;

        public Count Length;

        public Address32 Offset;

        public string Value;

        public string Attribs;

        [MethodImpl(Inline)]
        public ImageFieldTable(Count seq, ImageLiteralFieldTable field, ImageBlob sig, string attribs)
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