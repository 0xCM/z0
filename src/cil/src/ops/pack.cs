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

    partial struct CilApi
    {
        [MethodImpl(Inline), Op]
        public static CilOpCodeRow pack(ILOpCode id, string name, CilOpCodeType type, CilOperandType optype, byte opcount, ushort code, CilStackBehaviour sb1, CilStackBehaviour sb2)
            => new CilOpCodeRow(id, name, type, optype, opcount, sb1, sb2);
    }
}