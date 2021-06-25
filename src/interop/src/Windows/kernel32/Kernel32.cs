// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.
namespace Windows
{
    using System;
    using System.Runtime.InteropServices;

    using Z0;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [NativeModule(LibName)]
    public readonly partial struct Kernel32
    {
        public const string LibName = "kernel32.dll";

        public string Name => LibName;

        [DllImport(LibName, SetLastError = true), Free]
        public static extern void GetSystemInfo(ref SYSTEM_INFO lpSystemInfo);

        [DllImport(LibName, CharSet = CharSet.Auto, SetLastError = true), Free]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CloseHandle(IntPtr handle);
    }
}