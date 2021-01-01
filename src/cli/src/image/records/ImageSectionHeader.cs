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

    [StructLayout(LayoutKind.Sequential), Record(TableId)]
    public struct ImageSectionHeader
    {
        public const string TableId = "image.headers";

        public enum Fields : uint
        {
            FileName = 0 | (26 << WidthOffset),

            Section = 1 | (10 << WidthOffset),

            Address = 2 | (16 << WidthOffset),

            Size = 3 | (10 << WidthOffset),

            EntryPoint = 4 | (16 << WidthOffset),

            CodeBase = 5 | (16 << WidthOffset),

            Gpt = 6 | (16 << WidthOffset),

            GptSize = 7 | (8 << WidthOffset)
        }

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