
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Seed;

    /// <summary>
    /// Describes an allocated buffer
    /// </summary>
    public readonly struct BufferToken : IBufferToken
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
        /// <param name="size">The number of bytes covered by each buffer</param>
        /// <param name="count">The length of the buffer sequence</param>
        public static BufferToken[] Tokenize(IntPtr @base, int size, int count)
        {
            var tokens = new BufferToken[count];
            for(var i=0; i<count; i++)
                tokens[i] = (IntPtr.Add(@base, size*i), size); 
            return tokens;
        }
        
        [MethodImpl(Inline)]
        public static implicit operator BufferToken((IntPtr handle, int size) src)
            => new BufferToken(src.handle, src.size);

        [MethodImpl(Inline)]
        public static implicit operator IntPtr(BufferToken src)
            => src.Handle;

        [MethodImpl(Inline)]
        public BufferToken(IntPtr handle, int length)
        {
            this.Handle = handle;
            this.Size = length;
        }        
    }
}