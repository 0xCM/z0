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
    using System.Reflection.Metadata.Ecma335;
    using System.IO;
    using System.Collections.Generic;
    using System.Linq;

    using static Konst;
    using static z;

    [ApiHost]
    public partial class PeTableReader : IPeTableReader
    {
        [MethodImpl(Inline)]
        internal static ReadOnlySpan<R> empty<R>()
            => ReadOnlySpan<R>.Empty;

        readonly ReaderState State;

        [MethodImpl(Inline)]
        public static IPeTableReader open(FilePath src)
        {
            var stream = File.OpenRead(src.Name);
            var reader = new PEReader(stream);
            return new PeTableReader(new ReaderState(stream, reader));
        }

        public static ReadOnlySpan<ImageSectionHeader> headers(FilePath src)
        {
            using var stream = File.OpenRead(src.Name);
            using var reader = new PEReader(stream);

            var dst = Root.list<ImageSectionHeader>();
            var headers = reader.PEHeaders;
            var sections = headers.SectionHeaders;


            foreach(var section in sections)
            {
                var record = default(ImageSectionHeader);
                record.File = FS.file(src.FileName.Name);
                record.EntryPoint = (Address32)headers.PEHeader.AddressOfEntryPoint;
                record.CodeBase = (Address32)headers.PEHeader.BaseOfCode;
                record.GlobalPointerTable = (Address32)headers.PEHeader.GlobalPointerTableDirectory.RelativeVirtualAddress;
                record.GlobalPointerTableSize = (ByteSize)headers.PEHeader.GlobalPointerTableDirectory.Size;
                record.SectionAspects = section.SectionCharacteristics;
                record.SectionName = section.Name;
                record.RawData = (Address32)section.PointerToRawData;
                record.RawDataSize = section.SizeOfRawData;
                dst.Add(record);
            }

            return dst.ToArray();
        }

        [MethodImpl(Inline)]
        PeTableReader(ReaderState src)
            => State = src;

        public void Dispose()
            => State.Dispose();

        public ReadOnlySpan<MemberString> ReadMemberStrings()
        {
            var reader = State.Reader;
            int size = reader.GetHeapSize(HeapIndex.String);
            if (size == 0)
                return empty<MemberString>();

            var values = new List<MemberString>();
            var handle = MetadataTokens.StringHandle(0);
            var i=0;
            do
            {
                var dst = default(MemberString);
                dst.Sequence = i++;
                dst.HeapSize = size;
                dst.Offset = (Address32)reader.GetHeapOffset(handle);
                dst.Content = reader.GetString(handle);
                handle = reader.GetNextHandle(handle);
            }
            while (!handle.IsNil);

            return values.ToArray();
        }
        public ReadOnlySpan<ImageStringRecord> ReadStrings()
        {
            var reader = State.Reader;
            int size = reader.GetHeapSize(HeapIndex.String);
            if (size == 0)
                return empty<ImageStringRecord>();

            var values = new List<ImageStringRecord>();
            var handle = MetadataTokens.StringHandle(0);
            var i=0;
            do
            {
                values.Add(new ImageStringRecord(seq: i++, ImgStringSource.System, size, (Address32)reader.GetHeapOffset(handle), reader.GetString(handle)));
                handle = reader.GetNextHandle(handle);
            }
            while (!handle.IsNil);

            return values.ToArray();
        }

        [MethodImpl(Inline), Op]
        public static Address32 offset(MetadataReader reader, UserStringHandle handle)
            => (Address32)reader.GetHeapOffset(handle);

        [MethodImpl(Inline), Op]
        public static string ustring(MetadataReader reader, UserStringHandle handle)
            => reader.GetUserString(handle);

        public ReadOnlySpan<ImageStringRecord> ReadUserStrings()
        {
            var reader = State.Reader;
            int size = reader.GetHeapSize(HeapIndex.UserString);
            if (size == 0)
                return empty<ImageStringRecord>();

            var values = new List<ImageStringRecord>();
            var handle = MetadataTokens.UserStringHandle(0);
            var i=0;

            do
            {
                values.Add(new ImageStringRecord(seq: i++, ImgStringSource.User, size, offset(reader,handle), ustring(reader,handle)));
                handle = reader.GetNextHandle(handle);
            }
            while (!handle.IsNil);

            return values.ToArray();
        }
        public ReadOnlySpan<ImageBlob> ReadBlobs()
            => blobs(State);

        public ReadOnlySpan<ImageConstantRecord> ReadConstants()
            => constants(State);

        public ReadOnlySpan<ImageFieldTable> ReadFields()
            => PeTableReader.fields(State);

        public ReadOnlySpan<FieldRvaRecord> ReadFieldRva()
            => rva(State);
    }
}