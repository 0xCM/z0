// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.
namespace Z0
{
    using System;
    using System.Diagnostics;
    using System.IO;
    using System.Runtime.InteropServices;
    using Windows;


    public readonly struct DumpEmitter
    {
        const int ERROR_PARTIAL_COPY = unchecked((int)0x8007012b);

        public static void emit(Process process, string outputFile, DumpTypeOption type)
        {
            // Open the file for writing
            using (var stream = new FileStream(outputFile, FileMode.Create, FileAccess.ReadWrite, FileShare.None))
            {
                MINIDUMP_TYPE dumpType = MINIDUMP_TYPE.MiniDumpNormal;
                switch (type)
                {
                    case DumpTypeOption.Full:
                        dumpType = MINIDUMP_TYPE.MiniDumpWithFullMemory |
                                   MINIDUMP_TYPE.MiniDumpWithDataSegs |
                                   MINIDUMP_TYPE.MiniDumpWithHandleData |
                                   MINIDUMP_TYPE.MiniDumpWithUnloadedModules |
                                   MINIDUMP_TYPE.MiniDumpWithFullMemoryInfo |
                                   MINIDUMP_TYPE.MiniDumpWithThreadInfo |
                                    MINIDUMP_TYPE.MiniDumpWithTokenInformation;
                        break;
                    case DumpTypeOption.Heap:
                        dumpType = MINIDUMP_TYPE.MiniDumpWithPrivateReadWriteMemory |
                                    MINIDUMP_TYPE.MiniDumpWithDataSegs |
                                    MINIDUMP_TYPE.MiniDumpWithHandleData |
                                    MINIDUMP_TYPE.MiniDumpWithUnloadedModules |
                                    MINIDUMP_TYPE.MiniDumpWithFullMemoryInfo |
                                    MINIDUMP_TYPE.MiniDumpWithThreadInfo |
                                    MINIDUMP_TYPE.MiniDumpWithTokenInformation;
                        break;
                    case DumpTypeOption.Mini:
                        dumpType = MINIDUMP_TYPE.MiniDumpWithThreadInfo;
                        break;
                }

                // Retry the write dump on ERROR_PARTIAL_COPY
                for (int i = 0; i < 5; i++)
                {
                    // Dump the process!
                    if (DbgHelp.MiniDumpWriteDump(process.Handle, (uint)process.Id, stream.SafeFileHandle, dumpType, IntPtr.Zero, IntPtr.Zero, IntPtr.Zero))
                    {
                        break;
                    }
                    else
                    {
                        int err = Marshal.GetHRForLastWin32Error();
                        if (err != ERROR_PARTIAL_COPY)
                        {
                            Marshal.ThrowExceptionForHR(err);
                        }
                    }
                }
            }
        }
    }
}