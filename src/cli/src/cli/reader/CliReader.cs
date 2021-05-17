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

        public ByteSize MetadataSize
        {
            [MethodImpl(Inline)]
            get => Segment.Size;
        }

        public ReadOnlySpan<byte> MetaBlock
        {
            [MethodImpl(Inline)]
            get => memory.view<byte>(Segment);
        }


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

        public ReadOnlySpan<MemberFieldInfo> ReadFieldInfo()
        {
            var reader = MD;
            var handles = reader.FieldDefinitions.ToReadOnlySpan();
            var count = handles.Length;
            var dst = memory.span<MemberFieldInfo>(count);
            for(var i=0u; i<count; i++)
            {
                ref readonly var handle = ref skip(handles,i);
                var entry = reader.GetFieldDefinition(handle);
                int offset = entry.GetOffset();
                ref var field = ref seek(dst,i);
                var bsig = ReadSig(entry);
                var name = ReadFieldName(entry.Name, i);

                field.Token = CliTokens.token(handle);
                field.FieldName = name.Value;
                field.Attribs = entry.Attributes.ToString();
                field.Sig = bsig;
            }
            return dst;
        }

        MemberFieldName ReadFieldName(StringHandle handle, Count seq)
        {
            var value = MD.GetString(handle);
            var offset = MD.GetHeapOffset(handle);
            var size = MD.GetHeapSize(HeapIndex.String);
            return new MemberFieldName(seq, size, (Address32)offset, value);
        }

        [MethodImpl(Inline), Op]
        public ref ManifestResource ReadResource(ManifestResourceHandle src, out ManifestResource dst)
        {
            dst = Read(src);
            return ref dst;
        }
    }
}