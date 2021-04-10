//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    using W = W8;

    /// <summary>
    /// Defines a refined 8-bit immediate value
    /// </summary>
    [Datatype("imm8r")]
    public readonly struct Imm8<E> : IImm<Imm8<E>,E>
        where E : unmanaged
    {
        public E Content {get;}

        [MethodImpl(Inline)]
        public Imm8(E src)
            => Content = src;

        public ImmWidth Width => ImmWidth.W8;

        public ImmKind Kind => ImmKind.Imm8;

        [MethodImpl(Inline)]
        public string Format()
            => HexFormat.format(Content, W);

        [MethodImpl(Inline)]
        public byte AsPrimitive()
            => bw8(this);

        public override string ToString()
            => Format();

        public uint Hash
        {
            [MethodImpl(Inline)]
            get => alg.hash.calc(Content);
        }

        public override int GetHashCode()
            => (int)Hash;

        [MethodImpl(Inline)]
        public static implicit operator E(Imm8<E> src)
            => src.Content;

        [MethodImpl(Inline)]
        public static implicit operator byte(Imm8<E> src)
            => src.AsPrimitive();

        [MethodImpl(Inline)]
        public static implicit operator Imm8<E>(E src)
            => new Imm8<E>(src);

        public static W W => default;
    }
}