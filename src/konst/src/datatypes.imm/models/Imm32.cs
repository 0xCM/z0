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
    using I = Imm32;

    /// <summary>
    /// Defines a 32-bit immediate value
    /// </summary>
    [DataType]
    public readonly struct Imm32 : IImmValue<I,W32, uint>
    {
        public uint Storage {get;}

        [MethodImpl(Inline)]
        public Imm32(uint src)
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
        public int CompareTo(I src)
            => Storage == src.Storage ? 0 : Storage < src.Storage ? -1 : 1;

        [MethodImpl(Inline)]
        public bool Equals(I src)
            => Storage == src.Storage;

        public override bool Equals(object src)
            => src is I x && Equals(x);

        [MethodImpl(Inline)]
        public Address32 ToAddress()
            => Storage;

        [MethodImpl(Inline)]
        public static implicit operator uint(I src)
            => src.Storage;

        [MethodImpl(Inline)]
        public static implicit operator I(uint src)
            => new I(src);

        [MethodImpl(Inline)]
        public static bool operator <(I a, I b)
            => a.Storage < b.Storage;

        [MethodImpl(Inline)]
        public static bool operator >(I a, I b)
            => a.Storage > b.Storage;

        [MethodImpl(Inline)]
        public static bool operator <=(I a, I b)
            => a.Storage <= b.Storage;

        [MethodImpl(Inline)]
        public static bool operator >=(I a, I b)
            => a.Storage >= b.Storage;

        [MethodImpl(Inline)]
        public static bool operator ==(I a, I b)
            => a.Storage == b.Storage;

        [MethodImpl(Inline)]
        public static bool operator !=(I a, I b)
            => a.Storage != b.Storage;

        public static W W => default;
    }
}