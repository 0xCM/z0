// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static z;

    [ApiType]
    public struct CellBlock8
    {
        readonly byte[] Data;

        [MethodImpl(Inline)]
        public CellBlock8(byte[] src)
            => Data = src;

        public uint BlockCount
        {
            [MethodImpl(Inline)]
            get => (uint)Data.Length;
        }

        public ref byte First
        {
            [MethodImpl(Inline)]
            get => ref(first(Data));
        }
        public ref byte this[uint index]
        {
            [MethodImpl(Inline)]
            get => ref seek(Data, index);
        }

        public Span<byte> Edit
        {
            [MethodImpl(Inline)]
            get => cover(First, Data.Length);
        }

        public ReadOnlySpan<byte> View
        {
            [MethodImpl(Inline)]
            get => cover(First, Data.Length);
        }

        /// <summary>
        /// Specifies the location of the first cell
        /// </summary>
        public MemoryAddress Address
        {
            [MethodImpl(Inline)]
            get => address(First);
        }
    }
}