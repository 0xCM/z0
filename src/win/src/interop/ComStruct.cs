//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.MS
{
    using System;
    using System.Runtime.InteropServices;
    using System.Runtime.CompilerServices;

    using static Konst;

    public unsafe struct ComStruct : IDisposable
    {
        const CallingConvention StdCall = CallingConvention.StdCall;

        bool Disposed;

        readonly IntPtr Self;

        readonly IUnknownVTable* VTable;

        readonly RefCountedFreeLibrary Lib;

        void* _vtable  => VTable + 1;

        ReleaseDelegate _release;

        AddRefDelegate _addRef;

        [UnmanagedFunctionPointer(StdCall)]
        delegate int AddRefDelegate(IntPtr self);

        [UnmanagedFunctionPointer(StdCall)]
        delegate int ReleaseDelegate(IntPtr self);

        [UnmanagedFunctionPointer(StdCall)]
        delegate int QueryInterfaceDelegate(IntPtr self, in Guid guid, out IntPtr ptr);        
        
        ComStruct(RefCountedFreeLibrary library, in Guid desiredInterface, IntPtr pUnk)
        {
            Lib = library ?? throw new ArgumentNullException(nameof(library));
            Lib.AddRef();
            Disposed = false;
            var pV = *(IUnknownVTable**)pUnk;

            var qi = (QueryInterfaceDelegate)Marshal.GetDelegateForFunctionPointer(pV->QueryInterface, typeof(QueryInterfaceDelegate));
            int hr = qi(pUnk, desiredInterface, out IntPtr pCorrectUnknown);
            if (hr != 0)
                throw new InvalidCastException($"{typeof(ComStruct).FullName}.QueryInterface({desiredInterface}) failed, hr=0x{hr:x}");

            var release = (ReleaseDelegate)Marshal.GetDelegateForFunctionPointer(pV->Release, typeof(ReleaseDelegate));
            int count = release(pUnk);
            Self = pCorrectUnknown;

            VTable = *(IUnknownVTable**)pCorrectUnknown;
            _addRef = (AddRefDelegate)Marshal.GetDelegateForFunctionPointer(VTable->AddRef, typeof(AddRefDelegate));
            _release = (ReleaseDelegate)Marshal.GetDelegateForFunctionPointer(VTable->Release, typeof(ReleaseDelegate));
        }
 
        /// <summary>
        /// Release an IUnknown pointer.
        /// </summary>
        /// <param name="pUnk">A pointer to the IUnknown interface to release.</param>
        /// <returns>The result of pUnk->Release().</returns>
        public static unsafe int Release(IntPtr pUnk)
        {
            if (pUnk == IntPtr.Zero)
                return 0;

            IUnknownVTable* vtable = *(IUnknownVTable**)pUnk;

            ReleaseDelegate release = (ReleaseDelegate)Marshal.GetDelegateForFunctionPointer(vtable->Release, typeof(ReleaseDelegate));
            return release(pUnk);
        }        

        public static void InitDelegate<T>(ref T t, IntPtr entry)
            where T : Delegate
        {
            if (t != null)
                return;

            t = (T)Marshal.GetDelegateForFunctionPointer(entry, typeof(T));

        }

        public void Dispose()
        {

        }        

    }
}