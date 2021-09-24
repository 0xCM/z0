//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Root;
    using static core;

    public readonly ref struct NativeCells<F>
        where F : unmanaged
    {
        readonly Span<F> Cover;

        readonly Index<NativeCellToken<F>> Tokens;

        readonly NativeBuffer Allocation;

        readonly byte CellCount;

        readonly uint CellSize;

        readonly uint TotalSize;

        [MethodImpl(Inline)]
        internal unsafe NativeCells(NativeBuffer allocation, byte cellCount, uint cellSize, uint totalSize)
        {
            Allocation = allocation;
            CellSize = cellSize;
            CellCount = cellCount;
            TotalSize = totalSize;
            Cover = new Span<F>(allocation.Handle.ToPointer(), (int)TotalSize);
            Tokens = Buffers.tokenize<F>(Allocation.Handle, CellSize, CellCount);
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
            => new Span<byte>(Token(index).Handle.ToPointer(), (int)CellSize);

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
            => ref Tokens[index];

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