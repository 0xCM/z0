//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection.Metadata;

    using static Konst;
    using static PartRecords.ConstantField;

    using R = PartRecords.ConstantRecord;
    using F = PartRecords.ConstantField;
    using S = PartRecords.ConstantRecordSpec;

    partial class PartRecords
    {
        public enum ConstantField : ushort
        {
            Sequence = 0,

            Parent = 1,

            DataType = 2,

            Value = 3,

            FieldCount = 4,
        }

        [Op]
        public static string format(in ConstantRecord src, char delimiter)
        {            
            var w = widths(src.Kind);
            var k = count(src.Kind);
            var dst = Spans.alloc<string>(k);
            Root.eSeek(dst, Sequence) = text.format(src.Sequence, Root.eSkip(w, Sequence));
            Root.eSeek(dst, Parent) = text.format(src.Parent, Root.eSkip(w, Parent));
            Root.eSeek(dst, DataType) = text.format(src.DataType, Root.eSkip(w, DataType));
            Root.eSeek(dst, Value) = text.format(src.Value, Root.eSkip(w, Value));
            return text.delimit(dst, delimiter);
        }        

        public readonly struct ConstantRecord : IPartRecord<R,S,F>
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

            public string[] HeaderNames
                => new string[(int)F.FieldCount]{
                    nameof(Sequence), 
                    nameof(Parent), 
                    nameof(DataType), 
                    nameof(Value),                     
                    };

            public string Format()
                => format(this, FieldDelimiter);

            public string Format(char delimiter)
                => format(this, delimiter);
        }

        public readonly struct ConstantRecordSpec  : IPartRecordSpec<S>
        {
            [MethodImpl(Inline)]
            public static implicit operator PartRecordKind(S src)
                => src.RecordType;

            public PartRecordKind RecordType 
                => PartRecordKind.Constant;            

            public byte FieldCount 
                => (byte)F.FieldCount;
            
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
                get => text.concat(HeaderFields, FieldWidths);
            }

            public override string ToString()
                => (this as ITextual).Format();
        }
    }
}