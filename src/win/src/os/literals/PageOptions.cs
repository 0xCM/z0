//-----------------------------------------------------------------------------
// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.
//-----------------------------------------------------------------------------
namespace Z0.MS
{
    public enum PageOptions : byte
    {
        PAGE_READWRITE = 0x04,
        
        PAGE_READONLY = 0x02,
        
        PAGE_WRITECOPY = 0x08,
        
        PAGE_EXECUTE_READ = 0x20,
        
        PAGE_EXECUTE_READWRITE = 0x40,
    }
}