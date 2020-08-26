//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Reflection.Emit;
    using System.Reflection.Metadata;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct Cil
    {
        [Table]
        public unsafe struct OpCodeTable : ITable<OpCodeTable>
        {
            public ILOpCode Id;

            public asci16 Name;

            public OpCodeType CodeType;

            public OperandType ArgType;

            public byte ArgCount;

            public ushort OpCode;

            public StackBehaviour Sb1;

            public StackBehaviour Sb2;

            [MethodImpl(Inline)]
            public OpCodeTable(ILOpCode id, string name, OpCodeType type, OperandType optype, byte opcount, ushort code, StackBehaviour sb1, StackBehaviour sb2)
            {
                Id = id;
                Name =  name;
                CodeType = type;
                ArgType = optype;
                ArgCount = opcount;
                OpCode = code;
                z.insist((ushort)id,code);
                Sb1 = sb1;
                Sb2 = sb2;
            }
        }
    }
}