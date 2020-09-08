//-----------------------------------------------------------------------------
// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Security;
    using System.Runtime.InteropServices;

    using Z0.MS;

    partial struct Windows
    {
        partial struct Kernel32
        {
            [DllImport(WinLibs.Kernel32), SuppressUnmanagedCodeSecurity]
            public static extern uint GetTickCount();

            /// <summary>
            /// Converts a file time to system time format. System time is based on Coordinated Universal Time (UTC).
            /// </summary>
            /// <param name="lpFileTime">
            /// A pointer to a <see cref="FILETIME"/> structure containing the file time to be converted to system (UTC) date and time format.
            /// This value must be less than 0x8000000000000000. Otherwise, the function fails.
            /// </param>
            /// <param name="lpSystemTime">A pointer to a <see cref="SYSTEMTIME"/> structure to receive the converted file time.</param>
            /// <returns>
            /// If the function succeeds, the return value is nonzero.
            /// If the function fails, the return value is zero. To get extended error information, call <see cref="Marshal.GetLastWin32Error"/>.
            /// </returns>
            [DllImport(WinLibs.Kernel32, SetLastError = true), SuppressUnmanagedCodeSecurity]
            public static extern unsafe bool FileTimeToSystemTime(FILETIME* lpFileTime, SYSTEMTIME* lpSystemTime);

            /// <summary>
            /// Converts a system time to file time format. System time is based on Coordinated Universal Time (UTC).
            /// </summary>
            /// <param name="lpSystemTime">
            /// A pointer to a <see cref="SYSTEMTIME"/> structure that contains the system time to be converted from UTC to file time format.
            /// The <see cref="SYSTEMTIME.wDayOfWeek"/> member of the <see cref="SYSTEMTIME"/> structure is ignored.
            /// </param>
            /// <param name="lpFileTime">A pointer to a <see cref="FILETIME"/> structure to receive the converted system time.</param>
            /// <returns>
            /// If the function succeeds, the return value is nonzero.
            /// If the function fails, the return value is zero. To get extended error information, call <see cref="Marshal.GetLastWin32Error"/>.
            /// </returns>
            [DllImport(WinLibs.Kernel32, SetLastError = true), SuppressUnmanagedCodeSecurity]
            public static extern unsafe bool SystemTimeToFileTime(SYSTEMTIME* lpSystemTime,FILETIME* lpFileTime);

            /// <summary>
            /// Compares two file times.
            /// </summary>
            /// <param name="lpFileTime1">A pointer to a <see cref="FILETIME"/> structure that specifies the first file time.</param>
            /// <param name="lpFileTime2">A pointer to a <see cref="FILETIME"/> structure that specifies the second file time.</param>
            /// <returns>
            /// The return value is one of the following values.
            /// -1: First file time is earlier than second file time.
            /// 0: First file time is equal to second file time.
            /// 1: First file time is later than second file time.
            /// </returns>
            [DllImport(WinLibs.Kernel32), SuppressUnmanagedCodeSecurity]
            public static extern unsafe int CompareFileTime(FILETIME* lpFileTime1, FILETIME* lpFileTime2);

            /// <summary>
            /// Retrieves the number of milliseconds that have elapsed since the system was started.
            /// </summary>
            /// <returns>The number of milliseconds.</returns>
            [DllImport(WinLibs.Kernel32), SuppressUnmanagedCodeSecurity]
            public static extern ulong GetTickCount64();

            /// <summary>
            /// Retrieves the current system date and time. The system time is expressed in Coordinated Universal Time (UTC).
            /// To retrieve the current system date and time in local time, use the GetLocalTime function.
            /// </summary>
            /// <param name="lpSystemTime">
            /// A pointer to a SYSTEMTIME structure to receive the current system date and time.
            /// The lpSystemTime parameter must not be NULL. Using NULL will result in an access violation.
            /// </param>
            [DllImport(WinLibs.Kernel32), SuppressUnmanagedCodeSecurity]
            public static extern unsafe void GetSystemTime(SYSTEMTIME* lpSystemTime);

        }
    }
}