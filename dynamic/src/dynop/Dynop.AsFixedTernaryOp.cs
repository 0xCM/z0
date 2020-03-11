//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial class Dynop
    {

        [MethodImpl(Inline)]
        public static FixedDelegate AsFixedTernaryOp(this IBufferToken buffer, OpIdentity id, Type operatorType, Type operandType)        
            => buffer.Handle.EmitFixedAdapter(id, functype:operatorType, result:operandType, args: array(operandType, operandType, operandType));

    }
}