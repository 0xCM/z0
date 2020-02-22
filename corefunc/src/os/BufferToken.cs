
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static zfunc;

    /// <summary>
    /// Describes an allocated buffer
    /// </summary>
    public readonly struct BufferToken
    {                
        public readonly IntPtr Handle;

        public readonly int Length;

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