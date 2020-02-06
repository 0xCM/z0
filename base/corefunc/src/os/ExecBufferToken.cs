
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
    /// Describes an execution buffer without ownership semantics
    /// </summary>
    public readonly struct ExecBufferToken
    {                
        public readonly IntPtr Handle;

        public readonly int Length;

        [MethodImpl(Inline)]
        public static implicit operator ExecBufferToken((IntPtr handle, int length) src)
            => new ExecBufferToken(src.handle, src.length);

        [MethodImpl(Inline)]
        public static implicit operator IntPtr(ExecBufferToken src)
            => src.Handle;

        [MethodImpl(Inline)]
        public ExecBufferToken(IntPtr handle, int length)
        {
            this.Handle = handle;
            this.Length = length;
        }        
    }
}