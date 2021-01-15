//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    using W = W32;

    /// <summary>
    /// Defines a refined 32-bit immediate value
    /// </summary>
    [Datatype]
    public readonly struct Imm32<E> : IImmediate<Imm32<E>,W, E>
        where E : unmanaged
    {
        public E Content {get;}

        public static W W => default;

        [MethodImpl(Inline)]
        public static implicit operator E(Imm32<E> src)
            => src.Content;

        [MethodImpl(Inline)]
        public static implicit operator Imm32<E>(E src)
            => new Imm32<E>(src);

        [MethodImpl(Inline)]
        public Imm32(E src)
            => Content = src;

        [MethodImpl(Inline)]
        public string Format()
            => Hex.format(Content, W);

        public override string ToString()
            => Format();

        public uint Hash
        {
            [MethodImpl(Inline)]
            get => alg.hash.calc(Content);
        }

        public override int GetHashCode()
            => (int)Hash;
    }
}