
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    /// <summary>
    /// Describes an allocated buffer
    /// </summary>
    public readonly struct BufferToken : IBufferToken
    {
        public MemoryAddress Address {get;}

        public uint BufferSize {get;}

        [MethodImpl(Inline)]
        internal BufferToken(MemoryAddress address, uint size)
        {
            Address = address;
            BufferSize = size;
        }

        /// <summary>
        /// The location of the represented buffer allocation
        /// </summary>
        public IntPtr Handle
            => Address;

        /// <summary>
        /// The size, in bytes, of the represented buffer
        /// </summary>
        public int Size
        {
            [MethodImpl(Inline)]
            get => (int)BufferSize;
        }

        [MethodImpl(Inline)]
        public BufferToken Load(in BinaryCode src)
        {
            memory.load(src, this);
            return this;
        }

        [MethodImpl(Inline)]
        public static implicit operator Span<byte>(BufferToken src)
            => memory.edit(src);

        [MethodImpl(Inline)]
        public static implicit operator BufferToken((IntPtr handle, uint size) src)
            => new BufferToken(src.handle, src.size);

        [MethodImpl(Inline)]
        public static implicit operator IntPtr(BufferToken src)
            => src.Handle;
    }
}