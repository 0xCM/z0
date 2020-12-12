// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.
namespace Z0
{
    using System;
    using System.Reflection.Metadata;
    using System.Runtime.CompilerServices;

    using static Part;

    using K = System.Reflection.Metadata.ILOpCode;

    public struct CilOpCodeInfo
    {
        public K OpCode;

        public string Name;

        public CilOpCodeType CodeType;

        public CilOperandType ArgType;

        public byte ArgCount;

        public CilStackBehaviour Sb1;

        public CilStackBehaviour Sb2;

        [MethodImpl(Inline)]
        public CilOpCodeInfo(K id, string name, CilOpCodeType type, CilOperandType optype, byte opcount, CilStackBehaviour sb1, CilStackBehaviour sb2)
        {
            OpCode = id;
            Name =  name;
            CodeType = type;
            ArgType =  optype;
            ArgCount = opcount;
            Sb1 = sb1;
            Sb2 = sb2;
        }

        [MethodImpl(Inline)]
        public CilOpCodeInfo(CilOpCodeKind id, string name, CilOpCodeType type, CilOperandType optype, byte opcount, CilStackBehaviour sb1, CilStackBehaviour sb2)
        {
            OpCode = (K)id;
            Name =  name;
            CodeType = type;
            ArgType =  optype;
            ArgCount = opcount;
            Sb1 = sb1;
            Sb2 = sb2;
        }
    }
}