//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using W = TabularWidths;
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
            get => Sequence == 0 && text.empty(Identifier) && Value == 0;
        }

        public string DelimitedText(char delimiter)
        {
            var formatter = Reports.formatter<F>(delimiter);
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