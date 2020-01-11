//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;

    using static zfunc;
    using static As;

    /// <summary>
    /// Defines an unmanaged/immovable buffer that requires explicit allocation as disposal
    /// </summary>
    public unsafe readonly struct MemoryBuffer : IDisposable
    {
        /// <summary>
        /// The global memory reference
        /// </summary>
        public readonly IntPtr Handle;

        /// <summary>
        /// The global memory reference as a byte pointer
        /// </summary>
        readonly byte* pContent;

        /// <summary>
        /// The length, in bytes, of the allocated buffer
        /// </summary>
        public readonly int Length;

        /// <summary>
        /// Allocates a a zero-filled unmanged buffer of specified size
        /// </summary>
        /// <param name="size">The buffer size in bytes</param>
        [MethodImpl(Inline)]
        public static MemoryBuffer Alloc(ByteSize size)
            => new MemoryBuffer(size);        

        /// <summary>
        /// Allocates and fills an unmanaged buffer
        /// </summary>
        /// <param name="size">The buffer size in bytes</param>
        [MethodImpl(Inline)]
        public static MemoryBuffer Alloc(ReadOnlySpan<byte> content)
            => new MemoryBuffer(content);        

        [MethodImpl(Inline)]
        MemoryBuffer(int length)
        {
            this.Handle = OS.Liberate(Marshal.AllocHGlobal(length), length);
            this.pContent =  (byte*)Handle.ToPointer();
            this.Length = length;
            Clear();
        }

        [MethodImpl(Inline)]
        MemoryBuffer(ReadOnlySpan<byte> content)
            : this(content.Length)
        {            
            Fill(content);
        }

        Span<byte> Content
        {
            [MethodImpl(Inline)]
            get => span(pContent, Length);
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
        /// The first memory cell in the buffer, presented as a specified type
        /// </summary>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        ref T Head<T>()
            where T :unmanaged
                => ref head(As<T>());

        /// <summary>
        /// Replaces the buffer content with content from a source span
        /// </summary>
        /// <param name="content">The source content</param>
        /// <typeparam name="T">The cell type</typeparam>
        public void Fill<T>(ReadOnlySpan<T> content)
            where T : unmanaged
        {
            var src = content.AsBytes();
            if(src.Length <=  this.Length)
            {
                if(src.Length < this.Length)
                    Clear();
                src.CopyTo(this.Content);
            }
            else
                src.Slice(Length).CopyTo(this.Content);        
        }

        /// <summary>
        /// Replaces buffer content with content from supplied source
        /// </summary>
        /// <param name="content">The source content</param>
        /// <typeparam name="T">The cell type</typeparam>
        public void Fill<T>(T[] content)
            where T : unmanaged
                => Fill(content.AsSpan().ReadOnly());
        
        public void Dispose()
        {
            Marshal.FreeHGlobal(Handle);
        }
    }
}