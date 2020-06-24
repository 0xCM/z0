//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static PartRecords.FieldRecordField;

    using K = PartRecords.FieldRecordSpec;
    using F = PartRecords.FieldRecordField;
    using R = PartRecords.FieldRecord;

    partial class PartRecords
    {
        public enum FieldRecordField : ushort
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

        [Op]
        public static string format(in FieldRecord src, char delimiter)
        {            
            var w = widths(src.Kind);
            var k = count(src.Kind);
            var dst = Spans.alloc<string>(k);
            Root.eSeek(dst, Sequence) = text.format(src.Sequence, Root.eSkip(w, Sequence));
            Root.eSeek(dst, Rva) = hex(src.Rva, Root.eSkip(w,Rva));
            Root.eSeek(dst, Offset) = hex(src.Offset, Root.eSkip(w, Offset));
            Root.eSeek(dst, Name) = text.format(src.Name, Root.eSkip(w, Name));
            Root.eSeek(dst, Signature) = text.format(src.Signature, Root.eSkip(w, Signature));
            Root.eSeek(dst, Attributes) = text.format(src.Attributes, Root.eSkip(w, Attributes));
            Root.eSeek(dst, Marshalling) = text.format(src.Marshalling, Root.eSkip(w, Marshalling));
            return text.delimit(dst,delimiter);
        }        

        public readonly struct FieldRecord : IPartRecord<R,K,F>
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

            public string[] HeaderNames
                => new string[(int)F.FieldCount]{
                    nameof(Sequence), 
                    nameof(Rva), 
                    nameof(Offset), 
                    nameof(Name), 
                    nameof(Signature),
                    nameof(Attributes),
                    nameof(Marshalling),
                    };

            public string Format(char delimiter)
                => format(this,delimiter);

            public string Format()
                => format(this, FieldDelimiter);
        }

        public readonly struct FieldRecordSpec  : IPartRecordSpec<FieldRecordSpec>
        {
            [MethodImpl(Inline)]
            public static implicit operator PartRecordKind(FieldRecordSpec src)
                => src.RecordType;

            public PartRecordKind RecordType => PartRecordKind.Field;            

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
                get => text.concat(HeaderFields, FieldWidths);
            }

            public override string ToString()
                => (this as ITextual).Format();

        }
    }
}