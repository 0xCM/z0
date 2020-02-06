
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static zfunc;

    public readonly ref struct ExecBuffer
    {
        [MethodImpl(Inline)]
        public static ExecBuffer Share(IntPtr handle, int length)
            => new ExecBuffer(handle, length, true);

        // [MethodImpl(Inline)]
        // public static ExecBuffer Own(IntPtr handle, int length)
        //     => new ExecBuffer(handle, length, false);

        [MethodImpl(Inline)]
        public static ExecBuffer Own(ExecBufferToken token)
            => new ExecBuffer(token, false);

        [MethodImpl(Inline)]
        public static ExecBuffer Share(ExecBufferToken token)
            => new ExecBuffer(token, true);

        [MethodImpl(Inline)]
        public static implicit operator ExecBufferToken(ExecBuffer src)
            => src.Token;

        [MethodImpl(Inline)]
        ExecBuffer(IntPtr handle, int length, bool shared)
        {
            this.Handle = handle;
            this.Length = length;
            this.Shared = shared;
        }

        [MethodImpl(Inline)]
        ExecBuffer(ExecBufferToken token, bool shared)
        {
            this.Handle = token.Handle;
            this.Length = token.Length;
            this.Shared = shared;
        }

        public readonly IntPtr Handle;

        public readonly int Length;

        public ExecBufferToken Token
        {
            [MethodImpl(Inline)]
            get => new ExecBufferToken(Handle, Length);
        }
        
        readonly bool Shared;

        [MethodImpl(Inline)]
        public void Dispose()
        {
            if(!Shared)
                OS.Release(Handle);
        }
    }
}