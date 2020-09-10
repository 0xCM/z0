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
    using System.Threading;
    using System.Runtime.InteropServices;
    using System.Security;

    using static Konst;

    [SuppressUnmanagedCodeSecurity]
    public interface INativeModule
    {
        int AddRef();

        int Release();
    }

    public struct NativeModule : INativeModule
    {
        readonly IntPtr _library;

        int _refCount;

        [MethodImpl(Inline)]
        public NativeModule(IntPtr library)
        {
            _library = library;
            _refCount = 1;
        }

        [MethodImpl(Inline)]
        public int AddRef()
            => Interlocked.Increment(ref _refCount);

        public int Release()
        {
            int count = Interlocked.Decrement(ref _refCount);
            if (count == 0 && _library != IntPtr.Zero)
                OS.FreeLibrary(_library);
            return count;
        }
    }
}