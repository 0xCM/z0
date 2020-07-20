//-----------------------------------------------------------------------------
// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.
//-----------------------------------------------------------------------------
namespace Z0
{
    partial struct Windows
    {
        public readonly struct FileMapOptions
        {
            public const int FILE_MAP_COPY = 0x0001;
         
            public const int FILE_MAP_WRITE = 0x0002;
         
            public const int FILE_MAP_READ = 0x0004;
         
            public const int FILE_MAP_EXECUTE = 0x0020;
        }
    }
}