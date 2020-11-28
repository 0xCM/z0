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
    using I = Imm16;

    /// <summary>
    /// Defines a 16-bit immediate value
    /// </summary>
    [DataType]
    public readonly struct Imm16 : IImmValue<I,W16,ushort>
    {
        public ushort Storage {get;}

        public static W W => default;

        [MethodImpl(Inline)]
        public Imm16(ushort src)
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
        public Address16 ToAddress()
            => Storage;

        [MethodImpl(Inline)]
        public static implicit operator ushort(I src)
            => src.Storage;

        [MethodImpl(Inline)]
        public static implicit operator I(ushort src)
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
     }
}