//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.MS
{
    using System;
    using System.Threading;
        
    public sealed class RefCountedFreeLibrary : IRefCountedFreeLibrary
    {
        private readonly IntPtr _library;
        
        private int _refCount;

        public RefCountedFreeLibrary(IntPtr library)
        {
            _library = library;
            _refCount = 1;
        }

        public int AddRef()
        {
            return Interlocked.Increment(ref _refCount);
        }

        public int Release()
        {
            int count = Interlocked.Decrement(ref _refCount);
            if (count == 0 && _library != IntPtr.Zero)
                WindowsNativeMethods.FreeLibrary(_library);

            return count;
        }
    }
}