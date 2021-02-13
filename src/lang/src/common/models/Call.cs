//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct Call : ICall
    {
        public IOperation Target {get;}

        public Index<OperandValue> Operands {get;}

        [MethodImpl(Inline)]
        public Call(IOperation target, params OperandValue[] args)
        {
            Target = target;
            Operands = args;
        }
    }
}