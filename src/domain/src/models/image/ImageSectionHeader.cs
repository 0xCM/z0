//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection.Metadata;
    using System.Reflection.PortableExecutable;

    using static Konst;

    public struct ImageSectionHeader
    {
        public FS.FileName File;

        public Address32 CodeBase;

        public Address32 GlobalPointerTable;

        public ByteSize GlobalPointerTableSize;

        public string SectionName;

        public SectionCharacteristics SectionAspects;

        public Address32 RawData;

        public ByteSize RawDataSize;

        public Address32 EntryPoint;

    }
}