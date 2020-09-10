//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;
    using System.Collections.Generic;
    using System.Security;
    using System.Threading;

    using static Konst;

    partial struct ComInterop
    {
        [SuppressUnmanagedCodeSecurity]
        public interface ICOMCallableIUnknown
        {
            IUnknownVTable IUnknown {get;}

            int AddRef();

            int Release();

            void RegisterInterface(Guid guid, IntPtr clsPtr, List<Delegate> keepAlive);
        }

        [SuppressUnmanagedCodeSecurity]
        public unsafe interface ICOMCallableIUnknown<F> : ICOMCallableIUnknown
            where F : ICOMCallableIUnknown<F>
        {
            GCHandle Handle {get;}

            IntPtr IUnknownObject {get;}

            Dictionary<Guid,IntPtr> Interfaces {get;}

            List<Delegate> Delegates {get;}

            ref int Counter {get;}

            /// <summary>
            /// Gets the IUnknown VTable for this object.
            /// </summary>
            IUnknownVTable ICOMCallableIUnknown.IUnknown
                => **(IUnknownVTable**)IUnknownObject;

            int ICOMCallableIUnknown.AddRef()
                => Interlocked.Increment(ref Counter);

            int AddRef(IntPtr self)
                => Interlocked.Increment(ref Counter);

            void ICOMCallableIUnknown.RegisterInterface(Guid guid, IntPtr clsPtr, List<Delegate> keepAlive)
            {
                Interfaces.Add(guid, clsPtr);
                Delegates.AddRange(keepAlive);
            }
        }
    }
}