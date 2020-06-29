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
    /// Defines an 8-bit immediate value
    /// </summary>
    public readonly struct Imm8 : ISized<Imm8,W8>
    {
        public readonly byte Data;

        [MethodImpl(Inline)]
        public static implicit operator byte(Imm8 src)
            => src.Data;

        [MethodImpl(Inline)]
        public static implicit operator Imm8(byte src)
            => new Imm8(src);

        [MethodImpl(Inline)]
        public Imm8(byte src)
        {
            Data = src;
        }
    }
}