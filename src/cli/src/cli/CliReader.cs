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
    using static CliRows;

    using K = CliTableKinds;

    [ApiHost]
    public unsafe class CliReader
    {
        [MethodImpl(Inline), Op]
        public static ManifestResourceHandle reshandle(uint row)
            => MetadataTokens.ManifestResourceHandle((int)row);

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

        public ReadOnlySpan<byte> RawData
        {
            [MethodImpl(Inline)]
            get => memory.view<byte>(Segment);
        }

        [MethodImpl(Inline), Op]
        public Address32 HeapOffset(UserStringHandle handle)
            => (Address32)MD.GetHeapOffset(handle);

        [MethodImpl(Inline), Op]
        public Address32 HeapOffset(BlobHandle handle)
            => (Address32)MD.GetHeapOffset(handle);

        [MethodImpl(Inline), Op]
        public Address32 HeapOffset(StringHandle handle)
            => (Address32)MD.GetHeapOffset(handle);

        [MethodImpl(Inline), Op]
        public Address32 HeapOffset(GuidHandle handle)
            => (Address32)MD.GetHeapOffset(handle);

        [MethodImpl(Inline), Op]
        public ByteSize HeapSize(HeapIndex index)
            => MD.GetHeapSize(index);

        [MethodImpl(Inline), Op]
        public void Read(Index<CustomAttributeHandle> src, Receiver<CustomAttribute> dst)
            => src.Iter(handle => dst(MD.GetCustomAttribute(handle)));

        [Op]
        public CliGuidHeap GuidHeap()
        {
            var offset = HeapOffset(MetadataTokens.GuidHandle(0));
            var @base = Segment.BaseAddress + offset;
            return new CliGuidHeap(@base, HeapSize(HeapIndex.Guid));
        }

        [Op]
        public CliBlobHeap BlobHeap()
        {
            var offset = HeapOffset(MetadataTokens.BlobHandle(0));
            var @base = Segment.BaseAddress + offset;
            return new CliBlobHeap(@base, HeapSize(HeapIndex.Blob));
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
        [MethodImpl(Inline), Op]
        public ReadOnlySpan<AssemblyReferenceHandle> AssemblyRefHandles()
            => MD.AssemblyReferences.ToReadOnlySpan();

        [MethodImpl(Inline), Op]
        public NamespaceDefinition NamespaceRoot()
            => MD.GetNamespaceDefinitionRoot();

        [MethodImpl(Inline), Op]
        public ReadOnlySpan<ManifestResourceHandle> ResourceHandles()
            => MD.ManifestResources.ToReadOnlySpan();

        [MethodImpl(Inline), Op]
        public AssemblyFile Read(AssemblyFileHandle src)
            => MD.GetAssemblyFile(src);

        [MethodImpl(Inline), Op]
        public AssemblyReference Read(AssemblyReferenceHandle src)
            => MD.GetAssemblyReference(src);

        [MethodImpl(Inline), Op]
        public CustomAttribute Read(CustomAttributeHandle src)
            => MD.GetCustomAttribute(src);

        [MethodImpl(Inline), Op]
        public ExportedType Read(ExportedTypeHandle src)
            => MD.GetExportedType(src);

        [MethodImpl(Inline), Op]
        public FieldDefinition Read(FieldDefinitionHandle src)
            => MD.GetFieldDefinition(src);

        [MethodImpl(Inline), Op]
        public MethodDebugInformation Read(MethodDebugInformationHandle src)
            => MD.GetMethodDebugInformation(src);

        [MethodImpl(Inline), Op]
        public MethodImplementation Read(MethodImplementationHandle src)
            => MD.GetMethodImplementation(src);

        [MethodImpl(Inline), Op]
        public ManifestResource Read(ManifestResourceHandle src)
            => MD.GetManifestResource(src);

        [MethodImpl(Inline), Op]
        public MemberReference Read(MemberReferenceHandle src)
            => MD.GetMemberReference(src);

        [MethodImpl(Inline), Op]
        public BinaryCode Read(BlobHandle src)
            => MD.GetBlobBytes(src);

        [MethodImpl(Inline), Op]
        public string Read(UserStringHandle handle)
            => MD.GetUserString(handle);

        [MethodImpl(Inline), Op]
        public string Read(StringHandle src)
            => MD.GetString(src);

        [MethodImpl(Inline), Op]
        public void Read(ReadOnlySpan<TypeDefinitionHandle> src, Span<TypeDefinition> dst)
        {
            var count = src.Length;
            for(var i=0u; i<count; i++)
                seek(dst,i) = Read(skip(src,i));
        }

        [MethodImpl(Inline), Op]
        public ref FieldDefinition Read(FieldDefinitionHandle src, ref FieldDefinition dst)
        {
            dst = Read(src);
            return ref dst;
        }

        [MethodImpl(Inline), Op]
        public void Read(ReadOnlySpan<FieldDefinitionHandle> src, Span<FieldDefinition> dst)
        {
            var count = src.Length;
            for(var i=0u; i<count; i++)
                Read(skip(src,i), ref seek(dst,i));
        }

        [MethodImpl(Inline), Op]
        public ref MethodImplementation Read(MethodImplementationHandle src, ref MethodImplementation dst)
        {
            dst = Read(src);
            return ref dst;
        }

        [MethodImpl(Inline), Op]
        public void Read(ReadOnlySpan<MethodImplementationHandle> src, Span<MethodImplementation> dst)
        {
            var count = src.Length;
            for(var i=0u; i<count; i++)
                Read(skip(src,i), ref seek(dst,i));
        }

        [MethodImpl(Inline), Op]
        public ref AssemblyFile Read(AssemblyFileHandle src, ref AssemblyFile dst)
        {
            dst = Read(src);
            return ref dst;
        }

        [MethodImpl(Inline), Op]
        public void Read(ReadOnlySpan<AssemblyFileHandle> src, Span<AssemblyFile> dst)
        {
            var count = src.Length;
            for(var i=0u; i<count; i++)
                Read(skip(src,i), ref seek(dst,i));
        }

        public AssemblyRefRow Row(AssemblyReferenceHandle handle)
        {
            var dst = new AssemblyRefRow();
            var src = MD.GetAssemblyReference(handle);
            dst.Culture = src.Culture;
            dst.Flags = src.Flags;
            dst.Hash = src.HashValue;
            dst.Token = src.PublicKeyOrToken;
            dst.Version = src.Version;
            dst.Name = src.Name;
            return dst;
        }

        [MethodImpl(Inline), Op]
        public PropertyDefinition Read(PropertyDefinitionHandle src)
            => MD.GetPropertyDefinition(src);

        [MethodImpl(Inline), Op]
        public TypeDefinition Read(TypeDefinitionHandle src)
            => MD.GetTypeDefinition(src);

        [MethodImpl(Inline), Op]
        public TypeReference Read(TypeReferenceHandle src)
            => MD.GetTypeReference(src);

        [MethodImpl(Inline), Op]
        public NamespaceDefinition Read(NamespaceDefinitionHandle src)
            => MD.GetNamespaceDefinition(src);

        [MethodImpl(Inline), Op]
        public BinaryCode ReadSig(FieldDefinition src)
            => Read(src.Signature);

        [MethodImpl(Inline), Op]
        public BinaryCode ReadSig(MethodDefinition src)
            => Read(src.Signature);

        [MethodImpl(Inline), Op]
        public MethodDefRow Read(MethodDefinitionHandle handle)
        {
            var src = MD.GetMethodDefinition(handle);
            var dst = new MethodDefRow();
            dst.Attributes = src.Attributes;
            dst.ImplAttributes  = src.ImplAttributes;
            dst.Rva = src.RelativeVirtualAddress;
            dst.Name = src.Name;
            dst.Signature = src.Signature;
            var keys = Cli.keys(src.GetParameters());
            var count = keys.Count;
            if(count != 0)
            {
                dst.FirstParam = keys.First;
                dst.ParamCount = (ushort)count;
            }
            return dst;
        }

        [MethodImpl(Inline), Op]
        public void Read(ReadOnlySpan<MethodDefinitionHandle> src, Span<MethodDefRow> dst)
        {
            var count = src.Length;
            for(var i=0u; i<count; i++)
                 seek(dst,i) = Read(skip(src,i));
        }

        public ReadOnlySpan<string> UserStrings()
        {
            int size = HeapSize(HeapIndex.UserString);
            if (size == 0)
                return sys.empty<string>();

            var values = root.list<string>();
            var handle = MetadataTokens.UserStringHandle(0);
            do
            {
                values.Add(Read(handle));
                handle = MD.GetNextHandle(handle);
            }
            while (!handle.IsNil);

            return values.ViewDeposited();
        }

        public ReadOnlySpan<string> SystemStrings()
        {
            int size = HeapSize(HeapIndex.String);
            if (size == 0)
                return sys.empty<string>();

            var values = root.list<string>();
            var handle = MetadataTokens.StringHandle(0);
            do
            {
                values.Add(Read(handle));
                handle = MD.GetNextHandle(handle);
            }
            while (!handle.IsNil);

            return values.ViewDeposited();
        }

        internal static string format(FieldAttributes src)
            => src.ToString();

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
                field.Attribs = format(entry.Attributes);
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

    }
}