//-----------------------------------------------------------------------------
// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using Microsoft.Win32.SafeHandles;
    using System.Runtime.InteropServices;

    using Z0.MS;
    
    partial struct Windows
    {
        partial struct Kernel32
        {
            public const int LOAD_LIBRARY_AS_DATAFILE = 0x00000002;
            
            public const int LOAD_LIBRARY_SEARCH_SYSTEM32 = 0x00000800;

            [DllImport(WinLibs.Kernel32, CharSet = CharSet.Ansi, BestFitMapping = false)]
            public static extern IntPtr GetProcAddress(SafeLibraryHandle hModule, string lpProcName);

            [DllImport(WinLibs.Kernel32, CharSet = CharSet.Ansi, BestFitMapping = false)]
            public static extern IntPtr GetProcAddress(IntPtr hModule, string lpProcName);

            [DllImport(WinLibs.Kernel32, ExactSpelling = true, SetLastError = true)]
            public static extern bool FreeLibrary(IntPtr hModule);
        
            [DllImport(WinLibs.Kernel32, CharSet = CharSet.Unicode, SetLastError = true)]            
            public static extern IntPtr LoadLibrary(string libFilename);            
            
            [DllImport(WinLibs.Kernel32, ExactSpelling = true, CharSet = CharSet.Unicode, SetLastError = true)]
            public static extern SafeLibraryHandle LoadLibraryExW([In] string lpwLibFileName, [In] IntPtr hFile, [In] uint dwFlags);            

            [DllImport(WinLibs.Kernel32, EntryPoint = "GetModuleHandleW", CharSet = CharSet.Unicode, SetLastError = true)]
            public static extern IntPtr GetModuleHandle(string moduleName);

            [DllImport(WinLibs.Kernel32, CharSet = CharSet.Unicode, SetLastError = true, BestFitMapping = false, EntryPoint = "K32GetModuleBaseNameW")]
            public static extern int GetModuleBaseName(SafeProcessHandle processHandle, IntPtr moduleHandle, [Out] char[] baseName, int size);
            
            [DllImport(WinLibs.Kernel32, CharSet = CharSet.Unicode, SetLastError = true, EntryPoint = "K32GetModuleInformation")]
            static extern bool GetModuleInformation(SafeProcessHandle processHandle, IntPtr moduleHandle, out NtModuleInfo ntModuleInfo, int size);

            public static unsafe bool GetModuleInformation(SafeProcessHandle processHandle, IntPtr moduleHandle, out NtModuleInfo ntModuleInfo) 
                => GetModuleInformation(processHandle, moduleHandle, out ntModuleInfo, sizeof(NtModuleInfo));
        }
    }
}