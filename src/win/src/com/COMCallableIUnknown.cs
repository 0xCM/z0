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
    using System.Threading;
    using System.Collections.Generic;
    
    /// <summary>
    /// A class that allows you to build a custom IUnknown based interface to pass as a COM object.
    /// This class is public to allow others to use this code and not duplicate it, but it is not
    /// intended for general use.
    /// </summary>
    public unsafe class COMCallableIUnknown : COMHelper, ICOMCallableIUnknown<COMCallableIUnknown>
    {
        readonly GCHandle _handle;

        int _refCount;

        readonly Dictionary<Guid,IntPtr> _interfaces = new Dictionary<Guid, IntPtr>();
        
        readonly List<Delegate> _delegates = new List<Delegate>();

        /// <summary>
        /// Gets the IUnknown pointer to this object.
        /// </summary>
        public IntPtr IUnknownObject { get; }

        /// <summary>
        /// Gets the IUnknown VTable for this object.
        /// </summary>
        public IUnknownVTable IUnknown 
            => **(IUnknownVTable**)IUnknownObject;

        Dictionary<Guid,IntPtr> ICOMCallableIUnknown<COMCallableIUnknown>.Interfaces 
            => _interfaces;

        List<Delegate> ICOMCallableIUnknown<COMCallableIUnknown>.Delegates 
            => _delegates;

        public GCHandle Handle
            => _handle;

        public int RefCount
            => _refCount;

        public ref int Counter
        {
            get => ref _refCount;
        }
        
        /// <summary>
        /// Constructor.
        /// </summary>
        public COMCallableIUnknown()
        {
            _handle = GCHandle.Alloc(this);

            IUnknownVTable* vtable = (IUnknownVTable*)Marshal.AllocHGlobal(sizeof(IUnknownVTable)).ToPointer();
            QueryInterfaceDelegate qi = QueryInterfaceImpl;
            vtable->QueryInterface = Marshal.GetFunctionPointerForDelegate(qi);
            _delegates.Add(qi);

            AddRefDelegate addRef = new AddRefDelegate(AddRefImpl);
            vtable->AddRef = Marshal.GetFunctionPointerForDelegate(addRef);
            _delegates.Add(addRef);

            ReleaseDelegate release = new ReleaseDelegate(ReleaseImpl);
            vtable->Release = Marshal.GetFunctionPointerForDelegate(release);
            _delegates.Add(release);

            IUnknownObject = Marshal.AllocHGlobal(IntPtr.Size);
            *(void**)IUnknownObject = vtable;

            _interfaces.Add(IUnknownGuid, IUnknownObject);
        }

        /// <summary>
        /// AddRef.
        /// </summary>
        /// <returns>The new ref count.</returns>
        public int AddRef() 
            => AddRefImpl(IUnknownObject);

        /// <summary>
        /// Release.
        /// </summary>
        /// <returns>The new RefCount.</returns>
        public int Release() 
            => ReleaseImpl(IUnknownObject);

        /// <summary>
        /// Adds an IUnknown based interface to this COM object.
        /// </summary>
        /// <param name="guid">The GUID of this interface.</param>
        /// <param name="validate">Whether or not to validate the delegates that
        /// used to build this COM interface's methods.</param>
        /// <returns>A VTableBuilder to construct this interface.  Note that until VTableBuilder.Complete
        /// is called, the interface will not be registered.</returns>
        public VTableBuilder AddInterface(Guid guid, bool validate)
        {
            return new VTableBuilder(this, guid, validate);
        }

        public void RegisterInterface(Guid guid, IntPtr clsPtr, List<Delegate> keepAlive)
        {
            _interfaces.Add(guid, clsPtr);
            _delegates.AddRange(keepAlive);
        }

        private int QueryInterfaceImpl(IntPtr self, in Guid guid, out IntPtr ptr)
        {
            if (_interfaces.TryGetValue(guid, out IntPtr value))
            {
                Interlocked.Increment(ref _refCount);
                ptr = value;
                return S_OK;
            }

            ptr = IntPtr.Zero;
            return E_NOINTERFACE;
        }

        private int ReleaseImpl(IntPtr self)
        {
            int count = Interlocked.Decrement(ref _refCount);
            if (count <= 0)
            {
                // Only free memory the first time we reach here.
                if (_handle.IsAllocated)
                {
                    foreach (IntPtr ptr in _interfaces.Values)
                    {
                        IntPtr* val = (IntPtr*)ptr;
                        Marshal.FreeHGlobal(*val);
                        Marshal.FreeHGlobal(ptr);
                    }

                    _handle.Free();
                    _interfaces.Clear();
                    _delegates.Clear();
                }
            }

            return count;
        }

        private int AddRefImpl(IntPtr self) 
            => Interlocked.Increment(ref _refCount);
    }
}