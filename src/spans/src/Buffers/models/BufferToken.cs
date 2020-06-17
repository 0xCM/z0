
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Konst;

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

        [MethodImpl(Inline)]
        public static implicit operator Span<byte>(BufferToken src)
            => src.Content<byte>();

        [MethodImpl(Inline)]
        public static implicit operator BufferToken((IntPtr handle, int size) src)
            => new BufferToken(src.handle, src.size);

        [MethodImpl(Inline)]
        public static implicit operator IntPtr(BufferToken src)
            => src.Handle;

        [MethodImpl(Inline)]
        public BufferToken(IntPtr handle, int length)
        {
            Handle = handle;
            Size = length;
        }        
    }
}