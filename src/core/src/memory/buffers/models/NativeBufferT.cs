
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    using api = Buffers;

    /// <summary>
    /// Represents a native buffer allocation
    /// </summary>
    public readonly struct NativeBuffer<T> : IBufferAllocation
        where T : unmanaged
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
            => Edit.Clear();

        public uint Count
        {
            [MethodImpl(Inline)]
            get => Size/size<T>();
        }

        /// <summary>
        /// Presents the allocation via a span
        /// </summary>
        public Span<T> Edit
        {
            [MethodImpl(Inline)]
            get => api.edit(this);
        }

        [MethodImpl(Inline)]
        public void Dispose()
            => api.release(this);
    }
}