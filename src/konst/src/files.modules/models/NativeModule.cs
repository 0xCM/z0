//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows;

    using static Part;

    public readonly struct NativeModule : INativeModule
    {
        public string Name {get;}

        readonly IntPtr Handle;

        [MethodImpl(Inline)]
        public static implicit operator IntPtr(NativeModule src)
            => src.Handle;

        [MethodImpl(Inline)]
        public NativeModule(string name, IntPtr handle)
        {
            Name = name;
            Handle = handle;
        }

        public MemoryAddress Address
        {
            [MethodImpl(Inline)]
            get => Handle;
        }

        public void Dispose()
        {
            if (Handle != IntPtr.Zero)
                Kernel32.FreeLibrary(Handle);
        }

        [MethodImpl(Inline)]
        public string Format()
            => text.format(RP.PSx2, Address, Name);
    }
}