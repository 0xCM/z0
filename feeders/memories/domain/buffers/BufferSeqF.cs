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

    using static Memories;
    using static refs;

    public readonly ref struct BufferSeq<F>
        where F : unmanaged, IFixed    
    {
        readonly Span<F> View;

        readonly Span<BufferToken<F>> Tokens;

        readonly BufferAllocation Buffered;

        readonly int BufferCount;

        readonly int BufferSize;

        readonly int TotalSize;

        public unsafe BufferSeq(int count)
        {
            this.BufferCount = count;
            this.BufferSize = default(F).ByteCount;
            this.TotalSize = BufferCount*BufferSize;
            this.Buffered = Buffers.alloc(TotalSize);
            this.View = new Span<F>(Buffered.Handle.ToPointer(), TotalSize);
            this.Tokens = BufferToken<F>.Tokenize(Buffered.Handle, BufferSize, BufferCount);
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
            => new Span<byte>(Token(index).Handle.ToPointer(), BufferSize);

        /// <summary>
        /// Presents an index-identifed buffer as a span of bytes
        /// </summary>
        /// <param name="index">The buffer index</param>
        public ref readonly BufferToken<F> this[int index]
        {
            [MethodImpl(Inline)]
            get => ref Token(index);
        }

        /// <summary>
        /// Retrieves an index-identifed token
        /// </summary>
        /// <param name="index">The buffer index</param>
        [MethodImpl(Inline)]
        public ref readonly BufferToken<F> Token(int index)
            => ref skip(Tokens,index);

        /// <summary>
        /// Zero-fills a token-identified buffer and returns the cleared memory content
        /// </summary>
        [MethodImpl(Inline)]
        public Span<byte> Clear(int index)
        {
            Token(index).Clear();
            return Bytes(index);
        }

        /// <summary>
        /// Covers a token-identified buffer with a span over cells of unmanaged type
        /// </summary>
        /// <param name="index">The buffer index</param>
        [MethodImpl(Inline)]
        public unsafe Span<T> Cells<T>(int index)
            where T : unmanaged
                => Spans.cover<T>(Token(index).Handle.ToPointer<T>(), BufferSize);

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