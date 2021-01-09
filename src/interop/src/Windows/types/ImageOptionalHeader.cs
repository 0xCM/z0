// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace Windows
{
    using System;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Explicit)]
    public struct ImageOptionalHeader
    {
        [FieldOffset(0)]
        public ushort Magic;

        [FieldOffset(56)]
        public int SizeOfImage;
    }

    // In general, for all structures below which contains a pointer (represented here by IntPtr),
    // the pointers refer to memory in the address space of the process from which the original
    // structure was read.  While this seems obvious, it means we cannot provide an elegant
    // interface to the various fields in the structure due to the de-reference requiring a
    // handle to the target process.  Instead, that functionality needs to be provided at a
    // higher level.
    // Additionally, since we usually explicitly define the fields that we're interested in along
    // with their respective offsets, we frequently specify the exact size of the native structure.

    // Win32 RTL_USER_PROCESS_PARAMETERS structure.
    [StructLayout(LayoutKind.Explicit, Size = 72)]
    public struct RTL_USER_PROCESS_PARAMETERS
    {
        [FieldOffset(56)]
        public UNICODE_STRING ImagePathName;

        [FieldOffset(64)]
        public UNICODE_STRING CommandLine;
    };

    // Win32 PEB structure.  Represents the process environment block of a process.
    [StructLayout(LayoutKind.Explicit, Size = 472)]
    public struct PEB
    {
        [FieldOffset(2), MarshalAs(UnmanagedType.U1)]
        public bool IsBeingDebugged;

        [FieldOffset(12)]
        public IntPtr Ldr;

        [FieldOffset(16)]
        public IntPtr ProcessParameters;

        [FieldOffset(468)]
        public uint SessionId;
    };


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct SHFILEINFO
    {
        // C# doesn't support overriding the default constructor of value types, so we need to use
        // a dummy constructor.
        public SHFILEINFO(bool dummy)
        {
            hIcon = IntPtr.Zero;
            iIcon = 0;
            dwAttributes = 0;
            szDisplayName = "";
            szTypeName = "";
        }

        public IntPtr hIcon;

        public int iIcon;

        public uint dwAttributes;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
        public string szDisplayName;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 80)]
        public string szTypeName;
    };
}
