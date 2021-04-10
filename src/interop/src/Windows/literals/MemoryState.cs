// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.
namespace Windows
{
    using System;

    [Flags]
    public enum MemoryState : uint
    {
        /// <summary>
        /// Indicates committed pages for which physical storage has been allocated, either in memory or in the paging file on disk.
        /// </summary>
        MEM_COMMIT = 0x1000,
        /// <summary>
        /// Indicates free pages not accessible to the calling process and available to be allocated.
        /// For free pages, the information in the AllocationBase, AllocationProtect, Protect, and Type members is undefined.
        /// </summary>
        MEM_FREE = 0x10000,
        /// <summary>
        /// Indicates reserved pages where a range of the process's virtual address space is reserved without
        /// any physical storage being allocated.
        /// For reserved pages, the information in the Protect member is undefined.
        /// </summary>
        MEM_RESERVE = 0x2000,
    }
}