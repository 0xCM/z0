//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection.Metadata;
    using System.Runtime.CompilerServices;

    using static Konst;

    public struct CilOpCodeRow
    {
        public ILOpCode OpCode;

        public asci16 Name;

        public CilOpCodeType CodeType;

        public CilOperandType ArgType;

        public byte ArgCount;

        public CilStackBehaviour Sb1;

        public CilStackBehaviour Sb2;

        [MethodImpl(Inline)]
        public CilOpCodeRow(ILOpCode id, string name, CilOpCodeType type,CilOperandType optype, byte opcount, CilStackBehaviour sb1, CilStackBehaviour sb2)
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