//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly ref struct BufferSeq
    {
        readonly BufferAllocation Allocation;

        readonly Span<byte> View;

        readonly Span<BufferToken> Tokens;

        readonly byte BufferCount;

        readonly int BufferSize;

        readonly int TotalSize;

        readonly bool OwnsBuffer;

        /// <summary>
        /// Creates a buffer sequence that owns the underlying memory allocation and releases
        /// it upon disposal
        /// </summary>
        /// <param name="size">The size of each buffer</param>
        /// <param name="count">The number of buffers to allocate</param>
        public static BufferSeq alloc(int size, byte count)
            => new BufferSeq(size, count);

        /// <summary>
        /// Creates a caller-owed buffer sequence
        /// </summary>
        /// <param name="size">The size of each buffer</param>
        /// <param name="count">The number of buffers to allocate</param>
        /// <param name="allocation">The allocation handle that defines ownership</param>
        public static BufferSeq alloc(int size, byte count, out BufferAllocation allocation)
        {            
            var buffers = new BufferSeq(size,count,false);
            allocation = buffers.Allocation;
            return buffers;
        }

        unsafe BufferSeq(int size, byte count, bool owns = true)
        {
            OwnsBuffer = owns;
            BufferCount = count;
            BufferSize = size;
            TotalSize = BufferCount*BufferSize;
            Allocation = Buffers.native(TotalSize);
            View = new Span<byte>(Allocation.Handle.ToPointer(), TotalSize);
            Tokens = Buffers.tokenize(Allocation.Handle, BufferSize, BufferCount);
        }

        /// <summary>
        /// Presents an index-identifed buffer as a span of bytes
        /// </summary>
        /// <param name="index">The buffer index</param>
        [MethodImpl(Inline)]
        public Span<byte> Buffer(byte index)    
            => View.Slice(index*BufferSize, BufferSize);

        /// <summary>
        /// Retrieves an index-identifed token
        /// </summary>
        /// <param name="index">The buffer index</param>
        [MethodImpl(Inline)]
        public ref readonly BufferToken Token(byte index)
            => ref refs.skip(Tokens,index);

        /// <summary>
        /// Retrieves an index-identifed token
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

        /// <summary>
        /// Zero-fills a token-identified buffer and returns the cleared memory content
        /// </summary>
        [MethodImpl(Inline)]
        public Span<byte> Clear(byte index)
        {
            Token(index).Clear();
            return Buffer(index);
        }

        /// <summary>
        /// Covers a token-identified buffer with a span over cells of unmanaged type
        /// </summary>
        /// <param name="index">The buffer index</param>
        [MethodImpl(Inline)]
        public unsafe Span<T> Cells<T>(byte index)
            where T : unmanaged
                =>  Buffer(index).As<T>();

        /// <summary>
        /// Fills a token-identifed buffer with content from a source span and returns the covering span
        /// </summary>
        /// <param name="index">The buffer index</param>
        /// <param name="src">The source content</param>
        /// <typeparam name="T">The content cell type</typeparam>
        [MethodImpl(Inline)]
        public Span<T> Fill<T>(byte index, ReadOnlySpan<T> src)
            where T : unmanaged
                => Token(index).Fill(src);

        [MethodImpl(Inline)]
        public BufferTokens Tokenize() 
            => Tokens.ToArray().Map(t => t as IBufferToken);

        public void Dispose()
        {
            if(OwnsBuffer)   
                Allocation.Dispose();
        }
    }
}