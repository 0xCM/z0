//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    [Flags]
    public enum PageProtection : uint
    {
        Unspecified = 0,

        /// <summary>
        /// Disables all access to the committed region of pages. An attempt to read from, write to, or execute the committed region results in an access violation.
        /// </summary>
        NoAccess = 0x01,

        /// <summary>
        /// Enables read-only access to the committed region of pages
        /// </summary>
        ReadOnly = 0x02,

        /// <summary>
        /// Enables execute access to the committed region of pages. An attempt to write to the committed region results in an access violation. This flag is not supported by the CreateFileMapping function.
        /// </summary>
        Execute = 0x10,

        /// <summary>
        /// Enables execute or read-only access to the committed region of pages. An attempt to write to the committed region results in an access violation.
        /// </summary>
        ExecuteRead = 0x20,

        /// <summary>
        /// Enables execute, read-only, or read/write access to the committed region of pages.
        /// </summary>
        ReadWrite = 0x04,

        /// <summary>
        /// Pages in the region become guard pages. Any attempt to access a guard page causes the system to raise a STATUS_GUARD_PAGE_VIOLATION exception and turn off the guard page status. Guard pages thus act as a one-time access alarm.
        /// </summary>
        Guard = 0x100,

        /// <summary>
        /// Sets all pages to be non-cachable.
        /// </summary>
        NoCache = 0x200,

        WriteCombine = 400,

        ExecuteReadWrite = 0x40,

        /// <summary>
        /// Enables execute, read-only, or copy-on-write access to a mapped view of a file mapping object.
        /// An attempt to write to a committed copy-on-write page results in a private copy of the page being
        /// made for the process. The private page is marked as PAGE_EXECUTE_READWRITE, and the change is
        /// written to the new page. This flag is not supported by the VirtualAlloc or VirtualAllocEx functions
        /// </summary>
        ExecuteWriteCopy = 0x80,

        TargetsInvalid = 0x40000000,

        TargetsNoUpdate = 0x40000000,
    }
}