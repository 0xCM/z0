//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.MS
{
    using System;

    public class DacRequests
    {
        public const uint VERSION = 0xe0000000U;
 
        public const uint THREAD_STORE_DATA = 0xf0000000U;
 
        public const uint APPDOMAIN_STORE_DATA = 0xf0000001U;
 
        public const uint APPDOMAIN_LIST = 0xf0000002U;
 
        public const uint APPDOMAIN_DATA = 0xf0000003U;
 
        public const uint APPDOMAIN_NAME = 0xf0000004U;
 
        public const uint APPDOMAIN_APP_BASE = 0xf0000005U;
 
        public const uint APPDOMAIN_PRIVATE_BIN_PATHS = 0xf0000006U;
 
        public const uint APPDOMAIN_CONFIG_FILE = 0xf0000007U;
 
        public const uint ASSEMBLY_LIST = 0xf0000008U;
 
        public const uint FAILED_ASSEMBLY_LIST = 0xf0000009U;
 
        public const uint ASSEMBLY_DATA = 0xf000000aU;
 
        public const uint ASSEMBLY_NAME = 0xf000000bU;
 
        public const uint ASSEMBLY_DISPLAY_NAME = 0xf000000cU;
 
        public const uint ASSEMBLY_LOCATION = 0xf000000dU;
 
        public const uint FAILED_ASSEMBLY_DATA = 0xf000000eU;
 
        public const uint FAILED_ASSEMBLY_DISPLAY_NAME = 0xf000000fU;
 
        public const uint FAILED_ASSEMBLY_LOCATION = 0xf0000010U;
 
        public const uint THREAD_DATA = 0xf0000011U;
 
        public const uint THREAD_THINLOCK_DATA = 0xf0000012U;
 
        public const uint CONTEXT_DATA = 0xf0000013U;
 
        public const uint METHODDESC_DATA = 0xf0000014U;
 
        public const uint METHODDESC_IP_DATA = 0xf0000015U;
 
        public const uint METHODDESC_NAME = 0xf0000016U;
 
        public const uint METHODDESC_FRAME_DATA = 0xf0000017U;
 
        public const uint CODEHEADER_DATA = 0xf0000018U;
 
        public const uint THREADPOOL_DATA = 0xf0000019U;
 
        public const uint WORKREQUEST_DATA = 0xf000001aU;
 
        public const uint OBJECT_DATA = 0xf000001bU;
 
        public const uint FRAME_NAME = 0xf000001cU;
 
        public const uint OBJECT_STRING_DATA = 0xf000001dU;
 
        public const uint OBJECT_CLASS_NAME = 0xf000001eU;
 
        public const uint METHODTABLE_NAME = 0xf000001fU;
 
        public const uint METHODTABLE_DATA = 0xf0000020U;
 
        public const uint EECLASS_DATA = 0xf0000021U;
 
        public const uint FIELDDESC_DATA = 0xf0000022U;
   
        public const uint MANAGEDSTATICADDR = 0xf0000023U;
   
        public const uint MODULE_DATA = 0xf0000024U;
   
        public const uint MODULEMAP_TRAVERSE = 0xf0000025U;
   
        public const uint MODULETOKEN_DATA = 0xf0000026U;
   
        public const uint PEFILE_DATA = 0xf0000027U;
   
        public const uint PEFILE_NAME = 0xf0000028U;
        public const uint ASSEMBLYMODULE_LIST = 0xf0000029U;
        public const uint GCHEAP_DATA = 0xf000002aU;
        public const uint GCHEAP_LIST = 0xf000002bU;
        public const uint GCHEAPDETAILS_DATA = 0xf000002cU;
 
        public const uint GCHEAPDETAILS_STATIC_DATA = 0xf000002dU;
 
        public const uint HEAPSEGMENT_DATA = 0xf000002eU;
 
        public const uint UNITTEST_DATA = 0xf000002fU;
 
        public const uint ISSTUB = 0xf0000030U;
 
        public const uint DOMAINLOCALMODULE_DATA = 0xf0000031U;
 
        public const uint DOMAINLOCALMODULEFROMAPPDOMAIN_DATA = 0xf0000032U;
 
        public const uint DOMAINLOCALMODULE_DATA_FROM_MODULE = 0xf0000033U;
 
        public const uint SYNCBLOCK_DATA = 0xf0000034U;
 
        public const uint SYNCBLOCK_CLEANUP_DATA = 0xf0000035U;
 
        public const uint HANDLETABLE_TRAVERSE = 0xf0000036U;
 
        public const uint RCWCLEANUP_TRAVERSE = 0xf0000037U;
 
        public const uint EHINFO_TRAVERSE = 0xf0000038U;
 
        public const uint STRESSLOG_DATA = 0xf0000039U;
 
        public const uint JITLIST = 0xf000003aU;
 
        public const uint JIT_HELPER_FUNCTION_NAME = 0xf000003bU;
 
        public const uint JUMP_THUNK_TARGET = 0xf000003cU;
 
        public const uint LOADERHEAP_TRAVERSE = 0xf000003dU;
 
        public const uint MANAGER_LIST = 0xf000003eU;
 
        public const uint JITHEAPLIST = 0xf000003fU;
 
        public const uint CODEHEAP_LIST = 0xf0000040U;
 
        public const uint METHODTABLE_SLOT = 0xf0000041U;
 
        public const uint VIRTCALLSTUBHEAP_TRAVERSE = 0xf0000042U;
 
        public const uint NESTEDEXCEPTION_DATA = 0xf0000043U;
 
        public const uint USEFULGLOBALS = 0xf0000044U;
 
        public const uint CLRTLSDATA_INDEX = 0xf0000045U;
 
        public const uint MODULE_FINDIL = 0xf0000046U;
 
        public const uint CLR_WATSON_BUCKETS = 0xf0000047U;
 
        public const uint OOM_DATA = 0xf0000048U;
 
        public const uint OOM_STATIC_DATA = 0xf0000049U;
 
        public const uint GCHEAP_HEAPANALYZE_DATA = 0xf000004aU;
 
        public const uint GCHEAP_HEAPANALYZE_STATIC_DATA = 0xf000004bU;
 
        public const uint HANDLETABLE_FILTERED_TRAVERSE = 0xf000004cU;
 
        public const uint METHODDESC_TRANSPARENCY_DATA = 0xf000004dU;
 
        public const uint EECLASS_TRANSPARENCY_DATA = 0xf000004eU;
 
        public const uint THREAD_STACK_BOUNDS = 0xf000004fU;
 
        public const uint HILL_CLIMBING_LOG_ENTRY = 0xf0000050U;
 
        public const uint THREADPOOL_DATA_2 = 0xf0000051U;
 
        public const uint THREADLOCALMODULE_DAT = 0xf0000052U;
    }

}