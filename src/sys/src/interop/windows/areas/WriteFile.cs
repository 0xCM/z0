//-----------------------------------------------------------------------------
// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.
//-----------------------------------------------------------------------------
namespace Z0
{
    using Microsoft.Win32.SafeHandles;
    using System;
    using System.IO;
    using System.Runtime.InteropServices;
    using System.Diagnostics;

    partial struct Windows
    {
        partial struct Kernel32
        {            
            [DllImport(Libraries.Kernel32, SetLastError = true)]
            public static extern unsafe int WriteFile(IntPtr handle, byte* bytes, int numBytesToWrite, out int numBytesWritten, IntPtr mustBeZero);

            // Note there are two different WriteFile prototypes - this is to use
            // the type system to force you to not trip across a "feature" in
            // Win32's async IO support.  You can't do the following three things
            // simultaneously: overlapped IO, free the memory for the overlapped
            // struct in a callback (or an EndWrite method called by that callback),
            // and pass in an address for the numBytesRead parameter.

            [DllImport(Libraries.Kernel32, SetLastError = true)]
            public static extern unsafe int WriteFile(SafeHandle handle, byte* bytes, int numBytesToWrite, out int numBytesWritten, IntPtr mustBeZero);

        }
    }
}