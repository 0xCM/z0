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
        public Function Target {get;}

        public Index<Operand> Operands {get;}

        public Call(Function f, params Operand[] args)
        {
            Target = f;
            Operands = args;
        }
    }

}