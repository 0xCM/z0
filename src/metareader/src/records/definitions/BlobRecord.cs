//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static MetadataRecords.BlobField;

    using S = MetadataRecords.BlobSpec;
    using F = MetadataRecords.BlobField;
    using R = MetadataRecords.BlobRecord;

    partial class MetadataRecords
    {
        public enum BlobField : byte
        {
            Sequence = 0,

            HeapSize = 1,

            Offset = 2,

            Value = 3,

            RecordFieldCount = 4,            
        }

        public readonly struct BlobRecord : IMetadataRecord<R,S,F>
        {
            public int Sequence {get;}
            
            public int HeapSize {get;}

            public int Offset {get;}
            
            public byte[] Value {get;}

            public S Kind => default;

            [MethodImpl(Inline)]
            public BlobRecord(int Sequence, int HeapSize, int Offset, byte[] Value)
            {
                this.Sequence = Sequence;
                this.HeapSize = HeapSize;
                this.Offset = Offset;
                this.Value = Value;
            }
            public string Format()
                => MetadataFormat.format(this, FieldDelimiter);

            public string Format(char delimiter)
                => MetadataFormat.format(this, delimiter);
        }
        
        public readonly struct BlobSpec : IMetadataRecordSpec<S>
        {
            [MethodImpl(Inline)]
            public static implicit operator MetadataRecordKind(S src)
                => src.RecordType;

            public MetadataRecordKind RecordType 
                => MetadataRecordKind.Blob;       

            public byte FieldCount 
                => (byte)RecordFieldCount;

            public ReadOnlySpan<string> HeaderFields 
                => new string[(int)RecordFieldCount]{
                    nameof(Sequence), 
                    nameof(HeapSize), 
                    nameof(Offset), 
                    nameof(Value), 
                    };
            
            public ReadOnlySpan<byte> FieldWidths 
                => new byte[(int)RecordFieldCount]{12, 12, 12, 30};

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