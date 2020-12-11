// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.
namespace Windows
{
    using System;

    [Flags]
    public enum VirtualAllocProtection : uint
    {
        PAGE_NOACCESS = 0x01,

        PAGE_READONLY = 0x02,

        PAGE_READWRITE = 0x04,

        PAGE_WRITECOPY = 0x08,

        PAGE_EXECUTE = 0x10,

        PAGE_EXECUTE_READ = 0x20,

        PAGE_EXECUTE_READWRITE = 0x40,

        PAGE_EXECUTE_WRITECOPY = 0x80,

        PAGE_GUARD = 0x100,

        PAGE_NOCACHE = 0x200,

        PAGE_WRITECOMBINE = 0x400,
    }
}