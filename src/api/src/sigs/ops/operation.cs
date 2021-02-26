//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    partial struct ApiSigs
    {
        [MethodImpl(Inline), Op]
        public static OperationSig operation(Name name, OperandSig @return, params OperandSig[] operands)
            => new OperationSig(name, @return, operands);
    }
}