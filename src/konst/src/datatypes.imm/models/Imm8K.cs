//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using W = W8;

    /// <summary>
    /// Defines a refined 8-bit immediate value
    /// </summary>
    [DataType]
    public readonly struct Imm8<E> : IImmValue<Imm8<E>,W, E>
        where E : unmanaged
    {
        public E Storage {get;}

        [MethodImpl(Inline)]
        public Imm8(E src)
            => Storage = src;

        [MethodImpl(Inline)]
        public string Format()
            => Hex.format(Storage, W);

        public override string ToString()
            => Format();

        public uint Hash
        {
            [MethodImpl(Inline)]
            get => z.hash(Storage);
        }

        public override int GetHashCode()
            => (int)Hash;

        [MethodImpl(Inline)]
        public static implicit operator E(Imm8<E> src)
            => src.Storage;

        [MethodImpl(Inline)]
        public static implicit operator Imm8<E>(E src)
            => new Imm8<E>(src);

        public static W W => default;
    }
}