//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Image
{
    using System;
    using System.Runtime.InteropServices;

    [Flags]
    public enum DEBUG_FORMAT : uint
    {
        DEFAULT = 0x00000000,
        
        CAB_SECONDARY_ALL_IMAGES = 0x10000000,
        
        WRITE_CAB = 0x20000000,
        CAB_SECONDARY_FILES = 0x40000000,
        
        NO_OVERWRITE = 0x80000000,

        USER_SMALL_FULL_MEMORY = 0x00000001,
        
        USER_SMALL_HANDLE_DATA = 0x00000002,
        
        USER_SMALL_UNLOADED_MODULES = 0x00000004,
        
        USER_SMALL_INDIRECT_MEMORY = 0x00000008,
        
        USER_SMALL_DATA_SEGMENTS = 0x00000010,
        
        USER_SMALL_FILTER_MEMORY = 0x00000020,
        
        USER_SMALL_FILTER_PATHS = 0x00000040,
        
        USER_SMALL_PROCESS_THREAD_DATA = 0x00000080,
        
        USER_SMALL_PRIVATE_READ_WRITE_MEMORY = 0x00000100,
        
        USER_SMALL_NO_OPTIONAL_DATA = 0x00000200,
        
        USER_SMALL_FULL_MEMORY_INFO = 0x00000400,
        
        USER_SMALL_THREAD_INFO = 0x00000800,
        
        USER_SMALL_CODE_SEGMENTS = 0x00001000,
        
        USER_SMALL_NO_AUXILIARY_STATE = 0x00002000,
        
        USER_SMALL_FULL_AUXILIARY_STATE = 0x00004000,
        
        USER_SMALL_IGNORE_INACCESSIBLE_MEM = 0x08000000
    }        
 
}