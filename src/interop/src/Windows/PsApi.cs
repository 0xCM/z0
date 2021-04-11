// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.
namespace Windows
{
    using System;
    using System.Runtime.InteropServices;
    using System.Text;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    public unsafe readonly partial struct PsApi
    {
        const string LibName = "psapi.dll";

        [DllImport(LibName, SetLastError = true), Free]
        public static extern unsafe bool QueryWorkingSet(IntPtr hProcess, WORKING_SET_INFORMATION* workingSetInfo, int workingSetInfoSize);

        [DllImport(LibName, SetLastError = true), Free]
        public static extern int GetMappedFileName(IntPtr hProcess, IntPtr address, StringBuilder lpFileName, int nSize);
    }
}