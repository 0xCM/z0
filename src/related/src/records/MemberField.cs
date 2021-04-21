//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct Images
    {
        [Record(TableId), StructLayout(LayoutKind.Sequential)]
        public struct MemberField : IRecord<MemberField>
        {
            public const byte FieldCount = 7;

            public const string TableId = "image.fields";

            public Count Sequence;

            public BinaryCode Sig;

            public ByteSize HeapSize;

            public Count Length;

            public Address32 Offset;

            public string Value;

            public string Attribs;

            [MethodImpl(Inline)]
            public MemberField(Count seq, MemberFieldName name, MetadataBlob sig, string attribs)
            {
                Sequence = seq;
                Sig = sig.Data;
                HeapSize = name.HeapSize;
                Length = name.Length;
                Offset = name.Offset;
                Value = name.Value;
                Sig = sig.Data;
                Attribs = attribs;
            }
        }
    }
}