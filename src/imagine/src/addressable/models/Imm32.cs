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
    public readonly struct Imm32 : IOperand<I,W32, uint>
    {
        public readonly uint Data;

        public static W W => default;

        public uint Content
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
        public static implicit operator uint(I src)
            => src.Data;

        [MethodImpl(Inline)]
        public static implicit operator I(uint src)
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
        public Imm32(uint src)
            => Data = src;

        [MethodImpl(Inline)]
        public string Format()
            => Hex.format(Data, W);

        public override string ToString()
            => Format();

        public uint Hash
        {
            [MethodImpl(Inline)]
            get => core.hash(Data);
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
        public Address32 ToAddress()
            => Data;

    }
}