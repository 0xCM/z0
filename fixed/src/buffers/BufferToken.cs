
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
    /// Describes an allocated buffer
    /// </summary>
    public readonly struct BufferToken : IBufferToken
    {                
        /// <summary>
        /// Creates an array of tokens that identify a squence of buffers
        /// </summary>
        /// <param name="base">The base address</param>
        /// <param name="width">The width of each represented buffer</param>
        /// <param name="count">The length of the buffer sequence</param>
        public static BufferToken[] Tokenize(IntPtr @base, int width, int count)
        {
            var tokens = new BufferToken[count];
            for(var i=0; i<count; i++)
                tokens[i] = (IntPtr.Add(@base, width*i), width); 
            return tokens;
        }
        
        public IntPtr Handle {get;}

        public int Length {get;}

        [MethodImpl(Inline)]
        public static implicit operator BufferToken((IntPtr handle, int length) src)
            => new BufferToken(src.handle, src.length);

        [MethodImpl(Inline)]
        public static implicit operator IntPtr(BufferToken src)
            => src.Handle;

        [MethodImpl(Inline)]
        public BufferToken(IntPtr handle, int length)
        {
            this.Handle = handle;
            this.Length = length;
        }        
    }
}