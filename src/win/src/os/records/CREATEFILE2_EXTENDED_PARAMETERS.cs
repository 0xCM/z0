//-----------------------------------------------------------------------------
// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.
//-----------------------------------------------------------------------------
namespace Z0.MS
{
    using System;
    using System.Runtime.InteropServices;

    [Table]
    public unsafe struct CREATEFILE2_EXTENDED_PARAMETERS
    {
        public uint dwSize;
        
        public uint dwFileAttributes;
        
        public uint dwFileFlags;
        
        public uint dwSecurityQosFlags;
        
        public SECURITY_ATTRIBUTES* lpSecurityAttributes;
        
        public IntPtr hTemplateFile;
    }
}