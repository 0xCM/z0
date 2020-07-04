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
    /// Defines a refined 32-bit immediate value
    /// </summary>
    public readonly struct Imm32<E> : ISized<Imm32<E>,W32>
        where E : unmanaged, Enum
    {
        public readonly E Data;

        [MethodImpl(Inline)]
        public static implicit operator E(Imm32<E> src)
            => src.Data;

        [MethodImpl(Inline)]
        public static implicit operator Imm32<E>(E src)
            => new Imm32<E>(src);

        [MethodImpl(Inline)]
        public Imm32(E value)
        {
            Data = value;
        }
    }
}