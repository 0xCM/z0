//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{

    using System;
    using System.Threading;

    partial struct ClrDataModel
    {
        /// <summary>
        /// The basic VTable for an IUnknown interface.
        /// </summary>
        public struct IUnknownVTable
        {
            public IntPtr QueryInterface;
            public IntPtr AddRef;
            public IntPtr Release;
        }

        public sealed class RefCountedFreeLibrary
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
                    DataTarget.PlatformFunctions.FreeLibrary(_library);

                return count;
            }
        }
    }
}