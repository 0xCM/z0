//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    using api = AsmBytes;

    public struct AsmHexCode : IDataTypeComparable<AsmHexCode>
    {
        public const byte SizeIndex = 15;

        internal Cell128 Data;

        [MethodImpl(Inline)]
        public AsmHexCode(Cell128 data)
            => Data = data;

        public byte Size
        {
            [MethodImpl(Inline)]
            get => api.size(this);
        }

        public Span<byte> Bytes
        {
            [MethodImpl(Inline)]
            get => api.data(this);
        }

        [MethodImpl(Inline)]
        public ref byte Cell(byte index)
            => ref seek(Bytes,index);

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Data.IsEmpty;
        }
        public ref byte this[byte index]
        {
            [MethodImpl(Inline)]
            get => ref seek(Bytes,index);
        }

        [MethodImpl(Inline)]
        public byte ToUInt8()
            => (byte)Data.Lo;

        [MethodImpl(Inline)]
        public ushort ToUInt16()
            => (ushort)Data.Lo;

        [MethodImpl(Inline)]
        public uint ToUInt32()
            => (uint)Data.Lo;

        [MethodImpl(Inline)]
        public uint ToUInt64()
            => (uint)Data.Lo;

        public override int GetHashCode()
            => api.hash(this);

        [MethodImpl(Inline)]
        public bool Equals(AsmHexCode src)
            => api.eq(this, src);

        public override bool Equals(object src)
            => src is AsmHexCode x && Equals(x);

        public string Format()
            => AsmRender.format(this);

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public int CompareTo(AsmHexCode src)
            => api.compare(this, src);

        [MethodImpl(Inline)]
        public static implicit operator AsmHexCode(BinaryCode src)
            => api.hexcode(src.View);

        [MethodImpl(Inline)]
        public static implicit operator AsmHexCode(ReadOnlySpan<byte> src)
            => api.hexcode(src);

        [MethodImpl(Inline)]
        public static implicit operator AsmHexCode(byte[] src)
            => api.hexcode(src);

        [MethodImpl(Inline)]
        public static implicit operator AsmHexCode(string src)
            => api.parse(src);

        [MethodImpl(Inline)]
        public static bool operator ==(AsmHexCode a, AsmHexCode b)
            => a.Equals(b);

        [MethodImpl(Inline)]
        public static bool operator !=(AsmHexCode a, AsmHexCode b)
            => !a.Equals(b);

        public static AsmHexCode Empty
        {
            [MethodImpl(Inline)]
            get => default;
        }
    }
}