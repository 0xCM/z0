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

    /// <summary>
    /// Defines an unmanaged/immovable buffer that requires explicit allocation and disposal
    /// </summary>
    public readonly ref struct ExecBufferSpan
    {
        /// <summary>
        /// The native allocation reference
        /// </summary>
        public readonly IntPtr Handle;

        /// <summary>
        /// Retrieves the span-covered allocation
        /// </summary>
        [MethodImpl(Inline)]
        public Span<byte> GetContent()
            => Content;

        /// <summary>
        /// The span-covered allocation
        /// </summary>
        readonly Span<byte> Content;

        /// <summary>
        /// The length, in bytes, of the allocated buffer
        /// </summary>
        public readonly int Length
        {
            [MethodImpl(Inline)]
            get => Content.Length;
        }

        internal static ExecBufferSpan Own(IntPtr handle, Span<byte> content)
            => new ExecBufferSpan(handle, content);

        [MethodImpl(Inline)]
        ExecBufferSpan(IntPtr handle, Span<byte> content)
        {
            this.Handle = handle;
            this.Content = content;
        }

        /// <summary>
        /// Presents buffer content as span of specified cell type
        /// </summary>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public Span<T> As<T>()
            where T : unmanaged
                => Content.As<T>();

        /// <summary>
        /// Zero-fills the buffer
        /// </summary>
        [MethodImpl(Inline)]
        public void Clear()
            => Content.Clear();

        /// <summary>
        /// Replaces the buffer content with content from a source span
        /// </summary>
        /// <param name="content">The source content</param>
        /// <typeparam name="T">The cell type</typeparam>
        public void Fill<T>(ReadOnlySpan<T> content)
            where T : unmanaged
        {
            var src = content.AsBytes();
            if(src.Length <=  this.Content.Length)
            {
                if(src.Length < this.Content.Length)
                    Clear();
                src.CopyTo(this.Content);
            }
            else
                src.Slice(Length).CopyTo(this.Content);        
        }

        public void Dispose()
            => buffers.release(Handle); 
    }
}