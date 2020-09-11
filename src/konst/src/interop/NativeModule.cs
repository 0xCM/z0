//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Security;

    using static Konst;

    [SuppressUnmanagedCodeSecurity]
    public interface INativeModule : IDisposable
    {

    }

    public readonly struct NativeModule : INativeModule
    {
        readonly IntPtr Handle;

        [MethodImpl(Inline)]
        public NativeModule(IntPtr handle)
            => Handle = handle;

        public MemoryAddress Base
        {
            [MethodImpl(Inline)]
            get => Handle;
        }

        public void Dispose()
        {
            if (Handle != IntPtr.Zero)
                OS.FreeLibrary(Handle);
        }
    }
}