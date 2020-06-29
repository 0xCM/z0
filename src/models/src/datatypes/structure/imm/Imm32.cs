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
    /// Defines a 32-bit immediate value
    /// </summary>
    public readonly struct Imm32 : ISized<Imm32,W32>
    {
        public readonly uint Data;

        [MethodImpl(Inline)]
        public static implicit operator uint(Imm32 src)
            => src.Data;

        [MethodImpl(Inline)]
        public static implicit operator Imm32(uint src)
            => new Imm32(src);

        [MethodImpl(Inline)]
        public Imm32(uint src)
        {
            Data = src;
        }
    }
}