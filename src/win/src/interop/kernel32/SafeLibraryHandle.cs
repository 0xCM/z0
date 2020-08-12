//-----------------------------------------------------------------------------
// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using Microsoft.Win32.SafeHandles;

    partial struct Windows
    {
        partial struct Kernel32
        {
            public sealed class SafeLibraryHandle : SafeHandleZeroOrMinusOneIsInvalid
            {
                public SafeLibraryHandle() : base(true) { }

                protected override bool ReleaseHandle()
                {
                    return FreeLibrary(handle);
                }
            }
        }
    }
}