//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    
    using static MetadataRecords.LiteralField;

    using R = MetadataRecords.LiteralRecord;
    using S = MetadataRecords.LiteralRecordSpec;
    using F = MetadataRecords.LiteralField;

    partial class MetadataRecords
    {
        const char FieldDelimiter = Chars.Pipe;

        public enum LiteralField : byte
        {
            Sequence = 0,
            
            HeapSize = 1,

            Length = 2,

            Offset = 3,

            Value = 4,

            FieldCount = 5,
        }
        
        public readonly struct LiteralRecord : IMetadataRecord<R,S,F>
        {
            public int Sequence {get;}

            public int HeapSize {get;}

            public int Length {get;}
            
            public int Offset {get;}
            
            public string Value {get;}

            public S Kind => default;

            [MethodImpl(Inline)]
            public LiteralRecord(int Sequence, int HeapSize, int Offset, string Value)
            {
                this.Sequence = Sequence;
                this.HeapSize = HeapSize;
                this.Length = Value.Length;
                this.Offset = Offset;
                this.Value = Value;
            }                        
            public string Format()
                => MetadataFormat.format(this, FieldDelimiter);

            public string Format(char delimiter)
                => MetadataFormat.format(this, delimiter);
        }            

        public readonly struct LiteralRecordSpec  : IMetadataRecordSpec<S>
        {
            [MethodImpl(Inline)]
            public static implicit operator MetadataRecordKind(S src)
                => src.RecordType;

            public MetadataRecordKind RecordType
                => MetadataRecordKind.Literal;       

            public byte FieldCount
                => (byte)F.FieldCount;
            
            public ReadOnlySpan<string> HeaderFields 
                => new string[(int)F.FieldCount]{
                    nameof(Sequence), 
                    nameof(HeapSize), 
                    nameof(Length), 
                    nameof(Offset), 
                    nameof(Value)
                    };

            public ReadOnlySpan<byte> FieldWidths 
                => new byte[(int)F.FieldCount]{12, 12, 12, 12, 12};

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