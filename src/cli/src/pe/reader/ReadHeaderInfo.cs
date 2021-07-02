//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static PeRecords;
    using static core;

    partial class PeReader
    {
        public ReadOnlySpan<SectionHeaderInfo> ReadHeaderInfo()
        {
            var dst = list<SectionHeaderInfo>();

            if(PE.HasMetadata)
            {
                var headers = PeHeaders;
                var sections = SectionHeaders;

                foreach(var section in sections)
                {
                    var record = default(SectionHeaderInfo);
                    record.File = Source.FileName;
                    record.EntryPoint = (Address32)headers.PEHeader.AddressOfEntryPoint;
                    record.CodeBase = (Address32)headers.PEHeader.BaseOfCode;
                    record.GptRva = (Address32)headers.PEHeader.GlobalPointerTableDirectory.RelativeVirtualAddress;
                    record.GptSize = (ByteSize)headers.PEHeader.GlobalPointerTableDirectory.Size;
                    record.SectionAspects = section.SectionCharacteristics;
                    record.SectionName = section.Name;
                    record.RawDataAddress = (Address32)section.PointerToRawData;
                    record.RawDataSize = (uint)section.SizeOfRawData;
                    dst.Add(record);
                }
            }
            return dst.ViewDeposited();
        }
    }
}