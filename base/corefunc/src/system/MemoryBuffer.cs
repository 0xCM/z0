//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
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
    /// Defines an immovable and unmanaged buffer that requires explicit allocation as disposal
    /// </summary>
    public unsafe readonly ref struct MemoryBuffer
    {
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

        readonly IntPtr pMem;

        readonly Span<byte> content;

        [MethodImpl(Inline)]
        MemoryBuffer(ByteSize size)
        {
            this.pMem = Marshal.AllocHGlobal(size);         
            this.content = new Span<byte>(pMem.ToPointer(), size);
            Clear();
        }

        // [MethodImpl(Inline)]
        // MemoryBuffer(ByteSize size)
        // {
        //     this.source = Marshal.AllocHGlobal(size + 8);         
        //     this.aligned =new IntPtr(16 * ((long)source + 15)/16);
        //     this.content = new Span<byte>(aligned.ToPointer(), size);
        //     Clear();
        // }

        [MethodImpl(Inline)]
        MemoryBuffer(ReadOnlySpan<byte> content)
            : this(content.Length)
        {
            
            Fill(content);
        }

        /// <summary>
        /// Specifies the size of the buffer
        /// </summary>
        public readonly ByteSize Length
        {
            [MethodImpl(Inline)]
            get => content.Length;
        }

        public IntPtr Pointer
            => pMem;

        /// <summary>
        /// Presents buffer content as span of specified cell type
        /// </summary>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public Span<T> As<T>()
            where T : unmanaged
                => content.As<T>();

        /// <summary>
        /// Zero-fills the buffer
        /// </summary>
        [MethodImpl(Inline)]
        public void Clear()
            => content.Clear();

        /// <summary>
        /// The first memory cell in the buffer, presented as a specified type
        /// </summary>
        /// <typeparam name="T">The cell type</typeparam>
        public ref T Head<T>()
            where T :unmanaged
                => ref As<T>()[0];

        /// <summary>
        /// Replaces the buffer content with content from a source span
        /// </summary>
        /// <param name="content">The source content</param>
        /// <typeparam name="T">The cell type</typeparam>
        public void Fill<T>(ReadOnlySpan<T> content)
            where T : unmanaged
        {
            var src = content.AsBytes();
            if(src.Length <=  this.content.Length)
            {
                if(src.Length < this.content.Length)
                    Clear();
                src.CopyTo(this.content);
            }
            else
                src.Slice(Length).CopyTo(this.content);        
        }

        /// <summary>
        /// Copies buffer content to a target span
        /// </summary>
        /// <param name="dst">The target span</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public void CopyTo<T>(Span<T> dst)
            where T : unmanaged
        {
            var src = As<T>();
            var len = Math.Min(dst.Length,src.Length);
            src.CopyTo(dst);
        }

        /// <summary>
        /// Allocates a clone
        /// </summary>
        [MethodImpl(Inline)]
        public MemoryBuffer Replicate()
        {
            var dst = Alloc(Length);
            content.CopyTo(dst.content);
            return dst;
        }

        public void Dispose()
        {
            Marshal.FreeHGlobal(pMem);
        }


    }


}