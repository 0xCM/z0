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
    public readonly struct Imm64<K> : IDataType<Imm64<K>,K>
        where K : unmanaged
    {
        public K Value {get;}

        [MethodImpl(Inline)]
        public Imm64(K src)
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

        [MethodImpl(Inline)]
        public static implicit operator K(Imm64<K> src)
            => src.Value;

        [MethodImpl(Inline)]
        public static implicit operator Imm64<K>(K src)
            => new Imm64<K>(src);

        public static W W => default;
    }
}