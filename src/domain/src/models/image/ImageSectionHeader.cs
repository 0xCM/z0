//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;
    using System.Reflection.PortableExecutable;

    using static Konst;

    [StructLayout(LayoutKind.Sequential)]
    public struct ImageSectionHeader
    {
        public FS.FileName File;

        public string SectionName;

        public Address32 CodeBase;

        public Address32 GlobalPointerTable;

        public ByteSize GlobalPointerTableSize;

        public SectionCharacteristics SectionAspects;

        public Address32 RawData;

        public ByteSize RawDataSize;

        public Address32 EntryPoint;
    }
}