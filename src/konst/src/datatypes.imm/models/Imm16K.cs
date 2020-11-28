//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using W = W16;

    /// <summary>
    /// Defines a refined 16-bit immediate value
    /// </summary>
    [DataType]
    public readonly struct Imm16<E> : IImmValue<Imm16<E>,W, E>
        where E : unmanaged
    {
        public E Storage {get;}

        public static W W => default;

        public E Content
        {
            [MethodImpl(Inline)]
            get => Storage;
        }

        [MethodImpl(Inline)]
        public static implicit operator E(Imm16<E> src)
            => src.Storage;

        [MethodImpl(Inline)]
        public static implicit operator Imm16<E>(E src)
            => new Imm16<E>(src);

        [MethodImpl(Inline)]
        public Imm16(E value)
        {
            Storage = value;
        }

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
    }
}