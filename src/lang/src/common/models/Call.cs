//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct Call
    {
        public Operation Target {get;}

        public Index<Operand> Operands {get;}

        [MethodImpl(Inline)]
        public Call(Operation target, params Operand[] args)
        {
            Target = target;
            Operands = args;
        }
    }
}