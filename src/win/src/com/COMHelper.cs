//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.MS
{
    using System;
    using System.Runtime.InteropServices;

    /// <summary>
    /// Base class for COM related objects in ClrMD.
    /// </summary>
    public abstract class COMHelper
    {
        public const int S_OK = 0;

        public const int E_INVALIDARG = unchecked((int)0x80070057);

        public const int E_FAIL = unchecked((int)0x80004005);

        public const int E_NOTIMPL = unchecked((int)0x80004001);

        public const int E_NOINTERFACE = unchecked((int)0x80004002);

        public static readonly Guid IUnknownGuid = new Guid("00000000-0000-0000-C000-000000000046");

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate int AddRefDelegate(IntPtr self);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate int ReleaseDelegate(IntPtr self);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate int QueryInterfaceDelegate(IntPtr self, in Guid guid, out IntPtr ptr);

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
    }
}