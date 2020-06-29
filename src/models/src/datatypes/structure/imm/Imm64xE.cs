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
    /// Defines a refined 64-bit immediate value
    /// </summary>
    public readonly struct Imm64<E> : ISized<Imm64<E>,W64>
        where E : unmanaged, Enum
    {
        public readonly E Data;

        [MethodImpl(Inline)]
        public static implicit operator E(Imm64<E> src)
            => src.Data;

        [MethodImpl(Inline)]
        public static implicit operator Imm64<E>(E src)
            => new Imm64<E>(src);

        [MethodImpl(Inline)]
        public Imm64(E value)
        {
            Data = value;
        }
    }
}