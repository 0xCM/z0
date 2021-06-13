//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    /// <summary>
    /// Covers a sequence of allocated buffers
    /// </summary>
    public unsafe class NativeBuffers : IDisposable
    {
        /// <summary>
        /// Creates a buffer sequence that owns the underlying memory allocation and releases it upon disposal
        /// </summary>
        /// <param name="size">The size of each buffer</param>
        /// <param name="count">The number of buffers to allocate</param>
        [MethodImpl(Inline), Op]
        public static NativeBuffers alloc(uint size, byte count = 5, bool owns = true)
            => new NativeBuffers(size, count, owns);



        internal readonly NativeBuffer Allocation;

        readonly Index<BufferToken> Tokens;

        readonly byte BufferCount;

        readonly uint BufferSize;

        readonly uint TotalSize;

        readonly bool OwnsBuffer;

        internal NativeBuffers(uint size, byte count, bool owns = true)
        {
            OwnsBuffer = owns;
            BufferCount = count;
            BufferSize = size;
            TotalSize = BufferCount*BufferSize;
            Allocation = Buffers.native(TotalSize);
            Tokens = Buffers.tokenize(Allocation.Handle, BufferSize, BufferCount);
        }

        [MethodImpl(Inline)]
        public Span<byte> Edit(byte index)
            => Buffers.edit(Token(index));

        /// <summary>
        /// Covers a token-identified buffer with a span over cells of unmanaged type
        /// </summary>
        /// <param name="index">The buffer index</param>
        [MethodImpl(Inline)]
        public Span<T> Buffer<T>(byte index)
            where T : unmanaged
                => Edit(index).Recover<T>();

        /// <summary>
        /// Retrieves an index-identified token
        /// </summary>
        /// <param name="index">The buffer index</param>
        [MethodImpl(Inline)]
        public ref readonly BufferToken Token(byte index)
            => ref Tokens[index];

        /// <summary>
        /// Retrieves an index-identified token
        /// </summary>
        /// <param name="index">The buffer index</param>
        public ref readonly BufferToken this[byte index]
        {
            [MethodImpl(Inline)]
            get => ref Token(index);
        }

        /// <summary>
        /// Retrieves a token identified by sequence id
        /// </summary>
        /// <param name="index">The buffer index</param>
        public ref readonly BufferToken this[BufferSeqId id]
        {
            [MethodImpl(Inline)]
            get => ref Token((byte)id);
        }

        [MethodImpl(Inline)]
        public BufferTokens Tokenize()
            => Tokens.ToArray();

        public void Dispose()
        {
            if(OwnsBuffer)
                Allocation.Dispose();
        }
    }
}