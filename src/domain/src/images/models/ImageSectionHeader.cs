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

    [StructLayout(LayoutKind.Sequential), Table(TableId, FieldCount)]
    public struct ImageSectionHeader
    {
        public const byte FieldCount = 9;

        public const string TableId = "image.sectionheaders";

        public static ReadOnlySpan<byte> RenderWidths
            => new byte[FieldCount]{60,16,16,12,12,60,16,16,16};

        public FS.FileName File;

        public string SectionName;

        public Address32 CodeBase;

        public Address32 GptRva;

        public ByteSize GptSize;

        public SectionCharacteristics SectionAspects;

        public Address32 RawData;

        public ByteSize RawDataSize;

        public Address32 EntryPoint;
    }
}