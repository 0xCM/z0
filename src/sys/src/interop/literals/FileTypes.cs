//-----------------------------------------------------------------------------
// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.
//-----------------------------------------------------------------------------
namespace Z0
{
    partial struct Windows
    {
        public readonly struct FileTypes
        {
            public const int FILE_TYPE_UNKNOWN = 0x0000;

            public const int FILE_TYPE_DISK = 0x0001;

            public const int FILE_TYPE_CHAR = 0x0002;

            public const int FILE_TYPE_PIPE = 0x0003;
        }
    }
}