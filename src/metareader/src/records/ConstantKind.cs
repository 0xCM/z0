//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static MetadataRecords.ConstantField;

    partial struct MetaRecordKinds
    {
        public readonly struct ConstantValueRecord  : IMetaRecordKind<ConstantValueRecord>
        {
            [MethodImpl(Inline)]
            public static implicit operator MetaRecordKind(ConstantValueRecord src)
                => src.RecordType;

            public MetaRecordKind RecordType => MetaRecordKind.Constant;            

            public byte FieldCount => (byte)RecordFieldCount;
            
            public ReadOnlySpan<string> HeaderFields 
                => new string[(int)RecordFieldCount]{
                    nameof(Sequence), 
                    nameof(Parent), 
                    nameof(DataType), 
                    nameof(Value),                     
                    };

            public ReadOnlySpan<byte> FieldWidths 
                => new byte[(int)RecordFieldCount]{20,20,20,20};

            public string HeaderText
            {
                [MethodImpl(Inline)]
                get => MetaFormat.FormatHeader(HeaderFields, FieldWidths);
            }
        }
    }
}