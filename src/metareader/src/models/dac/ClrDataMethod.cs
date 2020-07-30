//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;
    using System.Runtime.CompilerServices;
    
    using Z0.Dac;
    using Z0.MS;

    public sealed unsafe class ClrDataMethod : CallableCOMWrapper
    {
        private static readonly Guid IID_IXCLRDataMethodInstance = new Guid("ECD73800-22CA-4b0d-AB55-E9BA7E6318A5");

        private GetILAddressMapDelegate? _getILAddressMap;

        public ClrDataMethod(DacLibrary library, IntPtr pUnk)
            : base(library?.OwningLibrary, IID_IXCLRDataMethodInstance, pUnk)
        {
        }

        private ref readonly IXCLRDataMethodInstanceVTable VTable 
            => ref Unsafe.AsRef<IXCLRDataMethodInstanceVTable>(_vtable);

        public ILToNativeMap[]? GetILToNativeMap()
        {
            InitDelegate(ref _getILAddressMap, VTable.GetILAddressMap);

            int hr = _getILAddressMap(Self, 0, out uint needed, null);
            if (hr != S_OK)
                return null;

            ILToNativeMap[] map = new ILToNativeMap[needed];
            hr = _getILAddressMap(Self, needed, out needed, map);

            return hr == S_OK ? map : null;
        }

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int GetILAddressMapDelegate(IntPtr self, uint mapLen, out uint mapNeeded, 
            [Out][MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] ILToNativeMap[]? map);
    }

}