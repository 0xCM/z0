
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Part;

    /// <summary>
    /// Represents a native buffer allocation
    /// </summary>
    public readonly struct NativeBuffer : IDisposable
    {
        /// <summary>
        /// Allocates a native buffer
        /// </summary>
        /// <param name="size">The buffer length in bytes</param>
        [MethodImpl(Inline), Op]
        public static NativeBuffer alloc(uint size)
            => new NativeBuffer((memory.liberate(Marshal.AllocHGlobal((int)size), (int)size), size));

        public IntPtr Handle {get;}

        public ByteSize Size {get;}

        [MethodImpl(Inline)]
        internal NativeBuffer(BufferToken token)
        {
            Handle = token.Handle;
            Size = (uint)token.Size;
        }

        public BufferToken Token
        {
            [MethodImpl(Inline)]
            get => new BufferToken(Handle, Size);
        }

        /// <summary>
        /// Presents the allocation via a span
        /// </summary>
        public unsafe Span<byte> Data
        {
            [MethodImpl(Inline)]
            get => new Span<byte>(Handle.ToPointer(), (int)Size);
        }

        [MethodImpl(Inline)]
        public void Dispose()
            => Marshal.FreeHGlobal(Handle);

        [MethodImpl(Inline)]
        public static implicit operator BufferToken(NativeBuffer src)
            => src.Token;
    }
}