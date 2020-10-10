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

        public static void format(in ImageSectionHeader src, DatasetFormatter<Fields> dst)
        {
            dst.Delimit(Fields.FileName, src.File);
            dst.Delimit(Fields.Section, src.SectionName);
            dst.Delimit(Fields.Address, src.RawData);
            dst.Delimit(Fields.Size, src.RawDataSize);
            dst.Delimit(Fields.EntryPoint, src.EntryPoint);
            dst.Delimit(Fields.CodeBase, src.CodeBase);
            dst.Delimit(Fields.Gpt, src.GptRva);
            dst.Delimit(Fields.GptSize, src.GptSize);
        }

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