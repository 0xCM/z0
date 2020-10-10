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

    using static Konst;
    using static z;

    using I = System.Reflection.Metadata.Ecma335.TableIndex;

    [ApiHost]
    public partial class PeTableReader : IPeTableReader
    {
        [MethodImpl(Inline)]
        internal static ReadOnlySpan<R> empty<R>()
            => ReadOnlySpan<R>.Empty;

        readonly ReaderState State;

        [MethodImpl(Inline)]
        public static IPeTableReader open(FS.FilePath src)
        {
            var stream = File.OpenRead(src.Name);
            var reader = new PEReader(stream);
            return new PeTableReader(new ReaderState(stream, reader));
        }

        public static ReadOnlySpan<ImageSectionHeader> headers(FilePath src)
        {
            using var stream = File.OpenRead(src.Name);
            using var reader = new PEReader(stream);

            var dst = z.list<ImageSectionHeader>();
            var headers = reader.PEHeaders;
            var sections = headers.SectionHeaders;

            foreach(var section in sections)
            {
                var record = default(ImageSectionHeader);
                record.File = FS.file(src.FileName.Name);
                record.EntryPoint = (Address32)headers.PEHeader.AddressOfEntryPoint;
                record.CodeBase = (Address32)headers.PEHeader.BaseOfCode;
                record.GptRva = (Address32)headers.PEHeader.GlobalPointerTableDirectory.RelativeVirtualAddress;
                record.GptSize = (ByteSize)headers.PEHeader.GlobalPointerTableDirectory.Size;
                record.SectionAspects = section.SectionCharacteristics;
                record.SectionName = section.Name;
                record.RawData = (Address32)section.PointerToRawData;
                record.RawDataSize = section.SizeOfRawData;
                dst.Add(record);
            }

            return dst.ToArray();
        }

        [MethodImpl(Inline)]
        internal PeTableReader(ReaderState src)
            => State = src;

        public void Dispose()
            => State.Dispose();

        [MethodImpl(Inline), Op]
        public static Address32 offset(MetadataReader reader, UserStringHandle handle)
            => (Address32)reader.GetHeapOffset(handle);

        [MethodImpl(Inline), Op]
        public static string ustring(MetadataReader reader, UserStringHandle handle)
            => reader.GetUserString(handle);

        public ReadOnlySpan<CliBlobRecord> Blobs()
            => blobs(State);

        internal static TableIndex? index(Handle handle)
        {
            if(MetadataTokens.TryGetTableIndex(handle.Kind, out var table))
                return table;
            else
                return null;
        }

        public static ConstantHandle ConstantHandle(uint row)
            => MetadataTokens.ConstantHandle((int)row);

        [MethodImpl(Inline), Op]
        public static int ConstantCount(in ReaderState state)
            => state.Reader.GetTableRowCount(I.Constant);

        public static CliHandleToken? describe(in ReaderState state, Handle handle)
        {
            if(!handle.IsNil)
            {
                var table = index(handle);
                var token = state.Reader.GetToken(handle);
                if (table != null)
                    return new CliHandleToken(handle, token, table.Value);
            }

            return null;
        }
    }
}