//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Dac
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    /// <summary>
    /// This is an undocumented, untested, and unsupported interface.  Do not use.
    /// </summary>
    public sealed unsafe class SOSDac6 : CallableCOMWrapper
    {
        internal static readonly Guid IID_ISOSDac6 = new Guid("11206399-4B66-4EDB-98EA-85654E59AD45");

        public SOSDac6(DacLibrary library, IntPtr ptr)
            : base(library?.OwningLibrary, IID_ISOSDac6, ptr)
        {
        }

        private ref readonly ISOSDac6VTable VTable 
            => ref Unsafe.AsRef<ISOSDac6VTable>(_vtable);

        public SOSDac6(CallableCOMWrapper toClone) 
            : base(toClone)
        {
        }

        private DacGetMethodTableCollectibleData? _getMethodTableCollectibleData;

        public bool GetMethodTableCollectibleData(ulong mt, out MethodTableCollectibleData data)
        {
            InitDelegate(ref _getMethodTableCollectibleData, VTable.GetMethodTableCollectibleData);
            int hr = _getMethodTableCollectibleData(Self, mt, out data);
            return SUCCEEDED(hr);
        }

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int DacGetMethodTableCollectibleData(IntPtr self, ulong addr, out MethodTableCollectibleData data);
    }

    [StructLayout(LayoutKind.Sequential)]
    internal readonly struct ISOSDac6VTable
    {
        public readonly IntPtr GetMethodTableCollectibleData;
    }

}