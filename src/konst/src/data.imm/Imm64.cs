//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using W = W64;

    /// <summary>
    /// Defines a refined 64-bit immediate value
    /// </summary>
    public readonly struct Imm64<E> //: ISized<Imm64<E>,W64>
        where E : unmanaged
    {
        public readonly E Data;

        public static W W => default;

        [MethodImpl(Inline)]
        public static implicit operator E(Imm64<E> src)
            => src.Data;

        [MethodImpl(Inline)]
        public static implicit operator Imm64<E>(E src)
            => new Imm64<E>(src);

        [MethodImpl(Inline)]
        public Imm64(E src)
            => Data = src;

        [MethodImpl(Inline)]
        public string Format()
            => Hex.format(Data, W);

        public override string ToString()
            => Format();

        public uint Hash
        {
            [MethodImpl(Inline)]
            get => z.hash(Data);
        }

        public override int GetHashCode()
            => (int)Hash;
    }
}