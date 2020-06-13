//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using W = CommonFieldWidths;
    using F = EnumLiteralRecordField;

    public enum EnumLiteralRecordField : uint
    {
        Sequence = 0 | W.Sequence << W.Offset,

        Identifier = 1 | W.Identifier << W.Offset,

        Description = 2 | W.Identifier << W.Offset,

        DataType = 3 | W.Identifier << W.Offset,

        Value = 4 | W.Num16Hex << W.Offset,
    }

    public readonly struct EnumLiteralRecord : IRecord<EnumLiteralRecordField, EnumLiteralRecord>
    {
        public static EnumLiteralRecord Empty = new EnumLiteralRecord(0,string.Empty, string.Empty, EnumScalarKind.None, 0);
        
        public int Sequence {get;}

        public string Identifier {get;}

        public string Description {get;}

        public EnumScalarKind DataType {get;}

        public ulong Value {get;}

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

        public string Format()
        {
            var formatter = Tabular.formatter<F>();
            formatter.Append(F.Sequence, Sequence);
            formatter.Delimit(F.Identifier, Identifier);
            formatter.Delimit(F.Description, Description);
            formatter.Delimit(F.DataType, DataType);                
            formatter.Delimit(F.Value, Value);                
            return formatter.Format();
        }        
    }
}