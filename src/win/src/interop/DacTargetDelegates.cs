//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Dac
{
    using System;
    using System.Runtime.InteropServices;

    using Z0.Image;

    public unsafe readonly struct DacTargetDelegates
    {
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate int GetMetadataDelegate(
            IntPtr self,
            [In][MarshalAs(UnmanagedType.LPWStr)] string fileName,
            int imageTimestamp,
            int imageSize,
            IntPtr mvid,
            uint mdRva,
            uint flags,
            uint bufferSize,
            IntPtr buffer,
            int* dataSize);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate int GetMachineTypeDelegate(IntPtr self, out IMAGE_FILE_MACHINE machineType);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate int GetPointerSizeDelegate(IntPtr self, out int pointerSize);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate int GetImageBaseDelegate(IntPtr self, [In][MarshalAs(UnmanagedType.LPWStr)] string imagePath, out ulong baseAddress);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate int ReadVirtualDelegate(IntPtr self, ClrDataAddress address, IntPtr buffer, int bytesRequested, out int bytesRead);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate int WriteVirtualDelegate(IntPtr self, ClrDataAddress address, IntPtr buffer, uint bytesRequested, out uint bytesWritten);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate int GetTLSValueDelegate(IntPtr self, uint threadID, uint index, out ulong value);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate int SetTLSValueDelegate(IntPtr self, uint threadID, uint index, ClrDataAddress value);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate int GetCurrentThreadIDDelegate(IntPtr self, out uint threadID);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate int GetThreadContextDelegate(IntPtr self, uint threadID, uint contextFlags, int contextSize, IntPtr context);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate int SetThreadContextDelegate(IntPtr self, uint threadID, uint contextSize, IntPtr context);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate int RequestDelegate(IntPtr self, uint reqCode, uint inBufferSize, IntPtr inBuffer, IntPtr outBufferSize, out IntPtr outBuffer);        
    }
}