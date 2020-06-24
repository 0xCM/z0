//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static PartRecords.StringValueField;
    using static PartRecordFormat;

    using S = PartRecords.StringValueSpec;
    using F = PartRecords.StringValueField;
    using R = PartRecords.StringValueRecord;

    partial class PartRecords
    {
        public enum StringValueField : ushort
        {
            Sequence = 0,
            
            HeapSize = 1,

            Length = 2,

            Offset = 3,

            Value = 4,

            FieldCount = 5,
        }

        public enum StringValueWidths : ushort
        {
            Sequence = 12,
            
            HeapSize = 12,

            Length = 12,

            Offset = 12,

            Value = 12,

            FieldCount = 12,
        }

        [Op]
        public static string format(in StringValueRecord src, char delimiter)
        {            
            var w = widths<StringValueSpec>(src.Kind);
            var eWidths = Root.literals<StringValueWidths>();
            var k = count<StringValueSpec>(src.Kind);
            var dst = Spans.alloc<string>(k);
            Root.eSeek(dst, Sequence) = text.format(src.Sequence, Root.eSkip(w, Sequence));
            Root.eSeek(dst, HeapSize) = hex(src.HeapSize, Root.eSkip(w, HeapSize));
            Root.eSeek(dst, Length) = text.format(src.Length, Root.eSkip(w, Length));
            Root.eSeek(dst, Offset) = hex(src.Offset, Root.eSkip(w, Offset));
            Root.eSeek(dst, Value) = src.Value;
            return text.delimit(dst,delimiter);
        }        

        public readonly struct StringValueRecord : IPartRecord<R,S,F>
        {
            public int Sequence {get;}

            public int HeapSize {get;}

            public int Length {get;}

            public int Offset {get;}

            public string Value {get;}

            public S Kind => default;

            [MethodImpl(Inline)]
            public StringValueRecord(int Sequence, int HeapSize, int Offset, string Value)
            {
                this.Sequence = Sequence;
                this.HeapSize = HeapSize;
                this.Length = Value.Length;
                this.Offset = Offset;
                this.Value = Value;
            }                     

            public string[] HeaderNames
                => new string[(int)F.FieldCount]{
                    nameof(Sequence), 
                    nameof(HeapSize), 
                    nameof(Length), 
                    nameof(Offset), 
                    nameof(Value)
                    };

            public string Format()
                => format(this, FieldDelimiter);

            public string Format(char delimiter)
                => format(this, delimiter);
        }

        public readonly struct StringValueSpec : IPartRecordSpec<S>
        {
            [MethodImpl(Inline)]
            public static implicit operator PartRecordKind(S src)
                => src.RecordType;
            
            public PartRecordKind RecordType 
                => PartRecordKind.String;

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
                get => text.concat(HeaderFields, FieldWidths);
            }

            public override string ToString()
                => (this as ITextual).Format();
        }        
    }
}