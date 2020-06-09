//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;
    using System.Reflection.Metadata;
    using System.Reflection.Metadata.Ecma335;

    using static Konst;
    using static MetadataRecords.FieldRvaRecordField;
    using static MetadataRead;

    using K = MetadataRecords.FieldRvaRecordSpec;
    using F = MetadataRecords.FieldRvaRecordField;
    using R = MetadataRecords.FieldRvaRecord;

    partial class MetadataRecords
    {
        public enum FieldRvaRecordField : byte
        {
            Sequence = 0,

            Offset = 1,

            Field = 2,

            FieldCount = 3,
        }

        public readonly struct FieldRvaRecord : IMetadataRecord<R,K,F>
        {
            public int Sequence {get;}
            
            public int Offset {get;}

            public int Field {get;}

            public K Kind => default;

            [MethodImpl(Inline)]
            internal FieldRvaRecord(int Sequence, int Offset,  int Field)
            {
                this.Sequence = Sequence;
                this.Field = Field == -1 ? 0 : Field;
                this.Offset = Offset == -1 ? 0 : Offset;
            }            
            
            public string Format(char delimiter)
            {            
                var widths = FieldWidths(Kind);
                var count = FieldCount(Kind);
                var dst = Alloc<string>(count);
                Seek(dst, F.Sequence) = Render(Sequence, FieldWidth(widths, F.Sequence));
                Seek(dst, F.Offset) = RenderHex(Offset, FieldWidth(widths, F.Offset));
                Seek(dst, F.Field) = RenderHex(Field, FieldWidth(widths, F.Field));
                return Delimit(dst,delimiter);
            }        

            public string Format()
                => Format(FieldDelimiter);
        }

        public readonly struct FieldRvaRecordSpec  : IMetadataRecordSpec<FieldRvaRecordSpec>
        {
            [MethodImpl(Inline)]
            public static implicit operator MetadataRecordKind(FieldRvaRecordSpec src)
                => src.RecordType;

            public MetadataRecordKind RecordType => MetadataRecordKind.Field;            


            public byte FieldCount => (byte)F.FieldCount;
            
            public ReadOnlySpan<string> HeaderFields 
                => new string[(int)F.FieldCount]{
                    nameof(Sequence), 
                    nameof(Offset), 
                    nameof(Field), 

                    };

            public ReadOnlySpan<byte> FieldWidths 
                => new byte[(int)F.FieldCount]{12, 12, 12};

            public string HeaderText
            {
                [MethodImpl(Inline)]
                get => MetadataFormat.FormatHeader(HeaderFields, FieldWidths);
            }

            public override string ToString()
                => (this as ITextual).Format();
        }


        readonly struct FieldRvaCollector
        {
            internal static ReadOnlySpan<int> fieldrva(in ReaderState state)        
            {
                
                var reader = state.Reader;
                
                var offset = reader.GetTableMetadataOffset(TableIndex.FieldRva);
                var rowcount = reader.GetTableRowCount(TableIndex.FieldRva);
                var rowsize = reader.GetTableRowCount(TableIndex.FieldRva);

                var rvaCount = FieldRvaCount(state);
                var handles = reader.FieldDefinitions.ToReadOnlySpan();
                var count = handles.Length;
                
                for(var i=0; i<count; i++)
                {
                    ref readonly var handle = ref Control.skip(handles,i);
                    
                }
                
                var dst = alloc<int>(count);
                return dst;
            }
        }
    }
}