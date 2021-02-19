//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;
    using static BitMasks.Literals;

    public readonly struct PrimaryOpCode : IDataTypeEquatable<PrimaryOpCode>
    {
        readonly uint Value;

        [MethodImpl(Inline)]
        internal PrimaryOpCode(uint value)
            => Value = value;

        public ReadOnlySpan<byte> Bytes
        {
            [MethodImpl(Inline)]
            get => slice(bytes(Value), 0, Length);
        }

        public byte this[N0 n]
        {
            [MethodImpl(Inline)]
            get => (byte)(Seg32x8x0 & Value);
        }

        public byte this[N1 n]
        {
            [MethodImpl(Inline)]
            get => (byte)((Seg32x8x1 & Value) >> 8);
        }

        public byte this[N2 n]
        {
            [MethodImpl(Inline)]
            get => (byte)((Seg32x8x2 & Value) >> 16);
        }

        public uint2 Length
        {
            [MethodImpl(Inline)]
            get => Bits.effsize(Value);
        }

        public bool IsZero
        {
            [MethodImpl(Inline)]
            get => Value == 0;
        }

        public bool IsNonZero
        {
            [MethodImpl(Inline)]
            get => Value != 0;
        }

        public string Format()
            => Bytes.FormatHex();

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public bool Equals(PrimaryOpCode src)
            => Value == src.Value;

        public override int GetHashCode()
            => (int)Value;

        public override bool Equals(object src)
            => src is PrimaryOpCode x && Equals(x);
    }
}