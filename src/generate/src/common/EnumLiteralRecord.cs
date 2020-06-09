//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    using FW = CommonFieldWidths;

    public enum EnumLiteralRecordField 
    {
        Sequence = 0 | FW.Sequence << FW.Offset,

        Identifier = 1 | FW.Identifier << FW.Offset,

        Description = 2 | FW.Identifier << FW.Offset,

        DataType = 3 | FW.Identifier << FW.Offset,

        Value = 4 | FW.Num16Hex << FW.Offset,
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
    }
}