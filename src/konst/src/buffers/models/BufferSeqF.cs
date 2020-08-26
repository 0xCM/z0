//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Konst;
    using static z;

    public readonly ref struct BufferSeq<F>
        where F : unmanaged, IFixed
    {
        readonly Span<F> View;

        readonly Span<BufferToken<F>> Tokens;

        readonly BufferAllocation Buffered;

        readonly byte BufferCount;

        readonly uint BufferSize;

        readonly uint TotalSize;

        public unsafe BufferSeq(byte count)
        {
            BufferCount = count;
            BufferSize = (uint)default(F).ByteCount;
            TotalSize = BufferCount*BufferSize;
            Buffered = Buffers.native(TotalSize);
            View = new Span<F>(Buffered.Handle.ToPointer(), (int)TotalSize);
            Tokens = Buffers.tokenize<F>(Buffered.Handle, BufferSize, BufferCount);
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
        public ref F Buffer(byte index)
            => ref seek(Head, index);

        /// <summary>
        /// Presents an index-identified buffer as a span of bytes
        /// </summary>
        /// <param name="index">The buffer index</param>
        [MethodImpl(Inline)]
        public unsafe Span<byte> Bytes(byte index)
            => new Span<byte>(Token(index).Handle.ToPointer(), (int)BufferSize);

        /// <summary>
        /// Presents an index-identified buffer as a span of bytes
        /// </summary>
        /// <param name="index">The buffer index</param>
        public ref readonly BufferToken<F> this[byte index]
        {
            [MethodImpl(Inline)]
            get => ref Token(index);
        }

        /// <summary>
        /// Retrieves an index-identified token
        /// </summary>
        /// <param name="index">The buffer index</param>
        [MethodImpl(Inline)]
        public ref readonly BufferToken<F> Token(byte index)
            => ref skip(Tokens, index);

        /// <summary>
        /// Zero-fills a token-identified buffer and returns the cleared memory content
        /// </summary>
        [MethodImpl(Inline)]
        public Span<byte> Clear(byte index)
        {
            Token(index).Clear();
            return Bytes(index);
        }

        /// <summary>
        /// Fills a token-identified buffer with content from a source span and returns the covering span
        /// </summary>
        /// <param name="index">The buffer index</param>
        /// <param name="src">The source content</param>
        /// <typeparam name="T">The content cell type</typeparam>
        [MethodImpl(Inline)]
        public Span<T> Fill<T>(byte index, ReadOnlySpan<T> src)
            where T : unmanaged
                => Token(index).Fill(src);

        public void Dispose()
            => Buffered.Dispose();
    }
}