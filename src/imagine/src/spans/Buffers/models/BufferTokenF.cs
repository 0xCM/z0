//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static As;
    
    /// <summary>
    /// Describes a fixed-width allocated buffer
    /// </summary>
    public readonly struct BufferToken<F> : IBufferToken<F>
        where F : unmanaged, IFixed
    {                
        /// <summary>
        /// The location of the represented buffer allocation
        /// </summary>
        public IntPtr Handle {get;}

        /// <summary>
        /// The size, in bytes, of the represented buffer
        /// </summary>
        public int Size {get;}

        /// <summary>
        /// Creates an array of tokens that identify a squence of buffers
        /// </summary>
        /// <param name="base">The base address</param>
        /// <param name="size">The number of bytes covered by each represented buffer</param>
        /// <param name="count">The length of the buffer sequence</param>
        public static BufferToken<F>[] Tokenize(IntPtr @base, int size, int count)
        {
            var tokens = new BufferToken<F>[count];
            for(var i=0; i<count; i++)
                tokens[i] = (IntPtr.Add(@base, size*i), size); 
            return tokens;
        }
        
        [MethodImpl(Inline)]
        public static implicit operator BufferToken<F>((IntPtr handle, int length) src)
            => new BufferToken<F>(src.handle, src.length);

        [MethodImpl(Inline)]
        public static implicit operator IntPtr(BufferToken<F> src)
            => src.Handle;

        [MethodImpl(Inline)]
        public BufferToken(IntPtr handle, int size)
        {
            Handle = handle;
            Size = size;
        }        

        /// <summary>
        /// Covers a token-identified buffer with a span
        /// </summary>
        [MethodImpl(Inline)]
        public unsafe Span<T> Content<T>()
            where T : unmanaged
                => cover((byte*)Handle.ToPointer(), Size).Cast<T>();

        /// <summary>
        /// Fills a token-identified buffer with data from a source span and returns the target memory to the caller as a span
        /// </summary>
        /// <param name="src">The source content</param>
        /// <typeparam name="T">The cell type</typeparam>
        public unsafe Span<T> Fill<T>(ReadOnlySpan<T> src)
            where T : unmanaged
        {
            var dst = this;
            var srcBytes = src.Bytes();
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
    }
}