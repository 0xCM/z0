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

    using static Part;
    using static memory;

    using static CliRows;

    using K = CliTableKinds;

    [ApiHost]
    public unsafe readonly partial struct CliReader
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
            get => view<byte>(Segment);
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
        public CliRowKeys<K.AssemblyRef> AssemblyRefKeys()
            => Cli.keys(MD.AssemblyReferences);

        [MethodImpl(Inline), Op]
        public CliRowKeys<K.Field> FieldDefKeys()
            => Cli.keys(MD.FieldDefinitions);

        [MethodImpl(Inline), Op]
        public CliRowKeys<K.MethodDef> MethodDefKeys()
            => Cli.keys(MD.MethodDefinitions);

        [MethodImpl(Inline), Op]
        public CliRowKeys<K.MethodDebugInformation> MethodDebugKeys()
            => Cli.keys(MD.MethodDebugInformation);

        [MethodImpl(Inline), Op]
        public CliRowKeys<K.MemberRef> MemberRefKeys()
            => Cli.keys(MD.MemberReferences);

        [MethodImpl(Inline), Op]
        public CliRowKeys<K.Property> PropertyDefKeys()
            => Cli.keys(MD.PropertyDefinitions);

        [MethodImpl(Inline), Op]
        public CliRowKeys<K.TypeDef> TypeDefKeys()
            => Cli.keys(MD.TypeDefinitions);

        [MethodImpl(Inline), Op]
        public CliRowKeys<K.TypeRef> TypeRefKeys()
            => Cli.keys(MD.TypeReferences);

        [MethodImpl(Inline), Op]
        public AssemblyFile Read(AssemblyFileHandle src)
            => MD.GetAssemblyFile(src);

        [MethodImpl(Inline), Op]
        public AssemblyReference Read(AssemblyReferenceHandle src)
            => MD.GetAssemblyReference(src);

        [MethodImpl(Inline), Op]
        public ReadOnlySpan<CliRows.AssemblyRefInfo> Describe(ReadOnlySpan<AssemblyReferenceHandle> src)
        {
            var count = src.Length;
            var dst = alloc<CliRows.AssemblyRefInfo>(count);
            for(var i=0; i<count; i++)
            {
                seek(dst,i) = Describe(skip(src,i));
            }
            return dst;
        }

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
        public MemberReference Read(MemberReferenceHandle src)
            => MD.GetMemberReference(src);

        [MethodImpl(Inline), Op]
        public MethodDebugInformation Read(MethodDebugInformationHandle src)
            => MD.GetMethodDebugInformation(src);

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

        [MethodImpl(Inline), Op]
        public MethodImplementation Read(MethodImplementationHandle src)
            => MD.GetMethodImplementation(src);

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
        public ManifestResource Read(ManifestResourceHandle src)
            => MD.GetManifestResource(src);

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
        public BinaryCode ReadSig(FieldDefinition src)
            => Read(src.Signature);

        [MethodImpl(Inline), Op]
        public BinaryCode ReadSig(MethodDefinition src)
            => Read(src.Signature);

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
    }
}