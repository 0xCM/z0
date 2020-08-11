//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
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

    internal unsafe class ClrDataTask : CallableCOMWrapper
    {
        private static readonly Guid IID_IXCLRDataTask = new Guid("A5B0BEEA-EC62-4618-8012-A24FFC23934C");

        public ClrDataTask(DacLibrary library, IntPtr pUnk)
            : base(library.OwningLibrary, IID_IXCLRDataTask, pUnk)
        {
        }

        private ref readonly ClrDataTaskVTable VTable   
            => ref Unsafe.AsRef<ClrDataTaskVTable>(_vtable);

        public ClrStackWalk? CreateStackWalk(DacLibrary library, uint flags)
        {
            CreateStackWalkDelegate create = (CreateStackWalkDelegate)Marshal.GetDelegateForFunctionPointer(VTable.CreateStackWalk, typeof(CreateStackWalkDelegate));
            int hr = create(Self, flags, out IntPtr pUnk);
            if (hr != S_OK)
                return null;

            return new ClrStackWalk(library, pUnk);
        }

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int CreateStackWalkDelegate(IntPtr self, uint flags, out IntPtr stackwalk);
    }

    [StructLayout(LayoutKind.Sequential)]
    internal readonly struct ClrDataTaskVTable
    {
        private readonly IntPtr GetProcess;
        
        private readonly IntPtr GetCurrentAppDomain;
        
        private readonly IntPtr GetUniqueID;
        
        private readonly IntPtr GetFlags;
        
        private readonly IntPtr IsSameObject;
        
        private readonly IntPtr GetManagedObject;
        
        private readonly IntPtr GetDesiredExecutionState;
        
        private readonly IntPtr SetDesiredExecutionState;
        
        public readonly IntPtr CreateStackWalk;
        
        private readonly IntPtr GetOSThreadID;
        
        private readonly IntPtr GetContext;
        
        private readonly IntPtr SetContext;
        
        private readonly IntPtr GetCurrentExceptionState;
        
        private readonly IntPtr Request;
        
        private readonly IntPtr GetName;
        
        private readonly IntPtr GetLastExceptionState;
    }    
}