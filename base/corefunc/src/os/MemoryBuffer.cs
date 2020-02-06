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

    public interface IMemoryBuffer : IDisposable
    {
        /// <summary>
        /// The native handle
        /// </summary>
        IntPtr Handle {get;}

        /// <summary>
        /// The allocation length in bytes
        /// </summary>
        int Length {get;}        

        /// <summary>
        /// Fills the buffer with supplied content
        /// </summary>
        /// <param name="content">The source content</param>
        /// <typeparam name="T">The content cell type</typeparam>
        void Fill<T>(ReadOnlySpan<T> content)
            where T : unmanaged;        

        /// <summary>
        /// Fills the buffer with supplied content
        /// </summary>
        /// <param name="content">The source content</param>
        /// <typeparam name="T">The content cell type</typeparam>
        [MethodImpl(Inline)]
        void Fill<T>(Span<T> content)
            where T : unmanaged        
                => Fill(content.ReadOnly());

        /// <summary>
        /// Fills the buffer with supplied content
        /// </summary>
        /// <param name="content">The source content</param>
        /// <typeparam name="T">The content cell type</typeparam>
        [MethodImpl(Inline)]
        void Fill<T>(T[] content)   
            where T : unmanaged
                => Fill(content.AsSpan().ReadOnly());

        /// <summary>
        /// Zero-fills the buffer
        /// </summary>
        void Clear();

        /// <summary>
        /// Presents buffer content as span of specified cell type
        /// </summary>
        /// <typeparam name="T">The cell type</typeparam>
        Span<T> Data<T>()
            where T : unmanaged;
    }

    /// <summary>
    /// Defines an unmanaged/immovable buffer that requires explicit allocation as disposal
    /// </summary>
    public unsafe readonly struct MemoryBuffer : IMemoryBuffer
    {
        /// <summary>
        /// The global memory reference
        /// </summary>
        public IntPtr Handle {get;}

        /// <summary>
        /// The global memory reference as a byte pointer
        /// </summary>
        readonly byte* pContent;

        /// <summary>
        /// The length, in bytes, of the allocated buffer
        /// </summary>
        public int Length {get;}

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
        /// Zero-fills the buffer
        /// </summary>
        [MethodImpl(Inline)]
        public void Clear()
            => Content.Clear();

        /// <summary>
        /// Presents buffer content as span of specified cell type
        /// </summary>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public Span<T> Data<T>()
            where T : unmanaged
                => Content.As<T>();

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

        // public void Fill<T>(Span<T> content)
        //     where T : unmanaged
        //         => Fill(content.ReadOnly());

        // public void Fill<T>(T[] content)
        //     where T : unmanaged
        //         => Fill(content.AsSpan().ReadOnly());

        public void Dispose()
        {
            Marshal.FreeHGlobal(Handle);
        }
    }
}