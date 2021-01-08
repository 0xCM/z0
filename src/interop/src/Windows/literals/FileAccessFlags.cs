// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.
namespace Windows
{
    using System;

    // Flags used for opening a file handle (e.g. in a call to CreateFile), that determine the requested permission level.
    //
    [Flags]
    public enum FileAccessFlags : uint
    {
        GENERIC_WRITE = 0x40000000,

        GENERIC_READ = 0x80000000
    }
}