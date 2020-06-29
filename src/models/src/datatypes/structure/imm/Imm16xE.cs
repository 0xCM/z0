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
    /// Defines a refined 16-bit immediate value
    /// </summary>
    public readonly struct Imm16<E> : ISized<Imm16<E>,W16>
        where E : unmanaged, Enum
    {
        public readonly E Data;

        [MethodImpl(Inline)]
        public static implicit operator E(Imm16<E> src)
            => src.Data;

        [MethodImpl(Inline)]
        public static implicit operator Imm16<E>(E src)
            => new Imm16<E>(src);

        [MethodImpl(Inline)]
        public Imm16(E value)
        {
            Data = value;
        }
    }
}