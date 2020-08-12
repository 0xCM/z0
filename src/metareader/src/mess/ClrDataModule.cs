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

    using Z0.MS;
    
    public sealed unsafe class ClrDataModule : CallableCOMWrapper
    {
        const uint DACDATAMODULEPRIV_REQUEST_GET_MODULEDATA = 0xf0000001;

        static readonly Guid IID_IXCLRDataModule = new Guid("88E32849-0A0A-4cb0-9022-7CD2E9E139E2");

        RequestDelegate? _request;

        public ClrDataModule(DacLibrary library, IntPtr pUnknown)
            : base(library?.OwningLibrary, IID_IXCLRDataModule, pUnknown)
        {
        }

        ref readonly IClrDataModuleVTable VTable 
            => ref Unsafe.AsRef<IClrDataModuleVTable>(_vtable);

        public bool GetModuleData(out ExtendedModuleData data)
        {
            InitDelegate(ref _request, VTable.Request);

            fixed (void* dataPtr = &data)
                if (SUCCEEDED(_request(Self, DACDATAMODULEPRIV_REQUEST_GET_MODULEDATA, 0, null, sizeof(ExtendedModuleData), dataPtr)))
                    return true;

            data = default;
            return false;
        }

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate int RequestDelegate(IntPtr self, uint reqCode, int inBufferSize, void* inBuffer, int outBufferSize, void* outBuffer);


    } 
}