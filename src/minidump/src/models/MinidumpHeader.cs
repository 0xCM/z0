// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.
namespace Z0
{
    public struct MinidumpHeader
    {
        public const int ExpectedMagic1 = 0x504d444d;

        public const int ExpectedMagic2 = 0xa793;

        public bool IsValid => Magic1 == ExpectedMagic1 && Magic2 == ExpectedMagic2;

        public uint Magic1;

        public ushort Magic2;

        public ushort Version;

        public uint NumberOfStreams;

        public uint StreamDirectoryRva;

        public uint CheckSum;

        public uint TimeDateStamp;

        public ulong Flags;
    }
}