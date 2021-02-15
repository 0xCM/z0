//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static z;
    using static Spans;

    [ApiComplete]
    public ref struct CpuBuffer
    {
        readonly Span<byte> Data;

        /// <summary>
        /// The number of bytes covered by the buffer
        /// </summary>
        public const uint BufferSize = 32*64;

        /// <summary>
        /// The number of 16-bit elements covered by the buffer
        /// </summary>
        public const uint Buffer16 = BufferSize/2;

        /// <summary>
        /// The number of 32-bit elements covered by the buffer
        /// </summary>
        public const uint Buffer32 = BufferSize/4;

        /// <summary>
        /// The number of 64-bit elements covered by the buffer
        /// </summary>
        public const uint Buffer64 = BufferSize/8;

        /// <summary>
        /// The number of 128-bit elements covered by the buffer
        /// </summary>
        public const uint Buffer128 = BufferSize/16;

        /// <summary>
        /// The number of 256-bit elements covered by the buffer
        /// </summary>
        public const uint Buffer256 = BufferSize/32;

        /// <summary>
        /// The number of 512-bit elements covered by the buffer
        /// </summary>
        public const uint Buffer512 = BufferSize/64;

        public const uint MaxSize = Buffer512/8;

        [MethodImpl(Inline)]
        public CpuBuffer(byte[] data)
            => Data = data;

        public int Length
        {
            [MethodImpl(Inline)]
            get => Data.Length;
        }

        public Span<byte> Content
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        [MethodImpl(Inline)]
        public void Clear(W16 w, byte index)
        {
            first(memory.uint16(Data)) = z16;
        }

        [MethodImpl(Inline), Op]
        public void Clear(W32 w, byte index)
        {
            first(memory.uint32(Data)) = z32;
        }

        [MethodImpl(Inline), Op]
        public void Clear(W64 w, byte index)
        {
            first(memory.uint64(Data)) = z64;
        }

        [MethodImpl(Inline), Op]
        public void Clear(W128 w, byte index)
        {
            first(Content.Recover<byte,Cell128>()) = Cell128.Empty;
        }

        [MethodImpl(Inline), Op]
        public void Clear(W256 w, byte index)
        {
            first(Content.Recover<byte,Cell256>()) = Cell256.Empty;
        }

        [MethodImpl(Inline), Op]
        public void Clear(W512 w, byte index)
        {
            first(Content.Recover<byte,Cell512>()) = Cell512.Empty;
        }

        [MethodImpl(Inline), Op]
        public ref Cell512 Cell(W512 w, byte index)
            => ref seek(Content.Recover<byte,Cell512>(), index);

        [MethodImpl(Inline)]
        uint offset(byte index)
            =>  MaxSize * index;
    }
}