//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using W = DataFieldWidths;
    using F = EnumLiteralRecordField;

    public enum EnumLiteralRecordField : uint
    {
        Sequence = 0 | W.Sequence << WidthOffset,

        Identifier = 1 | W.Identifier << WidthOffset,

        Description = 2 | W.Identifier << WidthOffset,

        DataType = 3 | W.Identifier << WidthOffset,

        Value = 4 | W.Num16Hex << WidthOffset,
    }

    public readonly struct EnumLiteralRecord : IRecord<EnumLiteralRecordField, EnumLiteralRecord>
    {
        public static Span<EnumLiteralRecord> ParseEnumLiterals(TextDoc src)
        {
            var rc = src.RowCount;
            var dst = z.alloc<EnumLiteralRecord>(rc);
            for(var i=0; i<rc; i++)
            {
                ref readonly var row = ref src[i];
                if(row.CellCount >= 3)
                {
                    var data = row[2];
                    var result = HexByteParser.Service.ParseData(data);
                    if(result.Succeeded)
                    {
                        var bytes = z.span(result.Value);
                        var storage = 0ul;
                        ref var store = ref z.@as<ulong,byte>(storage);
                        var count = z.min(bytes.Length,8);
                        for(var j=0u; j<count; j++)
                            z.seek(store,j) = z.skip(bytes,j);

                        dst[i] = new EnumLiteralRecord(i, row[0], row[1], 0, storage);
                    }
                }
                else
                    dst[i] = EnumLiteralRecord.Empty;
            }
            return dst;
        }

        public readonly int Sequence;

        public readonly string Identifier;

        public readonly string Description;

        public readonly EnumScalarKind DataType;

        public readonly ulong Value;


        [MethodImpl(Inline)]
        public EnumLiteralRecord(int Sequence, string Identifier, string Description, EnumScalarKind DataType, ulong Value)
        {
            this.Sequence = Sequence;
            this.Identifier = Identifier;
            this.Description = Description;
            this.Value = Value;
            this.DataType = DataType;
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Sequence == 0 && text.blank(Identifier) && Value == 0;
        }

        public string DelimitedText(char delimiter)
        {
            var formatter = DataFields.formatter<F>(delimiter);
            formatter.Append(F.Sequence, Sequence);
            formatter.Delimit(F.Identifier, Identifier);
            formatter.Delimit(F.Description, Description);
            formatter.Delimit(F.DataType, DataType);                
            formatter.Delimit(F.Value, Value);                
            return formatter.Format();
        }        

        int ISequential.Sequence 
            => Sequence;

        public static EnumLiteralRecord Empty 
            => new EnumLiteralRecord(0, EmptyString, EmptyString, 0, 0);    
    }
}