//-----------------------------------------------------------------------------
// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.
//-----------------------------------------------------------------------------
namespace Z0.MS
{
    using System;
    using System.Diagnostics;
    using System.Runtime.InteropServices;
    using System.IO;

    using static Windows;

    /// <summary>
    /// Provides static methods for converting from Win32 errors codes to exceptions, HRESULTS and error messages.
    /// </summary>
    public readonly struct WinErrors
    {
        /// <summary>
        /// Converts, resetting it, the last Win32 error into a corresponding <see cref="Exception"/> object, optionally
        /// including the specified path in the error message.
        /// </summary>
        public static Exception GetExceptionForLastWin32Error(string path = "")
            => GetExceptionForWin32Error(Marshal.GetLastWin32Error(), path);

        /// <summary>
        /// Converts the specified Win32 error into a corresponding <see cref="Exception"/> object, optionally
        /// including the specified path in the error message.
        /// </summary>
        public static Exception GetExceptionForWin32Error(int errorCode, string path = "")
        {
            // ERROR_SUCCESS gets thrown when another unexpected interop call was made before checking GetLastWin32Error().
            // Errors have to get retrieved as soon as possible after P/Invoking to avoid this.
            Debug.Assert(errorCode != WinErrorCodes.ERROR_SUCCESS);

            switch (errorCode)
            {
                case WinErrorCodes.ERROR_FILE_NOT_FOUND:
                    return new FileNotFoundException(
                        string.IsNullOrEmpty(path) ? SR.IO_FileNotFound : SR.Format(SR.IO_FileNotFound_FileName, path), path);
                case WinErrorCodes.ERROR_PATH_NOT_FOUND:
                    return new DirectoryNotFoundException(
                        string.IsNullOrEmpty(path) ? SR.IO_PathNotFound_NoPathName : SR.Format(SR.IO_PathNotFound_Path, path));
                case WinErrorCodes.ERROR_ACCESS_DENIED:
                    return new UnauthorizedAccessException(
                        string.IsNullOrEmpty(path) ? SR.UnauthorizedAccess_IODenied_NoPathName : SR.Format(SR.UnauthorizedAccess_IODenied_Path, path));
                case WinErrorCodes.ERROR_ALREADY_EXISTS:
                    if (string.IsNullOrEmpty(path))
                        goto default;
                    return new IOException(SR.Format(SR.IO_AlreadyExists_Name, path), MakeHRFromErrorCode(errorCode));
                case WinErrorCodes.ERROR_FILENAME_EXCED_RANGE:
                    return new PathTooLongException(
                        string.IsNullOrEmpty(path) ? SR.IO_PathTooLong : SR.Format(SR.IO_PathTooLong_Path, path));
                case WinErrorCodes.ERROR_SHARING_VIOLATION:
                    return new IOException(
                        string.IsNullOrEmpty(path) ? SR.IO_SharingViolation_NoFileName : SR.Format(SR.IO_SharingViolation_File, path),
                        MakeHRFromErrorCode(errorCode));
                case WinErrorCodes.ERROR_FILE_EXISTS:
                    if (string.IsNullOrEmpty(path))
                        goto default;
                    return new IOException(SR.Format(SR.IO_FileExists_Name, path), MakeHRFromErrorCode(errorCode));
                case WinErrorCodes.ERROR_OPERATION_ABORTED:
                    return new OperationCanceledException();
                case WinErrorCodes.ERROR_INVALID_PARAMETER:
                default:
                    return new IOException(
                        string.IsNullOrEmpty(path) ? GetMessage(errorCode) : $"{GetMessage(errorCode)} : '{path}'", MakeHRFromErrorCode(errorCode));
            }
        }

        /// <summary>
        /// If not already an HRESULT, returns an HRESULT for the specified Win32 error code.
        /// </summary>
        public static int MakeHRFromErrorCode(int errorCode)
        {
            // Don't convert it if it is already an HRESULT
            if ((0xFFFF0000 & errorCode) != 0)
                return errorCode;

            return unchecked(((int)0x80070000) | errorCode);
        }

        /// <summary>
        /// Returns a Win32 error code for the specified HRESULT if it came from FACILITY_WIN32
        /// If not, returns the HRESULT unchanged
        /// </summary>
        public static int TryMakeWin32ErrorCodeFromHR(int hr)
        {
            // Win32 error, Win32Marshal.GetExceptionForWin32Error expects the Win32 format
            if ((0xFFFF0000 & hr) == 0x80070000)
                hr &= 0x0000FFFF;

            return hr;
        }

        /// <summary>
        /// Returns a string message for the specified Win32 error code.
        /// </summary>
        public static string GetMessage(int errorCode) 
            => Kernel32.GetMessage(errorCode);
    }
}