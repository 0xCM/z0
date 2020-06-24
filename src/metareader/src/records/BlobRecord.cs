//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static PartRecords.BlobField;

    using S = PartRecords.BlobSpec;
    using F = PartRecords.BlobField;
    using R = PartRecords.BlobRecord;

    partial class PartRecords
    {
        public enum BlobField : ushort
        {
            Sequence = 0,

            HeapSize = 1,

            Offset = 2,

            Value = 3,

            RecordFieldCount = 4,            
        }
    
        public static string format(in BlobRecord src, char delimiter)
        {            
            var widths = widths<S>(src.Kind);
            var count = count<S>(src.Kind);
            var dst = Spans.alloc<string>(count);
            Root.eSeek(dst, Sequence) = text.format(src.Sequence, Root.eSkip(widths, Sequence));
            Root.eSeek(dst, HeapSize) = hex(src.HeapSize, Root.eSkip(widths, HeapSize));
            Root.eSeek(dst, Offset) = hex(src.Offset, Root.eSkip(widths, Offset));
            Root.eSeek(dst, Value) = text.format(src.Value, Root.eSkip(widths, Value));
            return text.delimit(dst,delimiter);
        }        

        public readonly struct BlobRecord : IPartRecord<R,S,F>
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

            public string[] HeaderNames 
                => new string[(int)RecordFieldCount]{
                    nameof(Sequence), 
                    nameof(HeapSize), 
                    nameof(Offset), 
                    nameof(Value), 
                    };

            public string Format()
                => format(this, FieldDelimiter);

            public string Format(char delimiter)
                => format(this, delimiter);
        }
        
        public readonly struct BlobSpec : IPartRecordSpec<S>
        {
            [MethodImpl(Inline)]
            public static implicit operator PartRecordKind(S src)
                => src.RecordType;

            public PartRecordKind RecordType 
                => PartRecordKind.Blob;       

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
                get => text.concat(HeaderFields, FieldWidths);
            }

            public override string ToString()
                => (this as ITextual).Format();            
        }
    }
}