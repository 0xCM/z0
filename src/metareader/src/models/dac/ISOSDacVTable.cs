//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Dac
{
    using System;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential)]
    internal readonly struct ISOSDacVTable
    {
        // ThreadStore
        public readonly IntPtr GetThreadStoreData;

        // AppDomains
        public readonly IntPtr GetAppDomainStoreData;
 
        public readonly IntPtr GetAppDomainList;
 
        public readonly IntPtr GetAppDomainData;
 
        public readonly IntPtr GetAppDomainName;
 
        public readonly IntPtr GetDomainFromContext;

        // Assemblies
        public readonly IntPtr GetAssemblyList;

        public readonly IntPtr GetAssemblyData;

        public readonly IntPtr GetAssemblyName;

        // Modules
        public readonly IntPtr GetModule;

        public readonly IntPtr GetModuleData;

        public readonly IntPtr TraverseModuleMap;

        public readonly IntPtr GetAssemblyModuleList;

        public readonly IntPtr GetILForModule;

        // Threads

        public readonly IntPtr GetThreadData;
        
        public readonly IntPtr GetThreadFromThinlockID;
        
        public readonly IntPtr GetStackLimits;

        // MethodDescs

        public readonly IntPtr GetMethodDescData;
 
        public readonly IntPtr GetMethodDescPtrFromIP;
 
        public readonly IntPtr GetMethodDescName;
 
        public readonly IntPtr GetMethodDescPtrFromFrame;
 
        public readonly IntPtr GetMethodDescFromToken;
 
        private readonly IntPtr GetMethodDescTransparencyData;

        // JIT Data
        public readonly IntPtr GetCodeHeaderData;
 
        public readonly IntPtr GetJitManagerList;
 
        public readonly IntPtr GetJitHelperFunctionName;
 
        private readonly IntPtr GetJumpThunkTarget;

        // ThreadPool

        public readonly IntPtr GetThreadpoolData;
 
        public readonly IntPtr GetWorkRequestData;
 
        private readonly IntPtr GetHillClimbingLogEntry;

        // Objects
        public readonly IntPtr GetObjectData;

        public readonly IntPtr GetObjectStringData;

        public readonly IntPtr GetObjectClassName;

        // MethodTable
        public readonly IntPtr GetMethodTableName;

        public readonly IntPtr GetMethodTableData;

        public readonly IntPtr GetMethodTableSlot;

        public readonly IntPtr GetMethodTableFieldData;

        private readonly IntPtr GetMethodTableTransparencyData;

        // EEClass
        public readonly IntPtr GetMethodTableForEEClass;

        // FieldDesc
        public readonly IntPtr GetFieldDescData;

        // Frames
        public readonly IntPtr GetFrameName;

        // PEFiles
        public readonly IntPtr GetPEFileBase;

        public readonly IntPtr GetPEFileName;

        // GC
        public readonly IntPtr GetGCHeapData;

        public readonly IntPtr GetGCHeapList; // svr only

        public readonly IntPtr GetGCHeapDetails; // wks only

        public readonly IntPtr GetGCHeapStaticData;

        public readonly IntPtr GetHeapSegmentData;

        private readonly IntPtr GetOOMData;

        private readonly IntPtr GetOOMStaticData;

        private readonly IntPtr GetHeapAnalyzeData;

        private readonly IntPtr GetHeapAnalyzeStaticData;

        // DomainLocal
        private readonly IntPtr GetDomainLocalModuleData;

        public readonly IntPtr GetDomainLocalModuleDataFromAppDomain;

        public readonly IntPtr GetDomainLocalModuleDataFromModule;

        // ThreadLocal
        public readonly IntPtr GetThreadLocalModuleData;

        // SyncBlock
        public readonly IntPtr GetSyncBlockData;

        private readonly IntPtr GetSyncBlockCleanupData;

        // Handles
        public readonly IntPtr GetHandleEnum;

        public readonly IntPtr GetHandleEnumForTypes;

        private readonly IntPtr GetHandleEnumForGC;

        // EH
        private readonly IntPtr TraverseEHInfo;

        private readonly IntPtr GetNestedExceptionData;

        // StressLog
        public readonly IntPtr GetStressLogAddress;

        // Heaps
        public readonly IntPtr TraverseLoaderHeap;

        public readonly IntPtr GetCodeHeapList;

        public readonly IntPtr TraverseVirtCallStubHeap;

        // Other
        public readonly IntPtr GetUsefulGlobals;

        public readonly IntPtr GetClrWatsonBuckets;

        public readonly IntPtr GetTLSIndex;

        public readonly IntPtr GetDacModuleHandle;

        // COM
        public readonly IntPtr GetRCWData;

        public readonly IntPtr GetRCWInterfaces;

        public readonly IntPtr GetCCWData;

        public readonly IntPtr GetCCWInterfaces;

        private readonly IntPtr TraverseRCWCleanupList;

        // GC Reference Functions
        public readonly IntPtr GetStackReferences;

        public readonly IntPtr GetRegisterName;

        public readonly IntPtr GetThreadAllocData;

        public readonly IntPtr GetHeapAllocData;

        // For BindingDisplay plugin

        public readonly IntPtr GetFailedAssemblyList;
     
        public readonly IntPtr GetPrivateBinPaths;
     
        public readonly IntPtr GetAssemblyLocation;
     
        public readonly IntPtr GetAppDomainConfigFile;
     
        public readonly IntPtr GetApplicationBase;
     
        public readonly IntPtr GetFailedAssemblyData;
     
        public readonly IntPtr GetFailedAssemblyLocation;
     
        public readonly IntPtr GetFailedAssemblyDisplayName;
    }
}