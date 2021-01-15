//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    /// <summary>
    /// Represents an expression of the form r0 + f*r
    /// </summary>
    public readonly struct RegScale<B,R>
        where B : IRegister
        where R : IRegister
    {
        public B Base {get;}

        public MemoryScaleFactor Factor {get;}

        public R Operand {get;}

        public RegScale(B @base, MemoryScaleFactor factor, R op)
        {
            Base = @base;
            Factor = factor;
            Operand = op;
        }
    }
}