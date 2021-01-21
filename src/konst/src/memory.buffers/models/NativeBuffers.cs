//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    /// <summary>
    /// Covers a sequence of allocated buffers
    /// </summary>
    public unsafe readonly ref struct NativeBuffers
    {
        internal readonly NativeBuffer Allocation;

        readonly Span<byte> View;

        readonly Span<BufferToken> Tokens;

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
            View = new Span<byte>(Allocation.Handle.ToPointer(), (int)TotalSize);
            Tokens = Buffers.tokenize(Allocation.Handle, BufferSize, BufferCount);
        }

        /// <summary>
        /// Presents an index-identified buffer as a span of bytes
        /// </summary>
        /// <param name="index">The buffer index</param>
        [MethodImpl(Inline)]
        public Span<byte> Buffer(byte index)
            => z.slice(View, index*BufferSize, BufferSize);

        /// <summary>
        /// Covers a token-identified buffer with a span over cells of unmanaged type
        /// </summary>
        /// <param name="index">The buffer index</param>
        [MethodImpl(Inline)]
        public Span<T> Buffer<T>(byte index)
            where T : unmanaged
                => Buffer(index).Recover<T>();

        /// <summary>
        /// Retrieves an index-identified token
        /// </summary>
        /// <param name="index">The buffer index</param>
        [MethodImpl(Inline)]
        public ref readonly BufferToken Token(byte index)
            => ref z.skip(Tokens,index);

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