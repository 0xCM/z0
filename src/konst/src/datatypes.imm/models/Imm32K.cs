//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using W = W32;

    /// <summary>
    /// Defines a refined 32-bit immediate value
    /// </summary>
    [DataType]
    public readonly struct Imm32<E> : IImmValue<Imm32<E>,W, E>
        where E : unmanaged
    {
        public E Value {get;}

        public static W W => default;

        [MethodImpl(Inline)]
        public static implicit operator E(Imm32<E> src)
            => src.Value;

        [MethodImpl(Inline)]
        public static implicit operator Imm32<E>(E src)
            => new Imm32<E>(src);

        [MethodImpl(Inline)]
        public Imm32(E src)
            => Value = src;

        [MethodImpl(Inline)]
        public string Format()
            => Hex.format(Value, W);

        public override string ToString()
            => Format();

        public uint Hash
        {
            [MethodImpl(Inline)]
            get => z.hash(Value);
        }

        public override int GetHashCode()
            => (int)Hash;

    }
}