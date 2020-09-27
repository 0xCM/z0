//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Dac
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    public sealed unsafe class SOSStackRefEnum : CallableCOMWrapper
    {
        static readonly Guid IID_ISOSStackRefEnum = new Guid("8FA642BD-9F10-4799-9AA3-512AE78C77EE");

        readonly Next _next;

        public SOSStackRefEnum(DacLibrary library, IntPtr pUnk)
            : base(library?.OwningLibrary, IID_ISOSStackRefEnum, pUnk)
        {
            ref readonly ISOSStackRefEnumVTable vtable = ref Unsafe.AsRef<ISOSStackRefEnumVTable>(_vtable);
            InitDelegate(ref _next, vtable.Next);
        }

        public int ReadStackReferences(StackRefData[] stackRefs)
        {
            if (stackRefs is null)
                throw new ArgumentNullException(nameof(stackRefs));

            int hr = _next(Self, stackRefs.Length, stackRefs, out int read);
            return hr >= S_OK ? read : 0;
        }

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate int Next(IntPtr self,int count, [Out][MarshalAs(UnmanagedType.LPArray)] StackRefData[] stackRefs, out int pNeeded);
    }
}