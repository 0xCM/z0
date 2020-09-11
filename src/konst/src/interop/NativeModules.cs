//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Konst;
    using static z;

    using static OS.Delegates;

    [ApiHost]
    public readonly partial struct NativeModules
    {
        [MethodImpl(Inline), Op]
        static Outcome<DacLib.Module> dac(FS.FilePath src)
            => DacLib.Module.create(src);

        [MethodImpl(Inline), Op]
        public static NativeModule kernel32()
            => new NativeModule(OS.LoadLibrary(Kernel32));

        [MethodImpl(Inline), Op]
        public static NativeModule load(FS.FileName src)
            => new NativeModule(OS.LoadLibrary(src.Name));

        [MethodImpl(Inline), Op]
        public static NativeModule load(FS.FilePath src)
            => new NativeModule(OS.LoadLibrary(src.Name));

        [MethodImpl(Inline), Op]
        public static DllMain main(NativeModule src)
            => proc<DllMain>(src, nameof(OS.Delegates.DllMain));

        [MethodImpl(Inline), Op]
        public static MemoryAddress procaddress(NativeModule src, string name)
            => OS.GetProcAddress(src.Base, name);

        [MethodImpl(Inline), Op]
        public unsafe static FPtr fptr(NativeModule src, string name)
            => new FPtr(OS.GetProcAddress(src.Base,name).ToPointer());

        [MethodImpl(Inline), Op]
        public static unsafe Delegate proc(FPtr src, Type t)
            => Marshal.GetDelegateForFunctionPointer(src,t);

        [MethodImpl(Inline), Op]
        public static Delegate proc(NativeModule src, Type t, string name)
            => Marshal.GetDelegateForFunctionPointer(procaddress(src,name), t);

        [MethodImpl(Inline)]
        public unsafe static FPtr<D> fptr<D>(NativeModule src, string name)
            where D : Delegate
                => new FPtr<D>(OS.GetProcAddress(src.Base,name).ToPointer());

        [MethodImpl(Inline)]
        public static unsafe D proc<D>(FPtr src)
            where D : Delegate
                => (D)Marshal.GetDelegateForFunctionPointer(src,typeof(D));

        [MethodImpl(Inline)]
        public static D proc<D>(NativeModule src, string name)
            where D : Delegate
                =>  (D)Marshal.GetDelegateForFunctionPointer(procaddress(src,name), typeof(D));
    }
}