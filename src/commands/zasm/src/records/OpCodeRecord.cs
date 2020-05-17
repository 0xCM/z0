//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Data
{        
    using System;

    using static Seed;
    using static Tabular;

    using R = OpCodeRecord;
    using F = OpCodeField;
    using Asm = Asm.Data;

    public readonly struct OpCodeRecord : ITabular<F,R>
    {
        public static void Save(OpCodeRecord[] src, FilePath dst, char sep = Chars.Pipe)
            => ITabular<F,R>.Save(src, dst, sep);

        public static OpCodeRecord Empty => default;

        public readonly string Id;

        public readonly BinaryCode CodeBytes;

        public readonly Asm.MandatoryPrefix Prefix;
        
        public readonly Asm.OpCodeTableKind Table;

        public readonly int Group;
		
        public readonly Asm.OpCodeOperandKind Op1;

        public readonly Asm.OpCodeOperandKind Op2;

        public readonly Asm.OpCodeOperandKind Op3;

        public readonly Asm.OpCodeOperandKind Op4;

        public readonly Asm.OperandSize OpSize;

        public readonly Asm.AddressSize AddressSize;

        public readonly Asm.OpCodeFlags Flags;

        public OpCodeRecord(
            string Id, 
            BinaryCode CodeBytes, 
            Asm.MandatoryPrefix MandatoryPrefix,
            Asm.OpCodeTableKind TableKind,
            int GroupIndex,
            Asm.OpCodeFlags Flags,
            Asm.OperandSize OpSize,
            Asm.AddressSize AddressSize,
            params Asm.OpCodeOperandKind[] Operands
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