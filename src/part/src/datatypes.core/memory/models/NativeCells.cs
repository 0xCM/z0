//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Part;
    using static memory;

    public readonly ref struct NativeCells<F>
        where F : unmanaged, IDataCell
    {
        readonly Span<F> Cover;

        readonly Span<NativeCellToken<F>> Tokens;

        readonly NativeBuffer Allocation;

        readonly byte BufferCount;

        readonly uint BufferSize;

        readonly uint TotalSize;

        [MethodImpl(Inline)]
        internal unsafe NativeCells(NativeBuffer allocation, byte bufferCount, uint bufferSize, uint totalSize)
        {
            Allocation = allocation;
            BufferSize = bufferSize;
            BufferCount = bufferCount;
            TotalSize = totalSize;
            Cover = new Span<F>(allocation.Handle.ToPointer(), (int)TotalSize);
            Tokens = WinMem.tokenize<F>(Allocation.Handle, BufferSize, BufferCount);
        }

        /// <summary>
        /// The leading buffer
        /// </summary>
        ref F First
        {
            [MethodImpl(Inline)]
            get => ref MemoryMarshal.GetReference(Cover);
        }

        /// <summary>
        /// Retrieves the content of an index-identified buffer
        /// </summary>
        /// <param name="index">The buffer index</param>
        [MethodImpl(Inline)]
        public ref F Buffer(byte index)
            => ref seek(First, index);

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
        public ref readonly NativeCellToken<F> this[byte index]
        {
            [MethodImpl(Inline)]
            get => ref Token(index);
        }

        /// <summary>
        /// Retrieves an index-identified token
        /// </summary>
        /// <param name="index">The buffer index</param>
        [MethodImpl(Inline)]
        public ref readonly NativeCellToken<F> Token(byte index)
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
            => Allocation.Dispose();
    }
}