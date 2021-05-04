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
    using System.IO;

    using static Part;
    using static memory;
    using static ImageRecords;

    [ApiHost]
    public unsafe readonly struct CliReader
    {
        [Op]
        public static CliReader create(Assembly src)
            => new CliReader(src);

        [Op]
        public static CliReader create(MetadataReader src)
            => new CliReader(src);

        [Op]
        public static CliReader create(MemSeg src)
            => new CliReader(src);

        [Op]
        public static TableIndex? table(Handle handle)
        {
            if(MetadataTokens.TryGetTableIndex(handle.Kind, out var table))
                return table;
            else
                return null;
        }

        [MethodImpl(Inline), Op]
        public static ManifestResourceHandle reshandle(uint row)
            => MetadataTokens.ManifestResourceHandle((int)row);

        readonly MetadataReader MD;

        readonly MemSeg Segment;

        [MethodImpl(Inline)]
        public CliReader(Assembly src)
        {
            Segment = Clr.metadata(src);
            MD = new MetadataReader(Segment.BaseAddress.Pointer<byte>(), Segment.Size);
        }

        [MethodImpl(Inline)]
        public CliReader(MemSeg src)
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

        [Op]
        public StringHeap StringHeap()
        {
            var size = MD.GetHeapSize(HeapIndex.String);
            var handle = MetadataTokens.StringHandle(0);
            var offset = MD.GetHeapOffset(handle);
            var @base = Segment.BaseAddress + offset;
            return new StringHeap(@base, size);
        }

        [MethodImpl(Inline), Op]
        public ReadOnlySpan<AssemblyFileHandle> AssemblyFileHandles()
            => MD.AssemblyFiles.ToReadOnlySpan();

        [MethodImpl(Inline), Op]
        public ReadOnlySpan<AssemblyReferenceHandle> AssemblyRefHandles()
            => MD.AssemblyReferences.ToReadOnlySpan();

        [MethodImpl(Inline), Op]
        public ReadOnlySpan<CustomAttributeHandle> CustomAttributeHandles()
            => MD.CustomAttributes.ToReadOnlySpan();

        [MethodImpl(Inline), Op]
        public ReadOnlySpan<CustomDebugInformationHandle> CustomDebugInfoHandles()
            => MD.CustomDebugInformation.ToReadOnlySpan();

        [MethodImpl(Inline), Op]
        public ReadOnlySpan<DocumentHandle> DocumentHandles()
            => MD.Documents.ToReadOnlySpan();

        [MethodImpl(Inline), Op]
        public ReadOnlySpan<ExportedTypeHandle> ExportedTypeHandles()
            => MD.ExportedTypes.ToReadOnlySpan();

        [MethodImpl(Inline), Op]
        public ReadOnlySpan<FieldDefinitionHandle> FieldDefHandles()
            => MD.FieldDefinitions.ToReadOnlySpan();

        [MethodImpl(Inline), Op]
        public ReadOnlySpan<LocalConstantHandle> LocalConstantHandles()
            => MD.LocalConstants.ToReadOnlySpan();

        [MethodImpl(Inline), Op]
        public ReadOnlySpan<LocalScopeHandle> LocalScopeHandles()
            => MD.LocalScopes.ToReadOnlySpan();

        [MethodImpl(Inline), Op]
        public ReadOnlySpan<LocalVariableHandle> LocalVarHandles()
            => MD.LocalVariables.ToReadOnlySpan();

        [MethodImpl(Inline), Op]
        public ReadOnlySpan<MethodDebugInformationHandle> MethodDebugInfoHandles()
            => MD.MethodDebugInformation.ToReadOnlySpan();

        [MethodImpl(Inline), Op]
        public ReadOnlySpan<MethodDefinitionHandle> MethodDefHandles()
            => MD.MethodDefinitions.ToReadOnlySpan();

        [MethodImpl(Inline), Op]
        public ReadOnlySpan<MemberReferenceHandle> MemberRefHandles()
            => MD.MemberReferences.ToReadOnlySpan();

        [MethodImpl(Inline), Op]
        public NamespaceDefinition NamespaceRoot()
            => MD.GetNamespaceDefinitionRoot();

        [MethodImpl(Inline), Op]
        public ReadOnlySpan<PropertyDefinitionHandle> PropertyDefHandles()
            => MD.PropertyDefinitions.ToReadOnlySpan();

        [MethodImpl(Inline), Op]
        public ReadOnlySpan<ManifestResourceHandle> ResourceHandles()
            => MD.ManifestResources.ToReadOnlySpan();

        [MethodImpl(Inline), Op]
        public ReadOnlySpan<TypeDefinitionHandle> TypeDefHandles()
            => MD.TypeDefinitions.ToReadOnlySpan();

        [MethodImpl(Inline), Op]
        public ReadOnlySpan<TypeReferenceHandle> TypeRefHandles()
            => MD.TypeReferences.ToReadOnlySpan();

        [MethodImpl(Inline), Op]
        public RowKeys AssemblyRefKeys()
            => Cli.keys(MD.AssemblyReferences);

        [MethodImpl(Inline), Op]
        public RowKeys FieldDefKeys()
            => Cli.keys(MD.FieldDefinitions);

        [MethodImpl(Inline), Op]
        public RowKeys MethodDefKeys()
            => Cli.keys(MD.MethodDefinitions);

        [MethodImpl(Inline), Op]
        public RowKeys MethodDebugKeys()
            => Cli.keys(MD.MethodDebugInformation);

        [MethodImpl(Inline), Op]
        public RowKeys MemberRefKeys()
            => Cli.keys(MD.MemberReferences);

        [MethodImpl(Inline), Op]
        public RowKeys PropertyDefKeys()
            => Cli.keys(MD.PropertyDefinitions);

        [MethodImpl(Inline), Op]
        public RowKeys TypeDefKeys()
            => Cli.keys(MD.TypeDefinitions);

        [MethodImpl(Inline), Op]
        public RowKeys TypeRefKeys()
            => Cli.keys(MD.TypeReferences);

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
            dst.Key = Cli.key(handle);
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

        [MethodImpl(Inline), Op]
        public CliRowIndex RowIndex(Handle handle)
        {
            if(!handle.IsNil)
            {
                var _table = table(handle);
                if (_table != null)
                    return new CliRowIndex(MD.GetToken(handle), _table.Value);
            }

            return CliRowIndex.Empty;
        }
    }
}