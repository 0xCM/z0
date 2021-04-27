// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.
namespace Z0
{
    using System;

    public struct MinidumpModuleInfo
    {
        public ulong BaseOfImage;

        public int SizeOfImage;

        public int DateTimeStamp;

        public FixedFileInfo VersionInfo;

        public string ModuleName;

        public bool IsEmpty
        {
            get => SizeOfImage == 0;
        }
    }
}