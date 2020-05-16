//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Encoding
{        
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using Z0.Asm.Data;

    using static Seed;
    using static Tabular;

    using R = OpCodeRecord;
    using F = OpCodeField;

    public enum OpCodeField : ulong
    {
        Id = 0 | 50ul << FieldWidthOffset,

        CodeBytes = (0xFF & Id + 1) | 16ul << FieldWidthOffset,

        Prefix = (0xFF & CodeBytes + 1) | 8ul << FieldWidthOffset,

        Table = (0xFF & Prefix + 1) | 8ul << FieldWidthOffset,

        Group = (0xFF & Table + 1) | 8ul << FieldWidthOffset,

        Op1 = (0xFF & Group + 1) | 20ul << FieldWidthOffset,

        Op2 = (0xFF & Op1 + 1) | 20ul << FieldWidthOffset,

        Op3 = (0xFF & Op2 + 1) | 20ul << FieldWidthOffset,

        Op4 = (0xFF & Op3 + 1) | 20ul << FieldWidthOffset,

        OpSize = (0xFF & Op4 + 1) | 10ul << FieldWidthOffset,

        AddressSize = (0xFF & OpSize + 1) | 14ul << FieldWidthOffset,

        Flags = (0xFF & Op4 + 1),

    }

    public readonly struct OpCodeRecord : ITabular<F,R>
    {
        public static void Save(OpCodeRecord[] src, FilePath dst, char sep = Chars.Pipe)
            => ITabular<F,R>.Save(src, dst, sep);

        public static OpCodeRecord Empty => default;

        public readonly string Id;

        public readonly BinaryCode CodeBytes;

        public readonly MandatoryPrefix Prefix;
        
        public readonly OpCodeTableKind Table;

        public readonly int Group;
		
        public readonly OpCodeOperandKind Op1;

        public readonly OpCodeOperandKind Op2;

        public readonly OpCodeOperandKind Op3;

        public readonly OpCodeOperandKind Op4;

        public readonly OperandSize OpSize;

        public readonly AddressSize AddressSize;

        public readonly OpCodeFlags Flags;

        public OpCodeRecord(
            string Id, 
            BinaryCode CodeBytes, 
            MandatoryPrefix MandatoryPrefix,
            OpCodeTableKind TableKind,
            int GroupIndex,
            OpCodeFlags Flags,
            OperandSize OpSize,
            AddressSize AddressSize,
            params OpCodeOperandKind[] Operands
            )
        {
            this.Id = Id;
            this.CodeBytes = CodeBytes;
            this.Prefix = MandatoryPrefix;
            this.Table = TableKind;
            this.Group = GroupIndex;
            this.OpSize = OpSize;
            this.AddressSize = AddressSize;
            this.Flags = Flags;

            switch(Operands.Length)
            {
                case 1:
                    Op1 = Operands[0];
                    Op2 = default;
                    Op3 = default;
                    Op4 = default;
                    break;
                case 2:
                    Op1 = Operands[0];
                    Op2 = Operands[1];
                    Op3 = default;
                    Op4 = default;
                    break;
                case 3:
                    Op1 = Operands[0];
                    Op2 = Operands[1];
                    Op3 = Operands[2];
                    Op4 = default;
                    break;
                case 4:
                    Op1 = Operands[0];
                    Op2 = Operands[1];
                    Op3 = Operands[2];
                    Op4 = Operands[3];
                    break;
                default:
                    Op1 = default;
                    Op2 = default;
                    Op3 = default;
                    Op4 = default;
                break;
            }
        }
        
        public string DelimitedText(char sep)
        {
            var src = this;
            var dst = formatter<F>();
            dst.DelimitField(F.Id, src.Id);
            dst.DelimitField(F.CodeBytes, src.CodeBytes);
            dst.DelimitSome(F.Prefix, src.Prefix);
            dst.DelimitField(F.Table, src.Table);
            dst.DelimitField(F.Group, src.Group == - 1 ? string.Empty : src.Group.ToString());
            dst.DelimitSome(F.Op1, src.Op1);
            dst.DelimitSome(F.Op2, src.Op2);
            dst.DelimitSome(F.Op3, src.Op3);
            dst.DelimitSome(F.Op4, src.Op4);
            dst.DelimitSome(F.OpSize, src.OpSize);
            dst.DelimitSome(F.AddressSize, src.AddressSize);

            dst.DelimitField(F.Flags, src.Flags);
            return dst.Format();                             
        }      
    }

}