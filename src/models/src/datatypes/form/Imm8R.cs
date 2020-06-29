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
    public readonly struct Imm8R
    {
        public readonly byte Data;

        public readonly bool Refined;

        [MethodImpl(Inline)]
        public static implicit operator byte(Imm8R imm8)
            => imm8.Data;

        [MethodImpl(Inline)]
        public Imm8R(byte value, bool refined)
        {
            Data = value;
            Refined = refined;
        }
    }
}