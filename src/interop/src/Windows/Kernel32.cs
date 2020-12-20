// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.
namespace Windows
{
    using System;
    using System.Runtime.InteropServices;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    public readonly partial struct Kernel32
    {
        public const string LibName = "kernel32.dll";

        [DllImport(LibName, SetLastError = true), Free]
        public static extern void GetSystemInfo(ref SYSTEM_INFO lpSystemInfo);

        [DllImport(LibName, CharSet = CharSet.Auto, SetLastError = true), Free]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CloseHandle(IntPtr handle);
    }
}