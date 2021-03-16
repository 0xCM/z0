//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection.PortableExecutable;

    [Record(TableId)]
    public struct ImageSectionHeader : IRecord<ImageSectionHeader>
    {
        public const string TableId = "image.headers";

        public FS.FileName File;

        public string SectionName;

        public Address32 CodeBase;

        public Address32 GptRva;

        public ByteSize GptSize;

        public SectionCharacteristics SectionAspects;

        public Address32 RawDataAddress;

        public ByteSize RawDataSize;

        public Address32 EntryPoint;
    }
}