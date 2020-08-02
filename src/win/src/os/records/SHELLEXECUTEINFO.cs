//-----------------------------------------------------------------------------
// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.
//-----------------------------------------------------------------------------
namespace Z0.MS
{
    using System;
    using System.Runtime.InteropServices;

    [Record, StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public unsafe struct SHELLEXECUTEINFO
    {
        public uint cbSize;

        public uint fMask;

        public IntPtr hwnd;

        public char* lpVerb;

        public char* lpFile;

        public char* lpParameters;

        public char* lpDirectory;

        public int nShow;

        public IntPtr hInstApp;

        public IntPtr lpIDList;

        public IntPtr lpClass;

        public IntPtr hkeyClass;

        public uint dwHotKey;

        // This is a union of hIcon and hMonitor
        public IntPtr hIconMonitor;

        public IntPtr hProcess;
    }
}