//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;

    partial struct PeFile
    {
        public enum DEBUG_CLASS_QUALIFIER : uint
        {
            KERNEL_CONNECTION = 0,

            KERNEL_LOCAL = 1,

            KERNEL_EXDI_DRIVER = 2,

            KERNEL_IDNA = 3,

            KERNEL_SMALL_DUMP = 1024,

            KERNEL_DUMP = 1025,

            KERNEL_FULL_DUMP = 1026,

            USER_WINDOWS_PROCESS = 0,

            USER_WINDOWS_PROCESS_SERVER = 1,

            USER_WINDOWS_IDNA = 2,

            USER_WINDOWS_SMALL_DUMP = 1024,

            USER_WINDOWS_DUMP = 1026
        }
    }
}