
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Root;

    public readonly struct BufferAllocation : IDisposable
    {
        public readonly IntPtr Handle;

        public readonly int Length;

        [MethodImpl(Inline)]
        public static BufferAllocation Own(BufferToken token)
            => new BufferAllocation(token);

        [MethodImpl(Inline)]
        public static implicit operator BufferToken(BufferAllocation src)
            => src.Token;

        [MethodImpl(Inline)]
        BufferAllocation(BufferToken token)
        {
            this.Handle = token.Handle;
            this.Length = token.Size;
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