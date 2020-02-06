//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;


    using static zfunc;

    /// <summary>
    /// Defines an unmanaged/immovable buffer that requires explicit allocation and disposal
    /// </summary>
    public unsafe readonly struct NativeBuffer : IDisposable
    {
        readonly ExecBufferToken Buffer;

        public ExecBuffer BufferShare
        {
            [MethodImpl(Inline)]
            get => ExecBuffer.Share(Buffer);
        }

        /// <summary>
        /// Allocates a non-gc'd buffer with user-managed lifecycle
        /// </summary>
        /// <param name="length">The buffer length in bytes</param>
        [MethodImpl(Inline)]
        public static NativeBuffer Alloc(int length)
            => OS.NativeAlloc(length);

        /// <summary>
        /// Takes ownership of a native buffer
        /// </summary>
        /// <param name="handle">The wrapped buffer pointer</param>
        /// <param name="length">The buffer length in bytes</param>
        [MethodImpl(Inline)]
        internal static NativeBuffer Own(ExecBufferToken token)
            => new NativeBuffer(token);        

        [MethodImpl(Inline)]
        NativeBuffer(ExecBufferToken token)
        {
            Buffer = token;
            Buffer.Clear();
        }

        /// <summary>
        /// Replaces the buffer content with content from a source span
        /// </summary>
        /// <param name="content">The source content</param>
        /// <typeparam name="T">The cell type</typeparam>
        public void Fill<T>(ReadOnlySpan<T> content)
            where T : unmanaged
                => Buffer.Fill(content);

        /// <summary>
        /// Fills the buffer with supplied content
        /// </summary>
        /// <param name="content">The source content</param>
        /// <typeparam name="T">The content cell type</typeparam>
        [MethodImpl(Inline)]
        public void Fill<T>(T[] content)   
            where T : unmanaged
                => Fill(content.AsSpan().ReadOnly());

        [MethodImpl(Inline)]
        public void Dispose()
            => OS.Release(Buffer.Handle);
    }
}