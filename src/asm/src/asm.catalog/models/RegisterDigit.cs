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
    /// Represents a register digit 0..7 that occurs within an op code expression
    /// </summary>
    public readonly struct OpCodeRegDigit
    {
        public uint3 Value {get;}

        [MethodImpl(Inline)]
        public OpCodeRegDigit(uint3 value)
            => Value = value;
    }

}