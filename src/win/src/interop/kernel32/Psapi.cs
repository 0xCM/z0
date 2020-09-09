//-----------------------------------------------------------------------------
// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;
    using System.Text;
    using System.Security;
    using System.Buffers;

    using static Windows.Kernel32;

    partial struct Windows
    {
        public readonly partial struct ProcessApi
        {
            [DllImport(WinLibs.ProcessApi, SetLastError = true), SuppressUnmanagedCodeSecurity]
            public static extern unsafe bool EnumProcesses(int[] lpidProcess, int cb, out int lpcbNeeded);


            [DllImport(WinLibs.ProcessApi, SetLastError = true), SuppressUnmanagedCodeSecurity]
            public static extern bool EnumProcessModules(IntPtr hProcess, [Out] IntPtr[]? lphModule, uint cb, [MarshalAs(UnmanagedType.U4)] out uint lpcbNeeded);

            [DllImport(WinLibs.ProcessApi, CharSet = CharSet.Unicode, SetLastError = true, EntryPoint = "GetModuleFileNameExW"), SuppressUnmanagedCodeSecurity]
            [PreserveSig]
            public static extern uint GetModuleFileNameEx(IntPtr hProcess, IntPtr hModule, [Out] StringBuilder lpFilename, [MarshalAs(UnmanagedType.U4)] int nSize);

        }
    }
}