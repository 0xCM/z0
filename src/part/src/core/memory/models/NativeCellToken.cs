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
    /// Describes a fixed-width allocated buffer
    /// </summary>
    public readonly struct NativeCellToken<F> : ICellBufferToken<F>
        where F : unmanaged, IDataCell
    {
        public readonly MemoryAddress Address;

        public readonly uint BufferSize;

        [MethodImpl(Inline)]
        internal NativeCellToken(MemoryAddress address, uint size)
        {
            Address = address;
            BufferSize = size;
        }

        [MethodImpl(Inline)]
        internal NativeCellToken(IntPtr handle, int size)
        {
            Address = handle;
            BufferSize = (uint)size;
        }

        /// <summary>
        /// The location of the represented buffer allocation
        /// </summary>
        public IntPtr Handle
        {
            [MethodImpl(Inline)]
            get => Address;
        }

        /// <summary>
        /// The size, in bytes, of the represented buffer
        /// </summary>
        public int Size
        {
            [MethodImpl(Inline)]
            get => (int)BufferSize;
        }

        /// <summary>
        /// Covers a token-identified buffer with a span
        /// </summary>
        [MethodImpl(Inline)]
        public unsafe Span<T> Content<T>()
            where T : unmanaged
                => core.cover<byte>((byte*)Handle.ToPointer(), (uint)BufferSize).Recover<T>();

        /// <summary>
        /// Fills a token-identified buffer with data from a source span and returns the target memory to the caller as a span
        /// </summary>
        /// <param name="src">The source content</param>
        /// <typeparam name="T">The cell type</typeparam>
        public unsafe Span<T> Fill<T>(ReadOnlySpan<T> src)
            where T : unmanaged
        {
            var dst = this;
            var srcBytes = core.bytes(src);
            var dstBytes = dst.Content<byte>();
            if(srcBytes.Length <= dst.Size)
            {
                if(srcBytes.Length < dst.Size)
                    dstBytes.Clear();

                srcBytes.CopyTo(dstBytes);
            }
            else
                srcBytes.Slice(dst.Size).CopyTo(dstBytes);
            return dst.Content<T>();
        }

        /// <summary>
        /// Zero-fills a token-identified buffer
        /// </summary>
        [MethodImpl(Inline)]
        public Span<byte> Clear()
        {
            var content = Content<byte>();
            content.Clear();
            return content;
        }

        [MethodImpl(Inline)]
        public static implicit operator NativeCellToken<F>((IntPtr handle, int length) src)
            => new NativeCellToken<F>(src.handle, src.length);

        [MethodImpl(Inline)]
        public static implicit operator IntPtr(NativeCellToken<F> src)
            => src.Handle;
    }
}