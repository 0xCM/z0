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

    partial struct Windows
    {
        partial struct Kernel32
        {

            [DllImport(Libraries.Kernel32, CharSet = CharSet.Unicode, EntryPoint = "FormatMessageW", SetLastError = true, BestFitMapping = true, ExactSpelling = true)]
            public static extern unsafe int FormatMessage(int dwFlags, IntPtr lpSource, uint dwMessageId, int dwLanguageId, void* lpBuffer, int nSize, IntPtr arguments);


            [DllImport(Libraries.Kernel32, CharSet = CharSet.Unicode, SetLastError = true, BestFitMapping = true)]
            public static extern unsafe int FormatMessage(int dwFlags, SafeLibraryHandle lpSource, uint dwMessageId, int dwLanguageId, [Out] char[] lpBuffer, int nSize, IntPtr[] arguments);
            
            /// <summary>
            ///     Returns a string message for the specified Win32 error code.
            /// </summary>
            public static string GetMessage(int errorCode) 
                => GetMessage(errorCode, IntPtr.Zero);

            public static unsafe string GetMessage(int errorCode, IntPtr moduleHandle)
            {
                int flags = FORMAT_MESSAGE_IGNORE_INSERTS | FORMAT_MESSAGE_FROM_SYSTEM | FORMAT_MESSAGE_ARGUMENT_ARRAY;
                if (moduleHandle != IntPtr.Zero)
                {
                    flags |= FORMAT_MESSAGE_FROM_HMODULE;
                }

                // First try to format the message into the stack based buffer.  Most error messages willl fit.
                Span<char> stackBuffer = stackalloc char[256]; // arbitrary stack limit
                fixed (char* bufferPtr = stackBuffer)
                {
                    int length = FormatMessage(flags, moduleHandle, unchecked((uint)errorCode), 0, bufferPtr, stackBuffer.Length, IntPtr.Zero);
                    if (length > 0)
                    {
                        return GetAndTrimString(stackBuffer.Slice(0, length));
                    }
                }

                // We got back an error.  If the error indicated that there wasn't enough room to store
                // the error message, then call FormatMessage again, but this time rather than passing in
                // a buffer, have the method allocate one, which we then need to free.
                if (Marshal.GetLastWin32Error() == ERROR_INSUFFICIENT_BUFFER)
                {
                    IntPtr nativeMsgPtr = default;
                    try
                    {
                        int length = FormatMessage(flags | FORMAT_MESSAGE_ALLOCATE_BUFFER, moduleHandle, unchecked((uint)errorCode), 0, &nativeMsgPtr, 0, IntPtr.Zero);
                        if (length > 0)
                        {
                            return GetAndTrimString(new Span<char>((char*)nativeMsgPtr, length));
                        }
                    }
                    finally
                    {
                        Marshal.FreeHGlobal(nativeMsgPtr);
                    }
                }

                // Couldn't get a message, so manufacture one.
                return string.Format("Unknown error (0x{0:x})", errorCode);
            }

            public static string GetAndTrimString(Span<char> buffer)
            {
                int length = buffer.Length;
                while (length > 0 && buffer[length - 1] <= 32)
                {
                    length--; // trim off spaces and non-printable ASCII chars at the end of the resource
                }
                return buffer.Slice(0, length).ToString();
            }
        }
    }
}