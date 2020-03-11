//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Security;

    using static Root;

    /// <summary>
    /// Describes a fixed-width allocated buffer
    /// </summary>
    public readonly struct BufferToken<F> : IBufferToken<F>
        where F : unmanaged, IFixed
    {                
        /// <summary>
        /// Creates an array of tokens that identify a squence of buffers
        /// </summary>
        /// <param name="base">The base address</param>
        /// <param name="width">The width of each represented buffer</param>
        /// <param name="count">The length of the buffer sequence</param>
        public static BufferToken<F>[] Tokenize(IntPtr @base, int width, int count)
        {
            var tokens = new BufferToken<F>[count];
            for(var i=0; i<count; i++)
                tokens[i] = (IntPtr.Add(@base, width*i), width); 
            return tokens;
        }
        
        public IntPtr Handle {get;}

        public int Length {get;}

        [MethodImpl(Inline)]
        public static implicit operator BufferToken<F>((IntPtr handle, int length) src)
            => new BufferToken<F>(src.handle, src.length);

        [MethodImpl(Inline)]
        public static implicit operator IntPtr(BufferToken<F> src)
            => src.Handle;

        [MethodImpl(Inline)]
        public BufferToken(IntPtr handle, int length)
        {
            this.Handle = handle;
            this.Length = length;
        }        

        /// <summary>
        /// Covers a token-identified buffer with a span
        /// </summary>
        [MethodImpl(Inline)]
        public unsafe Span<T> Content<T>()
            where T : unmanaged
                => Spans.cover((byte*)Handle.ToPointer(), Length).As<T>();

        /// <summary>
        /// Fills a token-identified buffer with data from a source span and returns the target memory to the caller as a span
        /// </summary>
        /// <param name="src">The source content</param>
        /// <typeparam name="T">The cell type</typeparam>
        public unsafe Span<T> Fill<T>(ReadOnlySpan<T> src)
            where T : unmanaged
        {
            var dst = this;
            var srcBytes = src.AsBytes();
            var dstBytes = dst.Content<byte>();
            if(srcBytes.Length <= dst.Length)
            {
                if(srcBytes.Length < dst.Length)
                    dstBytes.Clear();

                srcBytes.CopyTo(dstBytes);
            }
            else
                srcBytes.Slice(dst.Length).CopyTo(dstBytes);  
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