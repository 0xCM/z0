//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct RuleModels
    {
        public readonly struct Call : ICall
        {
            public IScopedOp Target {get;}

            public Index<OperandValue> Operands {get;}

            [MethodImpl(Inline)]
            public Call(IScopedOp target, params OperandValue[] args)
            {
                Target = target;
                Operands = args;
            }
        }
    }
}