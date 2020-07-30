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

    using Z0.MS;

    /// <summary>
    /// This is an undocumented, untested, and unsupported interface.  Do not use.
    /// </summary>
    unsafe class ClrDataProcess : CallableCOMWrapper
    {
        private static readonly Guid IID_IXCLRDataProcess = new Guid("5c552ab6-fc09-4cb3-8e36-22fa03c798b7");

        private FlushDelegate? _flush;
        
        private GetTaskByOSThreadIDDelegate? _getTask;
        
        private RequestDelegate? _request;
        
        private StartEnumMethodInstancesByAddressDelegate? _startEnum;
        
        private EnumMethodInstanceByAddressDelegate? _enum;
        
        private EndEnumMethodInstancesByAddressDelegate? _endEnum;

        private readonly ZDacLib _library;

        public ClrDataProcess(ZDacLib library, IntPtr pUnknown)
            : base(library?.OwningLibrary, IID_IXCLRDataProcess, pUnknown)
        {
            if (library is null)
                throw new ArgumentNullException(nameof(library));

            _library = library;
        }

        private ref readonly IXCLRDataProcessVtable VTable 
            => ref Unsafe.AsRef<IXCLRDataProcessVtable>(_vtable);

        public ClrDataProcess(ZDacLib library, CallableCOMWrapper toClone) : base(toClone)
        {
            _library = library;
        }

        public ZDac? GetSOSDacInterface()
        {
            var result = QueryInterface(ZDac.IID_ISOSDac);
            if (result == IntPtr.Zero)
                return null;
            try
            {
                return new ZDac(_library, result);
            }
            catch (InvalidOperationException)
            {
                return null;
            }
        }

        public void Flush()
        {
            InitDelegate(ref _flush, VTable.Flush);
            _flush(Self);
        }

        public int Request(uint reqCode, ReadOnlySpan<byte> input, Span<byte> output)
        {
            InitDelegate(ref _request, VTable.Request);

            fixed (byte* pInput = input)
            fixed (byte* pOutput = output)
                return _request(Self, reqCode, input.Length, pInput, output.Length, pOutput);
        }

        // public ClrStackWalk? CreateStackWalk(uint id, uint flags)
        // {
        //     InitDelegate(ref _getTask, VTable.GetTaskByOSThreadID);

        //     int hr = _getTask(Self, id, out IntPtr pUnkTask);
        //     if (hr != S_OK)
        //         return null;

        //     using ClrDataTask dataTask = new ClrDataTask(_library, pUnkTask);
            
        //     // There's a bug in certain runtimes where we will fail to release data deep in the runtime
        //     // when a C++ exception occurs while constructing a ClrDataStackWalk.  This is a workaround
        //     // for the largest of the leaks caused by this issue.
        //     //     https://github.com/Microsoft/clrmd/issues/47
        //     int count = AddRef();
        //     ClrStackWalk? res = dataTask.CreateStackWalk(_library, flags);
        //     int released = Release();
        //     if (released == count && res is null)
        //         Release();
        //     return res;
        // }

        public IEnumerable<ClrDataMethod> EnumerateMethodInstancesByAddress(ulong addr)
        {
            InitDelegate(ref _startEnum, VTable.StartEnumMethodInstancesByAddress);
            InitDelegate(ref _enum, VTable.EnumMethodInstanceByAddress);
            InitDelegate(ref _endEnum, VTable.EndEnumMethodInstancesByAddress);

            List<ClrDataMethod> result = new List<ClrDataMethod>(1);

            int hr = _startEnum(Self, addr, IntPtr.Zero, out ulong handle);
            if (hr != S_OK)
                return result;

            try
            {
                while ((hr = _enum(Self, ref handle, out IntPtr method)) == S_OK)
                    result.Add(new ClrDataMethod(_library, method));
            }
            finally
            {
                _endEnum(Self, handle);
            }

            return result;
        }

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate int StartEnumMethodInstancesByAddressDelegate(IntPtr self, ulong address, IntPtr appDomain, out ulong handle);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate int EnumMethodInstanceByAddressDelegate(IntPtr self, ref ulong handle, out IntPtr method);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate int EndEnumMethodInstancesByAddressDelegate(IntPtr self, ulong handle);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate int RequestDelegate(IntPtr self, uint reqCode, int inBufferSize, byte* inBuffer, int outBufferSize, byte* outBuffer);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate int FlushDelegate(IntPtr self);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate int GetTaskByOSThreadIDDelegate(IntPtr self, uint id, out IntPtr pUnknownTask);
    }
}