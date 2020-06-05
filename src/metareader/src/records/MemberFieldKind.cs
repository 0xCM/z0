//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static MetadataRecords.MemberFieldField;

    partial struct MetaRecordKinds
    {
        public readonly struct FieldRecord  : IMetaRecordKind<FieldRecord>
        {
            [MethodImpl(Inline)]
            public static implicit operator MetaRecordKind(FieldRecord src)
                => src.RecordType;

            public MetaRecordKind RecordType => MetaRecordKind.Field;            


            public byte FieldCount => (byte)RecordFieldCount;
            
            public ReadOnlySpan<string> HeaderFields 
                => new string[(int)RecordFieldCount]{
                    nameof(Sequence), 
                    nameof(Rva), 
                    nameof(Offset), 
                    nameof(Name), 
                    nameof(Signature),
                    nameof(Attributes),
                    nameof(Marshalling),
                    };

            public ReadOnlySpan<byte> FieldWidths 
                => new byte[(int)RecordFieldCount]{12, 12, 12, 30, 30, 10, 10,};

            public string HeaderText
            {
                [MethodImpl(Inline)]
                get => MetaFormat.FormatHeader(HeaderFields, FieldWidths);
            }

        }
    }
}