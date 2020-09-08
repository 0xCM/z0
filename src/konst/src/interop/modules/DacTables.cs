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
    using System.Runtime.CompilerServices;

    using static Konst;
    using static ClrTables;
    using static z;

    struct DacTables
    {
        public readonly struct Fx
        {
            [UnmanagedFunctionPointer(StdCall)]
            public delegate int DacGetFieldData(IntPtr self, ulong addr, out FieldData data);
        }

        public class TableFunctions : IDisposable
        {
            Fx.DacGetFieldData _GetFieldData;

            static void init<T>(ref T t, IntPtr entry)
                where T : Delegate
            {
                if (t != null)
                    return;

                t = (T)Marshal.GetDelegateForFunctionPointer(entry, typeof(T));

            }

            IntPtr[] Pointers;

            public TableFunctions()
            {
                Pointers = sys.alloc<IntPtr>(256);
                var target = span(Pointers);
                ref var dst = ref first(target);
                var i = 0u;
                init(ref _GetFieldData, skip(dst,i++));
            }

            public void Dispose()
            {

            }

            [MethodImpl(Inline)]
            public static bool ok(int hresult)
                => hresult >= 0;

            // ref readonly ISOSDacVTable VTable
            //     => ref @as<ISOSDacVTable>(_vtable);

            // public bool GetFieldData(ulong fieldDesc, out FieldData data)
            // {
            //     init(ref _GetFieldData, VTable.GetFieldDescData);
            //     int hr = _GetFieldData(Self, fieldDesc, out data);
            //     return SUCCEEDED(hr);
            // }

        }

        [Table, StructLayout(LayoutKind.Sequential)]
        public struct ISOSDacVTable
        {
            // ThreadStore
            public IntPtr GetThreadStoreData;

            // AppDomains
            public IntPtr GetAppDomainStoreData;

            public IntPtr GetAppDomainList;

            public IntPtr GetAppDomainData;

            public IntPtr GetAppDomainName;

            public IntPtr GetDomainFromContext;

            // Assemblies
            public IntPtr GetAssemblyList;

            public IntPtr GetAssemblyData;

            public IntPtr GetAssemblyName;

            // Modules
            public IntPtr GetModule;

            public IntPtr GetModuleData;

            public IntPtr TraverseModuleMap;

            public IntPtr GetAssemblyModuleList;

            public IntPtr GetILForModule;

            // Threads

            public IntPtr GetThreadData;

            public IntPtr GetThreadFromThinlockID;

            public IntPtr GetStackLimits;

            // MethodDescs

            public IntPtr GetMethodDescData;

            public IntPtr GetMethodDescPtrFromIP;

            public IntPtr GetMethodDescName;

            public IntPtr GetMethodDescPtrFromFrame;

            public IntPtr GetMethodDescFromToken;

            private IntPtr GetMethodDescTransparencyData;

            // JIT Data
            public IntPtr GetCodeHeaderData;

            public IntPtr GetJitManagerList;

            public IntPtr GetJitHelperFunctionName;

            private IntPtr GetJumpThunkTarget;

            // ThreadPool

            public IntPtr GetThreadpoolData;

            public IntPtr GetWorkRequestData;

            private IntPtr GetHillClimbingLogEntry;

            // Objects
            public IntPtr GetObjectData;

            public IntPtr GetObjectStringData;

            public IntPtr GetObjectClassName;

            // MethodTable
            public IntPtr GetMethodTableName;

            public IntPtr GetMethodTableData;

            public IntPtr GetMethodTableSlot;

            public IntPtr GetMethodTableFieldData;

            private IntPtr GetMethodTableTransparencyData;

            // EEClass
            public IntPtr GetMethodTableForEEClass;

            // FieldDesc
            public IntPtr GetFieldDescData;

            // Frames
            public IntPtr GetFrameName;

            // PEFiles
            public IntPtr GetPEFileBase;

            public IntPtr GetPEFileName;

            // GC
            public IntPtr GetGCHeapData;

            public IntPtr GetGCHeapList; // svr only

            public IntPtr GetGCHeapDetails; // wks only

            public IntPtr GetGCHeapStaticData;

            public IntPtr GetHeapSegmentData;

            private IntPtr GetOOMData;

            private IntPtr GetOOMStaticData;

            private IntPtr GetHeapAnalyzeData;

            private IntPtr GetHeapAnalyzeStaticData;

            // DomainLocal
            private IntPtr GetDomainLocalModuleData;

            public IntPtr GetDomainLocalModuleDataFromAppDomain;

            public IntPtr GetDomainLocalModuleDataFromModule;

            // ThreadLocal
            public IntPtr GetThreadLocalModuleData;

            // SyncBlock
            public IntPtr GetSyncBlockData;

            private IntPtr GetSyncBlockCleanupData;

            // Handles
            public IntPtr GetHandleEnum;

            public IntPtr GetHandleEnumForTypes;

            private IntPtr GetHandleEnumForGC;

            // EH
            private IntPtr TraverseEHInfo;

            private IntPtr GetNestedExceptionData;

            // StressLog
            public IntPtr GetStressLogAddress;

            // Heaps
            public IntPtr TraverseLoaderHeap;

            public IntPtr GetCodeHeapList;

            public IntPtr TraverseVirtCallStubHeap;

            // Other
            public IntPtr GetUsefulGlobals;

            public IntPtr GetClrWatsonBuckets;

            public IntPtr GetTLSIndex;

            public IntPtr GetDacModuleHandle;

            // COM
            public IntPtr GetRCWData;

            public IntPtr GetRCWInterfaces;

            public IntPtr GetCCWData;

            public IntPtr GetCCWInterfaces;

            private IntPtr TraverseRCWCleanupList;

            // GC Reference Functions
            public IntPtr GetStackReferences;

            public IntPtr GetRegisterName;

            public IntPtr GetThreadAllocData;

            public IntPtr GetHeapAllocData;

            // For BindingDisplay plugin

            public IntPtr GetFailedAssemblyList;

            public IntPtr GetPrivateBinPaths;

            public IntPtr GetAssemblyLocation;

            public IntPtr GetAppDomainConfigFile;

            public IntPtr GetApplicationBase;

            public IntPtr GetFailedAssemblyData;

            public IntPtr GetFailedAssemblyLocation;

            public IntPtr GetFailedAssemblyDisplayName;
        }
    }
}