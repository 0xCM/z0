//-----------------------------------------------------------------------------
// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.
//-----------------------------------------------------------------------------
namespace Z0
{
    public readonly struct PathLiterals
    {
        public const string ExtendedDevicePathPrefix = @"\\?\";

        public const string UncPathPrefix = @"\\";

        public const string UncDevicePrefixToInsert = @"?\UNC\";

        public const string UncExtendedPathPrefix = @"\\?\UNC\";

        public const string DevicePathPrefix = @"\\.\";

        public const int MaxShortPath = 260;

        // \\?\, \\.\, \??\
        public const int DevicePrefixLength = 4;

        public const byte DirectorySeparator = 0x5c;

        public const byte DirectorySeparatorAlt = 0x2f;
    }
}