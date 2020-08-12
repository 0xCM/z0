//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.MS
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.InteropServices;
    using System.Threading;

    using static COMHelper;

    public interface ICOMCallableIUnknown
    {
        IUnknownVTable IUnknown {get;}        
        
        int AddRef();
        
        int Release();

        void RegisterInterface(Guid guid, IntPtr clsPtr, List<Delegate> keepAlive);
    }

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

        int ICOMCallableIUnknown.Release() 
            => Release(IUnknownObject);            

        int AddRef(IntPtr self) 
            => Interlocked.Increment(ref Counter);

        /// <summary>
        /// Adds an IUnknown based interface to this COM object.
        /// </summary>
        /// <param name="guid">The GUID of this interface.</param>
        /// <param name="validate">Whether or not to validate the delegates that
        /// used to build this COM interface's methods.</param>
        /// <returns>A VTableBuilder to construct this interface.  Note that until VTableBuilder.Complete
        /// is called, the interface will not be registered.</returns>
        VTableBuilder AddInterface(Guid guid, bool validate)
            => new VTableBuilder(this, guid, validate);

        void ICOMCallableIUnknown.RegisterInterface(Guid guid, IntPtr clsPtr, List<Delegate> keepAlive)
        {
            Interfaces.Add(guid, clsPtr);
            Delegates.AddRange(keepAlive);
        }

        int QueryInterface(IntPtr self, in Guid guid, out IntPtr ptr)
        {
            if (Interfaces.TryGetValue(guid, out IntPtr value))
            {
                Interlocked.Increment(ref Counter);
                ptr = value;
                return S_OK;
            }

            ptr = IntPtr.Zero;
            return E_NOINTERFACE;
        }

        int Release(IntPtr self)
        {
            int count = Interlocked.Decrement(ref Counter);
            if (count <= 0)
            {
                // Only free memory the first time we reach here.
                if (Handle.IsAllocated)
                {
                    foreach (IntPtr ptr in Interfaces.Values)
                    {
                        IntPtr* val = (IntPtr*)ptr;
                        Marshal.FreeHGlobal(*val);
                        Marshal.FreeHGlobal(ptr);
                    }

                    Handle.Free();
                    Interfaces.Clear();
                    Delegates.Clear();
                }
            }

            return count;
        }

        void Init()
        {
            var handle = GCHandle.Alloc(this);
            var interfaces = new Dictionary<Guid,IntPtr>();
            var delegates = new List<Delegate>();

            var vtable = (IUnknownVTable*)Marshal.AllocHGlobal(sizeof(IUnknownVTable)).ToPointer();
            QueryInterfaceDelegate qi = QueryInterface;
            vtable->QueryInterface = Marshal.GetFunctionPointerForDelegate(qi);
            delegates.Add(qi);

            AddRefDelegate addRef = AddRef;
            vtable->AddRef = Marshal.GetFunctionPointerForDelegate(addRef);
            delegates.Add(addRef);

            ReleaseDelegate release = Release;
            vtable->Release = Marshal.GetFunctionPointerForDelegate(release);
            delegates.Add(release);

            var unknown = Marshal.AllocHGlobal(IntPtr.Size);
            *(void**)unknown = vtable;

            interfaces.Add(IUnknownGuid, IUnknownObject);
        }
    }
}