// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.
namespace Z0
{
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public struct MinidumpModule
    {
        public ulong BaseOfImage;

        public int SizeOfImage;

        public uint CheckSum;

        public int DateTimeStamp;

        public uint ModuleNameRva;

        public FixedFileInfo VersionInfo;

        public MinidumpLocationDescriptor CvRecord;

        public MinidumpLocationDescriptor MiscRecord;

        ulong _reserved0;

        ulong _reserved1;
    }
}