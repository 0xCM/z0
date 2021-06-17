namespace Windows
{
    using System;
    using System.Runtime.CompilerServices;

    using static Z0.Root;

    public readonly struct OpenHandle : IDisposable
    {
        [MethodImpl(Inline)]
        public static OpenHandle opened(IntPtr src)
            => new OpenHandle(src);
        public IntPtr Handle {get;}

        [MethodImpl(Inline)]
        public OpenHandle(IntPtr value)
        {
            Handle = value;
        }

        public void Dispose()
        {
            Kernel32.CloseHandle(Handle);
        }

        [MethodImpl(Inline)]
        public static implicit operator IntPtr(OpenHandle src)
            => src.Handle;

        [MethodImpl(Inline)]
        public static implicit operator OpenHandle(IntPtr src)
            => new OpenHandle(src);
    }
}