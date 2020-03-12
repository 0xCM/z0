//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public enum BufferSeqId : int
    {
        Left = 0,

        Right = 1
    }

    public readonly ref struct BufferSeq
    {
        public static BufferSeq alloc(int size, int count)
            => new BufferSeq(size,count);

        readonly Span<byte> View;

        readonly Span<BufferToken> Tokens;

        readonly BufferAllocation Allocation;

        readonly int BufferCount;

        readonly int BufferSize;

        readonly int TotalSize;

        unsafe BufferSeq(int size, int count)
        {
            this.BufferCount = count;
            this.BufferSize = size;
            this.TotalSize = BufferCount*BufferSize;
            this.Allocation = Buffers.alloc(TotalSize);
            this.View = new Span<byte>(Allocation.Handle.ToPointer(), TotalSize);
            this.Tokens = BufferToken.Tokenize(Allocation.Handle, BufferSize, BufferCount);
        }

        /// <summary>
        /// Presents an index-identifed buffer as a span of bytes
        /// </summary>
        /// <param name="index">The buffer index</param>
        [MethodImpl(Inline)]
        public Span<byte> Buffer(int index)    
            => View.Slice(index*BufferSize, BufferSize);

        /// <summary>
        /// Retrieves an index-identifed token
        /// </summary>
        /// <param name="index">The buffer index</param>
        [MethodImpl(Inline)]
        public ref readonly BufferToken Token(int index)
            => ref skip(Tokens,index);

        /// <summary>
        /// Retrieves an index-identifed token
        /// </summary>
        /// <param name="index">The buffer index</param>
        public ref readonly BufferToken this[int index]
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
            get => ref Token((int)id);
        }

        /// <summary>
        /// Zero-fills a token-identified buffer and returns the cleared memory content
        /// </summary>
        [MethodImpl(Inline)]
        public Span<byte> Clear(int index)
        {
            Token(index).Clear();
            return Buffer(index);
        }

        /// <summary>
        /// Covers a token-identified buffer with a span over cells of unmanaged type
        /// </summary>
        /// <param name="index">The buffer index</param>
        [MethodImpl(Inline)]
        public unsafe Span<T> Cells<T>(int index)
            where T : unmanaged
                =>  Buffer(index).As<T>();

        /// <summary>
        /// Fills a token-identifed buffer with content from a source span and returns the covering span
        /// </summary>
        /// <param name="index">The buffer index</param>
        /// <param name="src">The source content</param>
        /// <typeparam name="T">The content cell type</typeparam>
        [MethodImpl(Inline)]
        public Span<T> Fill<T>(int index, ReadOnlySpan<T> src)
            where T : unmanaged
                => Token(index).Fill(src);

        public void Dispose()
            => Allocation.Dispose();
    }
}