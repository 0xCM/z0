//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    /// <summary>
    /// Describes an 8-bit immediate that is potentially refined
    /// </summary>
    [DataType]
    public readonly struct Imm8R
    {
        public byte Value {get;}

        public bool Refined {get;}

        [MethodImpl(Inline)]
        public Imm8R(byte value, bool refined)
        {
            Value = value;
            Refined = refined;
        }

        [MethodImpl(Inline)]
        public static implicit operator byte(Imm8R imm8)
            => imm8.Value;
    }
}