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
    using I = Imm8;

    /// <summary>
    /// Defines an 8-bit immediate value
    /// </summary>
    public readonly struct Imm8 : IAsmOperand<I,W,byte>
    {
        public readonly byte Data;

        public static W W => default;

        public byte Content
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        public AsmOperandKind OpKind
        {
            [MethodImpl(Inline)]
            get => AsmOperandKind.Imm;
        }

        [MethodImpl(Inline)]
        public static implicit operator byte(I src)
            => src.Data;

        [MethodImpl(Inline)]
        public static implicit operator I(byte src)
            => new I(src);

        [MethodImpl(Inline)]
        public static bool operator <(I a, I b)
            => a.Data < b.Data;

        [MethodImpl(Inline)]
        public static bool operator >(I a, I b)
            => a.Data > b.Data;

        [MethodImpl(Inline)]
        public static bool operator <=(I a, I b)
            => a.Data <= b.Data;

        [MethodImpl(Inline)]
        public static bool operator >=(I a, I b)
            => a.Data >= b.Data;

        [MethodImpl(Inline)]
        public static bool operator ==(I a, I b)
            => a.Data == b.Data;

        [MethodImpl(Inline)]
        public static bool operator !=(I a, I b)
            => a.Data != b.Data;

        [MethodImpl(Inline)]
        public Imm8(byte src)
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

        [MethodImpl(Inline)]
        public int CompareTo(I src)
            => Data == src.Data ? 0 : Data < src.Data ? -1 : 1;

        [MethodImpl(Inline)]
        public bool Equals(I src)
            => Data == src.Data;

        public override bool Equals(object src)
            => src is I x && Equals(x);

        [MethodImpl(Inline)]
        public Address8 ToAddress()
            => Data;
    }
}