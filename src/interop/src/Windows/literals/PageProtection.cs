// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.
namespace Windows
{
    using System;

    // Flags that control caching and other behavior of the underlying file object.  Used only for
    // CreateFile.
    [Flags]
    public enum FileFlagsAndAttributes : uint
    {
        NORMAL = 0x80,

        OPEN_REPARSE_POINT = 0x200000,

        SEQUENTIAL_SCAN = 0x8000000,

        RANDOM_ACCESS = 0x10000000,

        NO_BUFFERING = 0x20000000,

        OVERLAPPED = 0x40000000
    }

    // A flag indicating the format of the path string that Windows returns from a call to
    // QueryFullProcessImageName().
    public enum ProcessQueryImageNameMode : uint
    {
        WIN32_FORMAT = 0,

        NATIVE_SYSTEM_FORMAT = 1
    }


    // Determines the amount of information requested (and hence the type of structure returned)
    // by a call to NtQueryInformationProcess.
    public enum PROCESSINFOCLASS : int
    {
        PROCESS_BASIC_INFORMATION = 0
    };

    [Flags]
    public enum PageProtection : uint
    {
        NOACCESS = 0x01,

        READONLY = 0x02,

        READWRITE = 0x04,

        WRITECOPY = 0x08,

        EXECUTE = 0x10,

        EXECUTE_READ = 0x20,

        EXECUTE_READWRITE = 0x40,

        EXECUTE_WRITECOPY = 0x80,

        GUARD = 0x100,

        NOCACHE = 0x200,

        WRITECOMBINE = 0x400,
    }
}