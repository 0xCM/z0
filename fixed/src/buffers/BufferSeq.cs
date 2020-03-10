//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Security;

    using static Root;

    public static class BufferSeq
    {
        /// <summary>
        /// Allocates a bufer sequence over segments of fixed type
        /// </summary>
        /// <param name="count">The number of buffers in the sequence</param>
        /// <typeparam name="F">The buffer segment type</typeparam>
        [MethodImpl(Inline)]
        public static BufferSeq<F> alloc<F>(int count)
            where F : unmanaged, IFixed    
                => new BufferSeq<F>(count);

        /// <summary>
        /// Allocates a bufer sequence over segments of width = 128 bits / 16 bytes
        /// </summary>
        /// <param name="count">The number of buffers in the sequence</param>
        /// <typeparam name="F">The buffer segment type</typeparam>
        [MethodImpl(Inline)]
        public static BufferSeq<Fixed128> alloc(N128 width, int count)
            => new BufferSeq<Fixed128>(count);

        /// <summary>
        /// Allocates a bufer sequence over segments of width = 256 bits / 32 bytes
        /// </summary>
        /// <param name="count">The number of buffers in the sequence</param>
        /// <typeparam name="F">The buffer segment type</typeparam>
        [MethodImpl(Inline)]
        public static BufferSeq<Fixed256> alloc(N256 width, int count)
            => new BufferSeq<Fixed256>(count);

        /// <summary>
        /// Allocates a bufer sequence over segments of width = 512 bits / 64 bytes
        /// </summary>
        /// <param name="count">The number of buffers in the sequence</param>
        /// <typeparam name="F">The buffer segment type</typeparam>
        [MethodImpl(Inline)]
        public static BufferSeq<Fixed512> alloc(N512 width, int count)
            => new BufferSeq<Fixed512>(count);

    }

    public readonly ref struct BufferSeq<F>
        where F : unmanaged, IFixed    
    {
        readonly Span<F> View;

        readonly Span<BufferToken> Tokens;

        readonly ExecBuffer Buffered;

        readonly int BufferCount;

        readonly int BufferLength;

        readonly int TotalLength;

        internal unsafe BufferSeq(int count)
        {
            this.BufferCount = count;
            this.BufferLength = default(F).FixedByteCount;
            this.TotalLength = BufferCount*BufferLength;
            this.Buffered = Buffers.alloc(TotalLength);
            this.View = new Span<F>(Buffered.Handle.ToPointer(), BufferCount);
            this.Tokens = BufferToken.Tokenize(Buffered.Handle, BufferLength, BufferCount);
        }

        /// <summary>
        /// The leading buffer
        /// </summary>
        ref F Head
        {
            [MethodImpl(Inline)]
            get => ref MemoryMarshal.GetReference(View);
        }

        /// <summary>
        /// Retrieves the content of an index-identified buffer
        /// </summary>
        /// <param name="index">The buffer index</param>
        [MethodImpl(Inline)]
        public ref F Buffer(int index)    
            => ref seek(ref Head, index);

        /// <summary>
        /// Presents an index-identifed buffer as a span of bytes
        /// </summary>
        /// <param name="index">The buffer index</param>
        [MethodImpl(Inline)]
        public unsafe Span<byte> Bytes(int index)
            => new Span<byte>(Token(index).Handle.ToPointer(), BufferLength);

        /// <summary>
        /// Presents an index-identifed buffer as a span of bytes
        /// </summary>
        /// <param name="index">The buffer index</param>
        public Span<byte> this[int index]
        {
            [MethodImpl(Inline)]
            get => Bytes(index);
        }

        /// <summary>
        /// Retrieves an index-identifed token
        /// </summary>
        /// <param name="index">The buffer index</param>
        [MethodImpl(Inline)]
        public ref readonly BufferToken Token(int index)
            => ref skip(Tokens,index);

        /// <summary>
        /// Zero-fills a token-identified buffer and returns the cleared memory content
        /// </summary>
        [MethodImpl(Inline)]
        public Span<byte> Clear(int index)
        {
            Token(index).Clear();
            return this[index];            
        }

        /// <summary>
        /// Covers a token-identified buffer with a span over cells of unmanaged type
        /// </summary>
        /// <param name="index">The buffer index</param>
        [MethodImpl(Inline)]
        public unsafe Span<T> Cells<T>(int index)
            where T : unmanaged
                => Spans.cover<T>(Token(index).Handle.ToPointer<T>(), BufferLength);

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
            => Buffered.Dispose();
    }

}