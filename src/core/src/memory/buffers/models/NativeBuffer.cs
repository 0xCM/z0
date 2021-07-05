
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    using api = Buffers;

    /// <summary>
    /// Represents a native buffer allocation
    /// </summary>
    public readonly struct NativeBuffer : IBufferAllocation
    {
        public IntPtr Handle {get;}

        public ByteSize Size {get;}

        [MethodImpl(Inline)]
        internal NativeBuffer(BufferToken token)
        {
            Handle = token.Handle;
            Size = (uint)token.Size;
        }

        public MemoryAddress Address
        {
            [MethodImpl(Inline)]
            get => Handle;
        }

        public BitWidth Width
        {
            [MethodImpl(Inline)]
            get => Size.Bits;
        }

        [MethodImpl(Inline)]
        public void Clear()
            => Allocated.Clear();

        /// <summary>
        /// Presents the allocation via a span
        /// </summary>
        public unsafe Span<byte> Allocated
        {
            [MethodImpl(Inline)]
            get => api.allocated(this);
        }

        [MethodImpl(Inline)]
        public void Dispose()
            => api.release(this);

        [MethodImpl(Inline)]
        public static implicit operator BufferToken(NativeBuffer src)
            => api.token(src.Address, src.Size);

        [MethodImpl(Inline)]
        public static implicit operator Span<byte>(NativeBuffer src)
            => src.Allocated;

        [MethodImpl(Inline)]
        public static implicit operator IntPtr(NativeBuffer src)
            => src.Handle;

        [MethodImpl(Inline)]
        public static unsafe implicit operator byte*(NativeBuffer src)
            => src.Address.Pointer<byte>();
    }
}