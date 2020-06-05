//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    using static MetadataRecords.StringValueField;

    partial struct MetaRecordKinds
    {
        public readonly struct StringRecord : IMetaRecordKind<StringRecord>
        {
            [MethodImpl(Inline)]
            public static implicit operator MetaRecordKind(StringRecord src)
                => src.RecordType;
            
            public MetaRecordKind RecordType => MetaRecordKind.String;

            public byte FieldCount => (byte)RecordFieldCount;
            
            public ReadOnlySpan<string> HeaderFields 
                => new string[(int)RecordFieldCount]{
                    nameof(Sequence), 
                    nameof(HeapSize), 
                    nameof(Length), 
                    nameof(Offset), 
                    nameof(Value)
                    };

            public ReadOnlySpan<byte> FieldWidths 
                => new byte[(int)RecordFieldCount]{12, 12, 12, 12, 12};            

            public string HeaderText
            {
                [MethodImpl(Inline)]
                get => MetaFormat.FormatHeader(HeaderFields, FieldWidths);
            }
        }
    }
}