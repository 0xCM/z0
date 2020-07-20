//-----------------------------------------------------------------------------
// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.
//-----------------------------------------------------------------------------
namespace Z0
{
    using Microsoft.Win32.SafeHandles;
    using System;
    using System.IO;
    using System.Runtime.InteropServices;
    using System.Diagnostics;
    using System.Diagnostics.CodeAnalysis;
    using System.Runtime.CompilerServices;

    using static PathLiterals;

    using static sys;

    readonly struct PathLiterals
    {
        public const string ExtendedDevicePathPrefix = @"\\?\";

        public const string UncPathPrefix = @"\\";

        public const string UncDevicePrefixToInsert = @"?\UNC\";

        public const string UncExtendedPathPrefix = @"\\?\UNC\";

        public const string DevicePathPrefix = @"\\.\";

        public const int MaxShortPath = 260;

        // \\?\, \\.\, \??\
        public const int DevicePrefixLength = 4;
    }

    partial struct Windows
    {
        /// <summary>Contains public path helpers that are shared between many projects.</summary>
        [ApiHost]
        public static partial class PathInternal
        {
            /// <summary>
            /// True if the given character is a directory separator.
            /// </summary>
            [Op, MethodImpl(Options)]
            public static bool IsDirectorySeparator(char c)
                => c == Path.DirectorySeparatorChar || c == Path.AltDirectorySeparatorChar;

            [Op]
            public static bool EndsInDirectorySeparator(ReadOnlySpan<char> path)
                => path.Length > 0 && IsDirectorySeparator(path[path.Length - 1]);

            [Op]
            public static int GetRootLength(ReadOnlySpan<char> path)
                => path.Length > 0 && IsDirectorySeparator(path[0]) ? 1 : 0;

            /// <summary>
            /// Returns true if the given character is a valid drive letter
            /// </summary>
            [Op]
            public static bool IsValidDriveChar(char value)
                => ((value >= 'A' && value <= 'Z') || (value >= 'a' && value <= 'z'));

            [Op]
            public static ReadOnlySpan<char> TrimEndingDirectorySeparator(ReadOnlySpan<char> path) 
                => EndsInDirectorySeparator(path) && !IsRoot(path) ? path.Slice(0, path.Length - 1) : path;

            [Op]
            public static bool IsRoot(ReadOnlySpan<char> path)
                => path.Length == GetRootLength(path);

            /// <summary>
            /// Returns true if the path uses the canonical form of extended syntax ("\\?\" or "\??\"). If the
            /// path matches exactly (cannot use alternate directory separators) Windows will skip normalization
            /// and path length checks.
            /// </summary>
            [Op]
            public static bool IsExtended(string path)
            {
                // While paths like "//?/C:/" will work, they're treated the same as "\\.\" paths.
                // Skipping of normalization will *only* occur if back slashes ('\') are used.
                return path.Length >= DevicePrefixLength
                    && path[0] == '\\'
                    && (path[1] == '\\' || path[1] == '?')
                    && path[2] == '?'
                    && path[3] == '\\';
            }
 
            [Op]
            public static bool EndsWithPeriodOrSpace(string path)
            {
                if (string.IsNullOrEmpty(path))
                    return false;

                char c = path[path.Length - 1];
                return c == ' ' || c == '.';
            }

            /// <summary>
            /// Returns true if the path uses any of the DOS device path syntaxes. ("\\.\", "\\?\", or "\??\")
            /// </summary>
            [Op]
            public static bool IsDevice(string path)
            {
                // If the path begins with any two separators is will be recognized and normalized and prepped with
                // "\??\" for public usage correctly. "\??\" is recognized and handled, "/??/" is not.
                return IsExtended(path)
                    ||
                    (
                        path.Length >= DevicePrefixLength
                        && IsDirectorySeparator(path[0])
                        && IsDirectorySeparator(path[1])
                        && (path[2] == '.' || path[2] == '?')
                        && IsDirectorySeparator(path[3])
                    );
            }

            /// <summary>
            /// Returns true if the path specified is relative to the current drive or working directory.
            /// Returns false if the path is fixed to a specific drive or UNC path.  This method does no
            /// validation of the path (URIs will be returned as relative as a result).
            /// </summary>
            /// <remarks>
            /// Handles paths that use the alternate directory separator.  It is a frequent mistake to
            /// assume that rooted paths (Path.IsPathRooted) are not relative.  This isn't the case.
            /// "C:a" is drive relative- meaning that it will be resolved against the current directory
            /// for C: (rooted, but relative). "C:\a" is rooted and not relative (the current directory
            /// will not be used to modify the path).
            /// </remarks>
            [Op]
            public static bool IsPartiallyQualified(string path)
            {
                // It isn't fixed, it must be relative.  There is no way to specify a fixed
                // path with one character (or less).
                if (path.Length < 2)
                    return true;

                // There is no valid way to specify a relative path with two initial slashes or
                // \? as ? isn't valid for drive relative paths and \??\ is equivalent to \\?\
                if (IsDirectorySeparator(path[0]))
                    return !(path[1] == '?' || IsDirectorySeparator(path[1]));

                // The only way to specify a fixed path that doesn't begin with two slashes
                // is the drive, colon, slash format- i.e. C:\
                // To match old behavior we'll check the drive character for validity as the path is technically
                // not qualified if you don't have a valid drive. "=:\" is the "=" file's default data stream.
                return !((path.Length >= 3) && (path[1] == Path.VolumeSeparatorChar)  && IsDirectorySeparator(path[2])  && IsValidDriveChar(path[0]));
            }

            // All paths in Win32 ultimately end up becoming a path to a File object in the Windows object manager. Passed in paths get mapped through
            // DosDevice symbolic links in the object tree to actual File objects under \Devices. To illustrate, this is what happens with a typical
            // path "Foo" passed as a filename to any Win32 API:
            //
            //  1. "Foo" is recognized as a relative path and is appended to the current directory (say, "C:\" in our example)
            //  2. "C:\Foo" is prepended with the DosDevice namespace "\??\"
            //  3. CreateFile tries to create an object handle to the requested file "\??\C:\Foo"
            //  4. The Object Manager recognizes the DosDevices prefix and looks
            //      a. First in the current session DosDevices ("\Sessions\1\DosDevices\" for example, mapped network drives go here)
            //      b. If not found in the session, it looks in the Global DosDevices ("\GLOBAL??\")
            //  5. "C:" is found in DosDevices (in our case "\GLOBAL??\C:", which is a symbolic link to "\Device\HarddiskVolume6")
            //  6. The full path is now "\Device\HarddiskVolume6\Foo", "\Device\HarddiskVolume6" is a File object and parsing is handed off
            //      to the registered parsing method for Files
            //  7. The registered open method for File objects is invoked to create the file handle which is then returned
            //
            // There are multiple ways to directly specify a DosDevices path. The final format of "\??\" is one way. It can also be specified
            // as "\\.\" (the most commonly documented way) and "\\?\". If the question mark syntax is used the path will skip normalization
            // (essentially GetFullPathName()) and path length checks.

            // Windows Kernel-Mode Object Manager
            // https://msdn.microsoft.com/en-us/library/windows/hardware/ff565763.aspx
            // https://channel9.msdn.com/Shows/Going+Deep/Windows-NT-Object-Manager
            //
            // Introduction to MS-DOS Device Names
            // https://msdn.microsoft.com/en-us/library/windows/hardware/ff548088.aspx
            //
            // Local and Global MS-DOS Device Names
            // https://msdn.microsoft.com/en-us/library/windows/hardware/ff554302.aspx

            /// <summary>
            /// Adds the extended path prefix (\\?\) if not already a device path, IF the path is not relative,
            /// AND the path is more than 259 characters. (> MAX_PATH + null). This will also insert the extended
            /// prefix if the path ends with a period or a space. Trailing periods and spaces are normally eaten
            /// away from paths during normalization, but if we see such a path at this point it should be
            /// normalized and has retained the final characters. (Typically from one of the *Info classes)
            /// </summary>
            [Op]
            [return: NotNullIfNotNull("path")]
            public static string EnsureExtendedPrefixIfNeeded(string path)
            {
                if (path != null && (path.Length >= MaxShortPath || EndsWithPeriodOrSpace(path)))
                    return EnsureExtendedPrefix(path);
                else
                    return path;
            }

            /// <summary>
            /// Adds the extended path prefix (\\?\) if not relative or already a device path.
            /// </summary>
            [Op]
            public static string EnsureExtendedPrefix(string path)
            {
                // Putting the extended prefix on the path changes the processing of the path. It won't get normalized, which
                // means adding to relative paths will prevent them from getting the appropriate current directory inserted.

                // If it already has some variant of a device path (\??\, \\?\, \\.\, //./, etc.) we don't need to change it
                // as it is either correct or we will be changing the behavior. When/if Windows supports long paths implicitly
                // in the future we wouldn't want normalization to come back and break existing code.

                // In any case, all public usages should be hitting normalize path (Path.GetFullPath) before they hit this
                // shimming method. (Or making a change that doesn't impact normalization, such as adding a filename to a
                // normalized base path.)
                if (IsPartiallyQualified(path) || IsDevice(path))
                    return path;

                // Given \\server\share in longpath becomes \\?\UNC\server\share
                if (path.StartsWith(UncPathPrefix, StringComparison.OrdinalIgnoreCase))
                    return path.Insert(2, UncDevicePrefixToInsert);

                return ExtendedDevicePathPrefix + path;
            }
        }
    }
}