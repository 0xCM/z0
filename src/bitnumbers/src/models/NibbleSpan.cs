//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    using api = BitNumbers;

    [ApiComplete]
    public readonly ref struct NibbleSpan
    {
        readonly Span<byte> Data;

        [MethodImpl(Inline)]
        internal NibbleSpan(Span<byte> data)
        {
            Data = data;
        }

        public ByteSize Size
        {
            [MethodImpl(Inline)]
            get => Data.Length;
        }

        public BitWidth Width
        {
            [MethodImpl(Inline)]
            get => Size.Bits;
        }

        public Span<byte> Bytes
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        public uint Count
        {
            [MethodImpl(Inline)]
            get => api.count(this);
        }

        public int Length
        {
            [MethodImpl(Inline)]
            get => (int)Count;
        }

        public uint4 this[ulong index]
        {
            [MethodImpl(Inline)]
            get => api.read(this, (uint)index);

            [MethodImpl(Inline)]
            set => api.write(value, (uint)index, this);
        }

        public uint4 this[long index]
        {
            [MethodImpl(Inline)]
            get => api.read(this, (uint)index);

            [MethodImpl(Inline)]
            set => api.write(value, (uint)index, this);
        }
    }
}