
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Konst;

    /// <summary>
    /// Represents a native buffer allocation
    /// </summary>
    public readonly struct NativeBuffer : IDisposable
    {
        public readonly IntPtr Handle;

        public readonly uint Size;

        [MethodImpl(Inline)]
        public static implicit operator BufferToken(NativeBuffer src)
            => src.Token;

        [MethodImpl(Inline)]
        internal NativeBuffer(BufferToken token)
        {
            Handle = token.Handle;
            Size = (uint)token.Size;
        }

        public BufferToken Token
        {
            [MethodImpl(Inline)]
            get => Buffers.token(Handle, Size);
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
    }
}