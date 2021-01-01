//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection.PortableExecutable;
    using System.IO;

    partial class PeTableReader
    {
        public static ReadOnlySpan<ImageSectionHeader> headers(FS.FilePath src)
        {
            using var stream = File.OpenRead(src.Name);
            using var reader = new PEReader(stream);

            var dst = z.list<ImageSectionHeader>();
            var headers = reader.PEHeaders;
            var sections = headers.SectionHeaders;

            foreach(var section in sections)
            {
                var record = default(ImageSectionHeader);
                record.File = src.FileName;
                record.EntryPoint = (Address32)headers.PEHeader.AddressOfEntryPoint;
                record.CodeBase = (Address32)headers.PEHeader.BaseOfCode;
                record.GptRva = (Address32)headers.PEHeader.GlobalPointerTableDirectory.RelativeVirtualAddress;
                record.GptSize = (ByteSize)headers.PEHeader.GlobalPointerTableDirectory.Size;
                record.SectionAspects = section.SectionCharacteristics;
                record.SectionName = section.Name;
                record.RawDataAddress = (Address32)section.PointerToRawData;
                record.RawDataSize = section.SizeOfRawData;
                dst.Add(record);
            }

            return dst.ToArray();
        }
    }
}