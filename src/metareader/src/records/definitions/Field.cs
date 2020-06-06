//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static MetadataRecords.FieldRecordField;

    using K = MetadataRecords.FieldRecordSpec;
    using F = MetadataRecords.FieldRecordField;
    using R = MetadataRecords.FieldRecord;

    partial class MetadataRecords
    {
        public enum FieldRecordField : byte
        {
            Sequence = 0,
            
            Rva = 1,

            Offset = 2,

            Name = 3,

            Signature = 4,

            Attributes = 5,

            Marshalling = 6,
            
            FieldCount = 7,
        }

        public readonly struct FieldRecord : IMetadataRecord<R,K,F>
        {
            public int Sequence {get;}
            
            public int Rva {get;}

            public int Offset {get;}

            public LiteralRecord Name {get;}

            public BlobRecord Signature {get;}

            public string Attributes {get;}

            public string Marshalling {get;}

            public K Kind => default;

            [MethodImpl(Inline)]
            internal FieldRecord(int Sequence, int Rva, int Offset, LiteralRecord Name, BlobRecord Signature, string Attributes, string Marshalling)
            {
                this.Sequence = Sequence;
                this.Rva = Rva == -1 ? 0 : Rva;
                this.Offset = Offset == -1 ? 0 : Offset;
                this.Name = Name;
                this.Signature = Signature;
                this.Attributes = Attributes;
                this.Marshalling = Marshalling;
            }            
            
            public string Format()
                => MetadataFormat.format(this, FieldDelimiter);

            public string Format(char delimiter)
                => MetadataFormat.format(this, delimiter);
        }

        public readonly struct FieldRecordSpec  : IMetadataRecordSpec<FieldRecordSpec>
        {
            [MethodImpl(Inline)]
            public static implicit operator MetadataRecordKind(FieldRecordSpec src)
                => src.RecordType;

            public MetadataRecordKind RecordType => MetadataRecordKind.Field;            


            public byte FieldCount => (byte)F.FieldCount;
            
            public ReadOnlySpan<string> HeaderFields 
                => new string[(int)F.FieldCount]{
                    nameof(Sequence), 
                    nameof(Rva), 
                    nameof(Offset), 
                    nameof(Name), 
                    nameof(Signature),
                    nameof(Attributes),
                    nameof(Marshalling),
                    };

            public ReadOnlySpan<byte> FieldWidths 
                => new byte[(int)F.FieldCount]{12, 12, 12, 30, 30, 10, 10,};

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