//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.MS
{
    using System;
    using System.Runtime.InteropServices; 

    [StructLayout(LayoutKind.Sequential)]
    public readonly struct IXCLRDataProcessVtable
    {
        public readonly IntPtr Flush;
        
        private readonly IntPtr Unused_StartEnumTasks;
        
        private readonly IntPtr EnumTask;
        
        private readonly IntPtr EndEnumTasks;

        // (uint id, [Out, MarshalAs(UnmanagedType.IUnknown)] out object task);
        public readonly IntPtr GetTaskByOSThreadID;

        private readonly IntPtr GetTaskByUniqueID;
        
        private readonly IntPtr GetFlags;
        
        private readonly IntPtr IsSameObject;
        
        private readonly IntPtr GetManagedObject;
        
        private readonly IntPtr GetDesiredExecutionState;
        
        private readonly IntPtr SetDesiredExecutionState;
        
        private readonly IntPtr GetAddressType;
        
        private readonly IntPtr GetRuntimeNameByAddress;
        
        private readonly IntPtr StartEnumAppDomains;
        
        private readonly IntPtr EnumAppDomain;
        
        private readonly IntPtr EndEnumAppDomains;
        
        private readonly IntPtr GetAppDomainByUniqueID;
        
        private readonly IntPtr StartEnumAssemblie;
        
        private readonly IntPtr EnumAssembly;
        
        private readonly IntPtr EndEnumAssemblies;
        
        private readonly IntPtr StartEnumModules;
        
        private readonly IntPtr EnumModule;
        
        private readonly IntPtr EndEnumModules;
        
        private readonly IntPtr GetModuleByAddress;

        // (ulong address, [In, MarshalAs(UnmanagedType.Interface)] object appDomain, out ulong handle);
        public readonly IntPtr StartEnumMethodInstancesByAddress;

        // (ref ulong handle, [Out, MarshalAs(UnmanagedType.Interface)] out object method);
        public readonly IntPtr EnumMethodInstanceByAddress;

        // (ulong handle);
        public readonly IntPtr EndEnumMethodInstancesByAddress;
        
        private readonly IntPtr GetDataByAddress;
        
        private readonly IntPtr GetExceptionStateByExceptionRecord;
        
        private readonly IntPtr TranslateExceptionRecordToNotification;

        // (uint reqCode, uint inBufferSize, [In, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] byte[] inBuffer, uint outBufferSize, [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)] byte[] outBuffer);
        public readonly IntPtr Request;
    }

    internal interface IXCLRDataProcess_
    {
        void Flush();

        void StartEnumTasks_do_not_use();
        void EnumTask_do_not_use();
        void EndEnumTasks_do_not_use();

        [PreserveSig]
        int GetTaskByOSThreadID(
            uint id,
            [Out][MarshalAs(UnmanagedType.IUnknown)]
            out object task);

        void GetTaskByUniqueID_do_not_use(/*[in] ULONG64 taskID, [out] IXCLRDataTask** task*/);
        
        void GetFlags_do_not_use(/*[out] ULONG32* flags*/);
        
        void IsSameObject_do_not_use(/*[in] IXCLRDataProcess* process*/);
        
        void GetManagedObject_do_not_use(/*[out] IXCLRDataValue** value*/);
        
        void GetDesiredExecutionState_do_not_use(/*[out] ULONG32* state*/);
        
        void SetDesiredExecutionState_do_not_use(/*[in] ULONG32 state*/);
        
        void GetAddressType_do_not_use(/*[in] CLRDATA_ADDRESS address, [out] CLRDataAddressType* type*/);

        void GetRuntimeNameByAddress_do_not_use(

            /*[in] CLRDATA_ADDRESS address, [in] ULONG32 flags, [in] ULONG32 bufLen, [out] ULONG32 *nameLen, [out, size_is(bufLen)] WCHAR nameBuf[], [out] CLRDATA_ADDRESS* displacement*/);

        void StartEnumAppDomains_do_not_use(/*[out] CLRDATA_ENUM* handle*/);
 
        void EnumAppDomain_do_not_use(/*[in, out] CLRDATA_ENUM* handle, [out] IXCLRDataAppDomain** appDomain*/);
 
        void EndEnumAppDomains_do_not_use(/*[in] CLRDATA_ENUM handle*/);
 
        void GetAppDomainByUniqueID_do_not_use(/*[in] ULONG64 id, [out] IXCLRDataAppDomain** appDomain*/);
 
        void StartEnumAssemblie_do_not_uses(/*[out] CLRDATA_ENUM* handle*/);
 
        void EnumAssembly_do_not_use(/*[in, out] CLRDATA_ENUM* handle, [out] IXCLRDataAssembly **assembly*/);
 
        void EndEnumAssemblies_do_not_use(/*[in] CLRDATA_ENUM handle*/);
 
        void StartEnumModules_do_not_use(/*[out] CLRDATA_ENUM* handle*/);
 
        void EnumModule_do_not_use(/*[in, out] CLRDATA_ENUM* handle, [out] IXCLRDataModule **mod*/);
 
        void EndEnumModules_do_not_use(/*[in] CLRDATA_ENUM handle*/);
 
        void GetModuleByAddress_do_not_use(/*[in] CLRDATA_ADDRESS address, [out] IXCLRDataModule** mod*/);

        [PreserveSig]
        int StartEnumMethodInstancesByAddress(
            ulong address,
            [In][MarshalAs(UnmanagedType.Interface)]
            object appDomain,
            out ulong handle);

        [PreserveSig]
        int EnumMethodInstanceByAddress(
            ref ulong handle,
            [Out][MarshalAs(UnmanagedType.Interface)]
            out object method);

        [PreserveSig]
        int EndEnumMethodInstancesByAddress(ulong handle);

        void GetDataByAddress_do_not_use(

            /*[in] CLRDATA_ADDRESS address, [in] ULONG32 flags, [in] IXCLRDataAppDomain* appDomain, [in] IXCLRDataTask* tlsTask, [in] ULONG32 bufLen, [out] ULONG32 *nameLen, [out, size_is(bufLen)] WCHAR nameBuf[], [out] IXCLRDataValue** value, [out] CLRDATA_ADDRESS* displacement*/);

        void GetExceptionStateByExceptionRecord_do_not_use(/*[in] EXCEPTION_RECORD64* record, [out] IXCLRDataExceptionState **exState*/);
 
        void TranslateExceptionRecordToNotification_do_not_use();

        [PreserveSig]
        int Request(
            uint reqCode,
            uint inBufferSize,
            [In][MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)]
            byte[] inBuffer,
            uint outBufferSize,
            [Out][MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)]
            byte[] outBuffer);
    }

}