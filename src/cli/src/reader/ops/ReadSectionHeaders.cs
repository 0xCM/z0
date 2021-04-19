//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection.Metadata;
    using System.Reflection.PortableExecutable;
    using System.IO;
    using System.Linq;

    using static Part;
    using static memory;

    partial class CliDataReader
    {
        public Index<ImageSectionHeader> ReadSectionHeders()
        {
            var dst = root.list<ImageSectionHeader>();

            if(PeReader.HasMetadata)
            {
                var headers = PeReader.PEHeaders;
                var sections = headers.SectionHeaders;

                foreach(var section in sections)
                {
                    var record = default(ImageSectionHeader);
                    record.File = Source.FileName;
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
            }
            return dst.ToArray();
        }

    }
}