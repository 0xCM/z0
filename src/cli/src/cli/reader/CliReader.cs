//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Reflection.Metadata;
    using System.Reflection.PortableExecutable;
    using System.Reflection.Metadata.Ecma335;

    using static Root;
    using static core;

    [ApiHost]
    public unsafe partial class CliReader
    {
        readonly MetadataReader MD;

        readonly MemorySeg Segment;

        [MethodImpl(Inline)]
        public CliReader(Assembly src)
        {
            Segment = Clr.metadata(src);
            MD = new MetadataReader(Segment.BaseAddress.Pointer<byte>(), Segment.Size);
        }

        [MethodImpl(Inline)]
        public CliReader(MemorySeg src)
        {
            Segment = src;
            MD = new MetadataReader(Segment.BaseAddress.Pointer<byte>(), Segment.Size);
        }

        [MethodImpl(Inline)]
        public CliReader(PEMemoryBlock src)
        {
            Segment = memory.segment(src.Pointer, src.Length);
            MD = new MetadataReader(Segment.BaseAddress.Pointer<byte>(), Segment.Size);
        }

        [MethodImpl(Inline)]
        public CliReader(MetadataReader src)
        {
            Segment = memory.segment(src.MetadataPointer, src.MetadataLength);
            MD = src;
        }

        public ByteSize MetaSize
        {
            [MethodImpl(Inline)]
            get => Segment.Size;
        }

        public ReadOnlySpan<byte> MetaBytes
        {
            [MethodImpl(Inline)]
            get => memory.view<byte>(Segment);
        }

        public unsafe SRM.MemoryBlock MemoryBlock()
            => SRM.block(Segment.BaseAddress.Pointer<byte>(), Segment.Length);

        public unsafe Outcome<CliMetadataHeader> Version()
            => SRM.ReadMetadataHeader(MemoryBlock());

        [Op]
        public CliBlob ReadBlobDescription(BlobHandle handle, Count seq)
        {
            var offset = (Address32)MD.GetHeapOffset(handle);
            var value = MD.GetBlobBytes(handle) ?? sys.empty<byte>();
            var size = (uint)MD.GetHeapSize(HeapIndex.Blob);
            var row = new CliBlob();
            row.Sequence = seq;
            row.HeapSize = (uint)MD.GetHeapSize(HeapIndex.Blob);
            row.Offset = (Address32)MD.GetHeapOffset(handle);
            row.Data = value;
            row.DataSize = (uint)row.Data.Length;
            return row;
        }

        public ReadOnlySpan<CliBlob> ReadBlobDescriptions()
        {
            var size = (uint)MD.GetHeapSize(HeapIndex.Blob);
            if (size == 0)
                return Span<CliBlob>.Empty;

            var handle = MetadataTokens.BlobHandle(1);
            var i=0;
            var values = root.list<CliBlob>();
            do
            {
                var value = MD.GetBlobBytes(handle);
                var row = new CliBlob();
                row.Sequence = i++;
                row.HeapSize = size;
                row.Offset = (Address32)MD.GetHeapOffset(handle);
                row.Data = MD.GetBlobBytes(handle);
                row.DataSize = (uint)row.Data.Length;
                values.Add(row);
                handle = MD.GetNextHandle(handle);
            }
            while (!handle.IsNil);

            return values.ToArray();
        }

        public Index<CliUserString> ReadUserStringInfo()
        {
            var reader = MD;
            int size = MD.GetHeapSize(HeapIndex.UserString);
            if (size == 0)
                return sys.empty<CliUserString>();

            var values = root.list<CliUserString>();
            var handle = MetadataTokens.UserStringHandle(0);
            var i=0;

            do
            {
                values.Add(new CliUserString(seq: i++, size, HeapOffset(handle), Read(handle)));
                handle = MD.GetNextHandle(handle);
            }
            while (!handle.IsNil);

            return values.ToArray();
        }

        [MethodImpl(Inline), Op]
        public ref ManifestResource ReadResource(ManifestResourceHandle src, out ManifestResource dst)
        {
            dst = Read(src);
            return ref dst;
        }
    }
}