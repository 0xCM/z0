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

    public enum EnumLiteralField 
    {
        Sequence = 0 | FW.Sequence << FW.Offset,

        Identifier = 1 | FW.Identifier << FW.Offset,

        Description = 2 | FW.Identifier << FW.Offset,

        Value = 3 | FW.Num16Hex << FW.Offset
    }

    public readonly struct EnumLiteralRecord : IRecord<EnumLiteralField, EnumLiteralRecord>
    {
        public static EnumLiteralRecord Empty = new EnumLiteralRecord(0,string.Empty, string.Empty, 0);
        
        public int Sequence {get;}

        public string Identifier {get;}

        public string Description {get;}

        public ulong Value {get;}

        [MethodImpl(Inline)]
        public EnumLiteralRecord(int Sequence, string Identifier, string Description, ulong Value)
        {
            this.Sequence = Sequence;
            this.Identifier = Identifier;
            this.Description = Description;
            this.Value = Value;
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Sequence == 0 && text.empty(Identifier) && Value == 0;
        }
    }
}