//-----------------------------------------------------------------------------
// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.IO;
    using System.Runtime.ConstrainedExecution;
    using System.Runtime.InteropServices;
    using System.Security;

    using MS;

    partial struct Windows
    {

        /// <summary>
        /// Specifies a date and time, using individual members for the month, day, year, weekday, hour, minute, second, and millisecond.
        /// The time is either in coordinated universal time (UTC) or local time, depending on the function that is being called.
        /// </summary>
        /// <remarks>
        /// It is not recommended that you add and subtract values from the <see cref="SYSTEMTIME"/> structure to obtain relative times.
        /// Instead, you should
        /// Convert the <see cref="SYSTEMTIME"/> structure to a <see cref="FILETIME"/> structure.
        /// <list type="bullet">
        /// <item>
        /// <desccription>Copy the resulting <see cref="FILETIME"/> structure to a ULARGE_INTEGER structure.</desccription>
        /// </item>
        /// <item>
        /// <desccription>Use normal 64-bit arithmetic on the ULARGE_INTEGER value.</desccription>
        /// </item>
        /// <item>
        /// <description>The system can periodically refresh the time by synchronizing with a time source.</description>
        /// </item>
        /// </list>
        /// Because the system time can be adjusted either forward or backward, do not compare system time readings to determine elapsed time.
        /// Instead, use one of the methods described in Windows Time.
        /// </remarks>
        public struct SYSTEMTIME
        {
            /// <summary>
            /// The year. The valid values for this member are 1601 through 30827.
            /// </summary>
            public short wYear;

            /// <summary>
            /// The month. This member can be one of the following values.
            /// <list type="table">
            /// <listheader>
            /// <term>Value</term>
            /// <term>Meaning</term>
            /// </listheader>
            /// <item>
            /// <term>1</term>
            /// <term>January</term>
            /// </item>
            /// <item>
            /// <term>2</term>
            /// <term>February</term>
            /// </item>
            /// <item>
            /// <term>3</term>
            /// <term>March</term>
            /// </item>
            /// <item>
            /// <term>4</term>
            /// <term>April</term>
            /// </item>
            /// <item>
            /// <term>5</term>
            /// <term>May</term>
            /// </item>
            /// <item>
            /// <term>6</term>
            /// <term>June</term>
            /// </item>
            /// <item>
            /// <term>7</term>
            /// <term>July</term>
            /// </item>
            /// <item>
            /// <term>8</term>
            /// <term>August</term>
            /// </item>
            /// <item>
            /// <term>9</term>
            /// <term>September</term>
            /// </item>
            /// <item>
            /// <term>10</term>
            /// <term>October</term>
            /// </item>
            /// <item>
            /// <term>11</term>
            /// <term>November</term>
            /// </item>
            /// <item>
            /// <term>12</term>
            /// <term>December</term>
            /// </item>
            /// </list>
            /// </summary>
            public short wMonth;

            /// <summary>
            /// The day of the week. This member can be one of the following values.
            /// <list type="table">
            /// <listheader>
            /// <term>Value</term>
            /// <term>Meaning</term>
            /// </listheader>
            /// <item>
            /// <term>0</term>
            /// <term>Sunday</term>
            /// </item>
            /// <item>
            /// <term>1</term>
            /// <term>Monday</term>
            /// </item>
            /// <item>
            /// <term>2</term>
            /// <term>Tuesday</term>
            /// </item>
            /// <item>
            /// <term>3</term>
            /// <term>Wednesday</term>
            /// </item>
            /// <item>
            /// <term>4</term>
            /// <term>Thursday</term>
            /// </item>
            /// <item>
            /// <term>5</term>
            /// <term>Friday</term>
            /// </item>
            /// <item>
            /// <term>6</term>
            /// <term>Saturday</term>
            /// </item>
            /// </list>
            /// </summary>
            public short wDayOfWeek;

            /// <summary>
            /// The day of the month. The valid values for this member are 1 through 31.
            /// </summary>
            public short wDay;

            /// <summary>
            /// The hour. The valid values for this member are 0 through 23.
            /// </summary>
            public short wHour;

            /// <summary>
            /// The minute. The valid values for this member are 0 through 59.
            /// </summary>
            public short wMinute;

            /// <summary>
            /// The second. The valid values for this member are 0 through 59.
            /// </summary>
            public short wSecond;

            /// <summary>
            /// The millisecond. The valid values for this member are 0 through 999.
            /// </summary>
            public short wMilliseconds;

            /// <summary>
            /// Converts a <see cref="SYSTEMTIME"/> value to a <see cref="DateTime"/> value.
            /// </summary>
            /// <param name="st">The value to be converted.</param>
            public static implicit operator DateTime(SYSTEMTIME st) => new DateTime(st.wYear, st.wMonth, st.wDay, st.wHour, st.wMinute, st.wSecond, st.wMilliseconds);

            /// <summary>
            /// Converts a <see cref="DateTime"/> value to a <see cref="SYSTEMTIME"/> value.
            /// </summary>
            /// <param name="dt">The value to be converted.</param>
            public static implicit operator SYSTEMTIME(DateTime dt) => new SYSTEMTIME
            {
                wYear = (short)dt.Year,
                wMonth = (short)dt.Month,
                wDay = (short)dt.Day,
                wHour = (short)dt.Hour,
                wMinute = (short)dt.Minute,
                wSecond = (short)dt.Second,
                wMilliseconds = (short)dt.Millisecond,
            };
        }

        /// <summary>
        /// A 64-bit representation of a file timestamp.
        /// </summary>
        /// <remarks>
        /// This type is equivalent to <see cref="System.Runtime.InteropServices.ComTypes.FILETIME"/>.
        /// We couldn't use that type directly even though it's in the portable profile because
        /// Xamarin.Android and Xamarin.iOS omit the type and it causes link failures.
        /// See https://github.com/dotnet/pinvoke/issues/232.
        /// </remarks>
        public struct FILETIME
        {
            /// <summary>
            /// Specifies the low 32 bits of the FILETIME.
            /// </summary>
            public int dwLowDateTime;

            /// <summary>
            /// Specifies the high 32 bits of the FILETIME.
            /// </summary>
            public int dwHighDateTime;
        }

        public struct WIN32_FIND_DATA
        {
            /// <summary>
            /// The file attributes of a file.
            /// </summary>
            /// <remarks>
            /// Although the enum we bind to here exists in the .NET Framework
            /// as System.IO.FileAttributes, it is not reliably present.
            /// Portable profiles don't include it, for example. So we have to define our own.
            /// </remarks>
            public FileAttribute dwFileAttributes;

            /// <summary>
            /// A FILETIME structure that specifies when a file or directory was created.
            /// If the underlying file system does not support creation time, this member is zero.
            /// </summary>
            public FILETIME ftCreationTime;

            /// <summary>
            /// A FILETIME structure.
            /// For a file, the structure specifies when the file was last read from, written to, or for executable files, run.
            /// For a directory, the structure specifies when the directory is created.If the underlying file system does not support last access time, this member is zero.
            /// On the FAT file system, the specified date for both files and directories is correct, but the time of day is always set to midnight.
            /// </summary>
            public FILETIME ftLastAccessTime;

            /// <summary>
            /// A FILETIME structure.
            /// For a file, the structure specifies when the file was last written to, truncated, or overwritten, for example, when WriteFile or SetEndOfFile are used.The date and time are not updated when file attributes or security descriptors are changed.
            /// For a directory, the structure specifies when the directory is created.If the underlying file system does not support last write time, this member is zero.
            /// </summary>
            public FILETIME ftLastWriteTime;

            /// <summary>
            /// The high-order DWORD value of the file size, in bytes.
            /// This value is zero unless the file size is greater than MAXDWORD.
            /// The size of the file is equal to(nFileSizeHigh* (MAXDWORD+1)) + nFileSizeLow.
            /// </summary>
            public uint nFileSizeHigh;

            /// <summary>
            /// The low-order DWORD value of the file size, in bytes.
            /// </summary>
            public uint nFileSizeLow;

            /// <summary>
            /// If the dwFileAttributes member includes the FILE_ATTRIBUTE_REPARSE_POINT attribute, this member specifies the reparse point tag.
            /// Otherwise, this value is undefined and should not be used.
            /// For more information see Reparse Point Tags.
            /// </summary>
            public uint dwReserved0;

            /// <summary>
            /// Reserved for future use.
            /// </summary>
            public uint dwReserved1;

            /// <summary>
            /// The name of the file.
            /// </summary>
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
            public string cFileName;

            /// <summary>
            /// An alternative name for the file.
            /// This name is in the classic 8.3 file name format.
            /// </summary>
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 14)]
            public string cAlternateFileName;
        }

        partial struct Kernel32
        {
            /// <summary>
            /// The maximum length of a name for a process module.
            /// </summary>
            public const int MAX_MODULE_NAME32 = 255;

            /// <summary>
            /// The maximum length of file paths for most Win32 functions.
            /// </summary>
            public const int MAX_PATH = 260;

            /// <summary>
            /// Constant for invalid handle value.
            /// </summary>
            public static readonly IntPtr INVALID_HANDLE_VALUE = new IntPtr(-1);


            /// <summary>
            /// Moves the file pointer of the specified file.
            /// </summary>
            /// <param name="hFile">
            /// A handle to the file.
            /// The file handle must be created with the GENERIC_READ or GENERIC_WRITE access right.
            /// </param>
            /// <param name="liDistanceToMove">
            /// The number of bytes to move the file pointer. A positive value moves the pointer forward in the file and a negative value moves the file pointer backward.
            /// </param>
            /// <param name="lpNewFilePointer">
            /// A pointer to a variable to receive the new file pointer. If this parameter is <see langword="null"/>, the new file pointer is not returned.
            /// </param>
            /// <param name="dwMoveMethod">
            /// The starting point for the file pointer move.
            /// </param>
            /// <returns>
            /// If the function succeeds, the return value is nonzero.
            /// If the function fails, the return value is zero. To get extended error information, call GetLastError.
            /// </returns>
            /// <seealso href="https://docs.microsoft.com/en-us/windows/win32/api/fileapi/nf-fileapi-setfilepointerex"/>
            [DllImport(WinLibs.Kernel32, SetLastError = true)]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern bool SetFilePointerEx(IntPtr hFile, long liDistanceToMove, out long lpNewFilePointer, SeekOrigin dwMoveMethod);

            /// <summary>
            /// Moves the file pointer of the specified file.
            /// </summary>
            /// <param name="hFile">
            /// A handle to the file.
            /// </param>
            /// <param name="lDistanceToMove">
            /// The low order 32-bits of a signed value that specifies the number of bytes to move the file pointer.
            /// </param>
            /// <param name="lpDistanceToMoveHigh">
            /// A pointer to the high order 32-bits of the signed 64-bit distance to move.
            /// If you do not need the high order 32-bits, this pointer must be set to <see langword="null"/>.
            /// When not <see langword="null"/>, this parameter also receives the high order DWORD of the new value of the file pointer.
            /// </param>
            /// <param name="dwMoveMethod">
            /// The starting point for the file pointer move.
            /// </param>
            /// <returns>
            /// <para>
            ///     If the function succeeds and <paramref name="lpDistanceToMoveHigh"/> is <see langword="null"/>,
            ///     the return value is the low-order DWORD of the new file pointer.
            ///     If the function returns a value other than INVALID_SET_FILE_POINTER, the call to <see cref="SetFilePointer(SafeObjectHandle, int, int*, SeekOrigin)"/> has succeeded.
            ///     You do not need to call <see cref="GetLastError"/>.
            /// </para>
            /// <para>
            ///     If function succeeds and <paramref name="lpDistanceToMoveHigh"/> is not <see langword="null"/>, the return value is the low-order DWORD
            ///     of the new file pointer and <paramref name="lpDistanceToMoveHigh "/> contains the high order DWORD of the new file pointer.
            /// </para>
            /// <para>
            ///     If the function fails, the return value is INVALID_SET_FILE_POINTER. To get extended error information, call <see cref="GetLastError"/>.
            /// </para>
            /// <para>
            ///     If a new file pointer is a negative value, the function fails, the file pointer is not moved, and the code returned by <see cref="GetLastError"/> is ERROR_NEGATIVE_SEEK.
            /// </para>
            /// <para>
            ///     If <paramref name="lpDistanceToMoveHigh"/> is <see langword="null"/> and the new file position does not fit in a 32-bit value, the function fails and returns INVALID_SET_FILE_POINTER.
            /// </para>
            /// </returns>
            [DllImport(WinLibs.Kernel32, SetLastError = true)]
            public static unsafe extern int SetFilePointer(IntPtr hFile, int lDistanceToMove, int* lpDistanceToMoveHigh, SeekOrigin dwMoveMethod);

            /// <summary>
            /// Suspends the specified thread.
            /// A 64-bit application can suspend a WOW64 thread using the Wow64SuspendThread function (desktop only).
            /// </summary>
            /// <param name="hThread">
            /// A handle to the thread that is to be suspended.
            /// The handle must have the THREAD_SUSPEND_RESUME access right. For more information, see Thread Security and Access Rights.
            /// </param>
            /// <returns>
            /// If the function succeeds, the return value is the thread's previous suspend count; otherwise, it is (DWORD) -1. To get extended error information, use the <see cref="GetLastError"/> function.
            /// </returns>
            [DllImport(WinLibs.Kernel32, SetLastError = true)]
            public static extern int SuspendThread(SafeObjectHandle hThread);

            /// <summary>
            /// Decrements a thread's suspend count. When the suspend count is decremented to zero, the execution of the thread is resumed.
            /// </summary>
            /// <param name="hThread">
            /// A handle to the thread to be restarted.
            /// This handle must have the THREAD_SUSPEND_RESUME access right. For more information, see Thread Security and Access Rights.
            /// </param>
            /// <returns>
            /// If the function succeeds, the return value is the thread's previous suspend count.
            /// If the function fails, the return value is (DWORD) -1. To get extended error information, call <see cref="GetLastError"/>.
            /// </returns>
            [DllImport(WinLibs.Kernel32, SetLastError = true)]
            public static extern int ResumeThread(SafeObjectHandle hThread);

            [SuppressUnmanagedCodeSecurity]
            [ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
            [DllImport(WinLibs.Kernel32, SetLastError = true)]
            public static extern bool CloseHandle(IntPtr hObject);

            /// <summary>Flushes the buffers of a specified file and causes all buffered data to be written to a file.</summary>
            /// <param name="hFile">
            ///     A handle to the open file.
            ///     <para>
            ///         The file handle must have the GENERIC_WRITE access right. For more information, see File Security and Access
            ///         Rights.
            ///     </para>
            ///     <para>If hFile is a handle to a communications device, the function only flushes the transmit buffer.</para>
            ///     <para>
            ///         If hFile is a handle to the server end of a named pipe, the function does not return until the client has
            ///         read all buffered data from the pipe.
            ///     </para>
            /// </param>
            /// <returns>
            ///     If the function succeeds, the return value is nonzero.
            ///     <para>
            ///         If the function fails, the return value is zero. To get extended error information, call
            ///         <see cref="GetLastError" />.
            ///     </para>
            ///     <para>
            ///         The function fails if hFile is a handle to the console output. That is because the console output is not
            ///         buffered. The function returns FALSE, and <see cref="GetLastError" /> returns
            ///         <see cref="Win32ErrorCode.ERROR_INVALID_HANDLE" />.
            ///     </para>
            /// </returns>
            [DllImport(WinLibs.Kernel32, SetLastError = true)]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern bool FlushFileBuffers(SafeObjectHandle hFile);

            /// <summary>
            /// Sets the last-error code for the calling thread.
            /// </summary>
            /// <param name="dwErrCode">The last-error code for the thread.</param>
            [DllImport(WinLibs.Kernel32, SetLastError = true)]
            public static extern void SetLastError(uint dwErrCode);

            /// <summary>
            /// Flushes the write queue of each processor that is running a thread of the current process.
            /// </summary>
            /// <remarks>
            /// The function generates an interprocessor interrupt (IPI) to all processors that are part of the current process affinity.
            /// It guarantees the visibility of write operations performed on one processor to the other processors.
            /// </remarks>
            [DllImport(WinLibs.Kernel32)]
            public static extern void FlushProcessWriteBuffers();

            /// <summary>
            /// Retrieves the number of the processor the current thread was running on during the call to this function.
            /// </summary>
            /// <returns>The function returns the current processor number.</returns>
            /// <remarks>
            /// This function is used to provide information for estimating process performance.
            /// On systems with more than 64 logical processors, the <see cref="GetCurrentProcessorNumber"/> function returns the processor number within the processor
            /// group to which the logical processor is assigned.Use the <see cref="GetCurrentProcessorNumberEx(PROCESSOR_NUMBER*)"/> function to retrieve the processor group and number of the
            /// current processor.
            /// </remarks>
            [DllImport(WinLibs.Kernel32)]
            public static extern uint GetCurrentProcessorNumber();

            /// <summary>
            ///     Closes a file search handle opened by the FindFirstFile, FindFirstFileEx, FindFirstFileNameW,
            ///     FindFirstFileNameTransactedW, FindFirstFileTransacted, FindFirstStreamTransactedW, or FindFirstStreamW functions.
            /// </summary>
            /// <param name="hFindFile">The file search handle.</param>
            /// <returns>
            ///     If the function succeeds, the return value is nonzero.
            ///     <para>
            ///         If the function fails, the return value is zero. To get extended error information, call
            ///         <see cref="GetLastError" />.
            ///     </para>
            /// </returns>
            [DllImport(WinLibs.Kernel32, SetLastError = true)]
            private static extern bool FindClose(IntPtr hFindFile);
        }
    }
}