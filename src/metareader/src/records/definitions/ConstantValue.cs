//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection.Metadata;

    using static Seed;
    using static MetadataRecords.ConstantField;

    using R = MetadataRecords.ConstantRecord;
    using F = MetadataRecords.ConstantField;
    using S = MetadataRecords.ConstantRecordSpec;

    partial class MetadataRecords
    {
        public enum ConstantField : byte
        {
            Sequence = 0,

            Parent = 1,

            DataType = 2,

            Value = 3,

            FieldCount = 4,
        }
        
        public readonly struct ConstantRecord : IMetadataRecord<R,S,F>
        {            
            public int Sequence {get;}

            public string Parent {get;}

            public ConstantTypeCode DataType {get;}

            public BlobRecord Value {get;}

            public S Kind => default;

            [MethodImpl(Inline)]
            internal ConstantRecord(int Sequence, string Parent, ConstantTypeCode Type, BlobRecord Value)
            {
                this.Sequence = Sequence;
                this.Parent = Parent;
                this.DataType = Type;
                this.Value = Value;
            }            
            public string Format()
                => MetadataFormat.format(this, FieldDelimiter);

            public string Format(char delimiter)
                => MetadataFormat.format(this, delimiter);
        }

        public readonly struct ConstantRecordSpec  : IMetadataRecordSpec<S>
        {
            [MethodImpl(Inline)]
            public static implicit operator MetadataRecordKind(S src)
                => src.RecordType;

            public MetadataRecordKind RecordType => MetadataRecordKind.Constant;            

            public byte FieldCount => (byte)F.FieldCount;
            
            public ReadOnlySpan<string> HeaderFields 
                => new string[(int)F.FieldCount]{
                    nameof(Sequence), 
                    nameof(Parent), 
                    nameof(DataType), 
                    nameof(Value),                     
                    };

            public ReadOnlySpan<byte> FieldWidths 
                => new byte[(int)F.FieldCount]{20,20,20,20};

            public string HeaderText
            {
                [MethodImpl(Inline)]
                get => MetadataFormat.FormatHeader(HeaderFields, FieldWidths);
            }

            public override string ToString()
                => (this as ITextual).Format();
        }
    }
}