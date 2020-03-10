
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Root;

    public readonly struct ExecBuffer : IDisposable
    {
        public readonly IntPtr Handle;

        public readonly int Length;

        [MethodImpl(Inline)]
        public static ExecBuffer Own(BufferToken token)
            => new ExecBuffer(token);

        [MethodImpl(Inline)]
        public static implicit operator BufferToken(ExecBuffer src)
            => src.Token;

        [MethodImpl(Inline)]
        ExecBuffer(BufferToken token)
        {
            this.Handle = token.Handle;
            this.Length = token.Length;
        }

        public BufferToken Token
        {
            [MethodImpl(Inline)]
            get => new BufferToken(Handle, Length);
        }

        /// <summary>
        /// Presents the allocation via a span
        /// </summary>
        public unsafe Span<byte> Data
        {
            [MethodImpl(Inline)]
            get => new Span<byte>(Handle.ToPointer(), Length);
        }
        
        [MethodImpl(Inline)]
        public void Dispose()
            => Buffers.release(Handle);
    }
}