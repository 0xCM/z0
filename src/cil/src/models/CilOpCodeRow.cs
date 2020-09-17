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

    using M = CilModel;

    public struct CilOpCode
    {
        public ILOpCode OpCode;

        public asci16 Name;

        public M.OpCodeType CodeType;

        public M.OperandType ArgType;

        public byte ArgCount;

        public M.StackBehaviour Sb1;

        public M.StackBehaviour Sb2;

        [MethodImpl(Inline)]
        public CilOpCode(ILOpCode id, string name, M.OpCodeType type, M.OperandType optype, byte opcount, M.StackBehaviour sb1, M.StackBehaviour sb2)
        {
            OpCode = id;
            Name =  name;
            CodeType = type;
            ArgType =  optype;
            ArgCount = opcount;
            Sb1 = sb1;
            Sb2 = sb2;
        }
    }
}