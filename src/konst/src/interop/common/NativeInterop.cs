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

    using static Konst;

    public readonly partial struct NativeInterop
    {
        public interface IRefCountedFreeLibrary
        {
            int AddRef();

            int Release();
        }

        public struct RefCountedFreeLibrary : IRefCountedFreeLibrary
        {
            readonly IntPtr _library;

            int _refCount;

            [MethodImpl(Inline)]
            public RefCountedFreeLibrary(IntPtr library)
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
                    WindowsImports.FreeLibrary(_library);
                return count;
            }
        }
    }
}