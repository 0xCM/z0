//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Image
{
    using System;

    [TableField("https://docs.microsoft.com/en-us/windows/win32/api/dbghelp/ns-dbghelp-loaded_image")]
    [Flags]
    public enum LOADED_IMAGE_SCN : ulong
    {
        IMAGE_FILE_RELOCS_STRIPPED         = 0x0001,

        IMAGE_FILE_EXECUTABLE_IMAGE        = 0x0002,

        IMAGE_FILE_LINE_NUMS_STRIPPED      = 0x0004,

        IMAGE_FILE_LOCAL_SYMS_STRIPPED     = 0x0008,

        IMAGE_FILE_AGGRESIVE_WS_TRIM       = 0x0010,

        IMAGE_FILE_LARGE_ADDRESS_AWARE     = 0x0020,

        IMAGE_FILE_BYTES_REVERSED_LO       = 0x0080,

        IMAGE_FILE_32BIT_MACHINE           = 0x0100,

        IMAGE_FILE_DEBUG_STRIPPED          = 0x0200,

        IMAGE_FILE_REMOVABLE_RUN_FROM_SWAP = 0x0400,

        IMAGE_FILE_NET_RUN_FROM_SWAP       = 0x0800,

        IMAGE_FILE_SYSTEM                  = 0x1000,

        IMAGE_FILE_DLL                     = 0x2000,

        IMAGE_FILE_UP_SYSTEM_ONLY          = 0x4000,

        IMAGE_FILE_BYTES_REVERSED_HI       = 0x8000,
    }
}