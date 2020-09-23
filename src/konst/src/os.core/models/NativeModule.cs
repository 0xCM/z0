//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct NativeModule : INativeModule
    {
        public StringRef Name {get;}

        readonly IntPtr Handle;

        [MethodImpl(Inline)]
        public static implicit operator IntPtr(NativeModule src)
            => src.Handle;

        [MethodImpl(Inline)]
        public NativeModule(string name,IntPtr handle)
        {
            Name = name;
            Handle = handle;
        }

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

        [MethodImpl(Inline)]
        public string Format()
            => text.format(RenderPatterns.PSx2, Base, Name);
    }
}