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
    using static PartRecords.FieldRvaRecordField;
    using static PartRecordFormat;
    using static ReaderInternals;

    using K = PartRecords.FieldRvaRecordSpec;
    using F = PartRecords.FieldRvaRecordField;
    using R = PartRecords.FieldRvaRecord;


    partial class PartRecords
    {
        public enum FieldRvaRecordField : ushort
        {
            Sequence = 0,

            Offset = 1,

            Field = 2,

            FieldCount = 3,
        }

        public static string format(in FieldRvaRecord src, char delimiter)
        {            
            var w = widths(src.Kind);
            var k = count(src.Kind);
            var dst = Spans.alloc<string>(k);
            Root.eSeek(dst, F.Sequence) = text.format(src.Sequence, Root.eSkip(w, F.Sequence));
            Root.eSeek(dst, F.Offset) = hex(src.Offset, Root.eSkip(w, F.Offset));
            Root.eSeek(dst, F.Field) = hex(src.Field, Root.eSkip(w, F.Field));
            return text.delimit(dst,delimiter);
        }        

        public readonly struct FieldRvaRecord : IPartRecord<R,K,F>
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

            public string[] HeaderNames
                => new string[(int)F.FieldCount]{
                    nameof(Sequence), 
                    nameof(Offset), 
                    nameof(Field), 

                    };

            public string Format(char delimiter)
                => format(this, delimiter);

            public string Format()
                => format(this, FieldDelimiter);
        }

        public readonly struct FieldRvaRecordSpec  : IPartRecordSpec<FieldRvaRecordSpec>
        {
            [MethodImpl(Inline)]
            public static implicit operator PartRecordKind(FieldRvaRecordSpec src)
                => src.RecordType;

            public PartRecordKind RecordType 
                => PartRecordKind.Field;            

            public byte FieldCount 
                => (byte)F.FieldCount;
            
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
                get => text.concat(HeaderFields, FieldWidths);
            }

            public override string ToString()
                => (this as ITextual).Format();
        }


        readonly struct FieldRvaCollector
        {
            internal static ReadOnlySpan<int> fieldrva(in ReaderState state)        
            {
                
                var reader = state.Reader;
                
                var offset = reader.GetTableMetadataOffset(System.Reflection.Metadata.Ecma335.TableIndex.FieldRva);
                var rowcount = reader.GetTableRowCount(System.Reflection.Metadata.Ecma335.TableIndex.FieldRva);
                var rowsize = reader.GetTableRowCount(System.Reflection.Metadata.Ecma335.TableIndex.FieldRva);

                var rvaCount = FieldRvaCount(state);
                var handles = reader.FieldDefinitions.ToReadOnlySpan();
                var count = handles.Length;
                
                for(var i=0; i<count; i++)
                {
                    ref readonly var handle = ref Root.skip(handles,i);
                    
                }
                
                var dst = Root.alloc<int>(count);
                return dst;
            }
        }
    }
}