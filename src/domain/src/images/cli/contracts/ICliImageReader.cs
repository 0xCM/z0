//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection.PortableExecutable;
    using System.Reflection.Metadata;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    using static Konst;

    [Free]
    public interface ICliImageReader : IImageReader
    {
        PEMemoryBlock CliMetadata {get;}

        CorHeader CorHeader {get;}

        DirectoryEntry ResourcesDirectory
            => CorHeader.ResourcesDirectory;

        DirectoryEntry CodeManagerTableDirectory
            => CorHeader.CodeManagerTableDirectory;

        DirectoryEntry ExportAddressTableJumpsDirectory
            => CorHeader.ExportAddressTableJumpsDirectory;

        CorFlags Flags
            => CorHeader.Flags;

        DirectoryEntry ManagedNativeHeaderDirectory
            => CorHeader.ManagedNativeHeaderDirectory;


        DirectoryEntry MetadataDirectory
            => CorHeader.MetadataDirectory;

        DirectoryEntry VtableFixupsDirectory
            => CorHeader.VtableFixupsDirectory;

        ReadOnlySpan<byte> Resources {get;}

        MetadataReader CliReader {get;}

        ReadOnlySpan<ManifestResourceHandle> ManifestResourceHandles();

        ReadOnlySpan<CliManifestResourceInfo> ManifestResourceDescriptions();

        ManifestResource Read(ManifestResourceHandle src);

        ref ManifestResource Read(ManifestResourceHandle src, out ManifestResource dst);

        Span<CliManifestResourceInfo> Read(ReadOnlySpan<ManifestResourceHandle> src, Span<CliManifestResourceInfo> dst);

        ref CliManifestResourceInfo Read(in ManifestResource src, ref CliManifestResourceInfo dst);

        BinaryCode Read(BlobHandle src);

        ref BinaryCode Read(BlobHandle src, ref BinaryCode dst);

        ReadOnlySpan<AssemblyFileHandle> AssemblyFileHandles();

        AssemblyFile Read(AssemblyFileHandle src);

        ref AssemblyFile Read(AssemblyFileHandle src, ref AssemblyFile dst);

        void Read(ReadOnlySpan<AssemblyFileHandle> src, Span<AssemblyFile> dst);

        void Read(TableSpan<CustomAttributeHandle> src, Receiver<CustomAttribute> dst);

        FieldDefinition Read(FieldDefinitionHandle src);

        ref FieldDefinition Read(FieldDefinitionHandle src, ref FieldDefinition dst);

        void Read(ReadOnlySpan<FieldDefinitionHandle> src, Span<FieldDefinition> dst);

        ReadOnlySpan<MethodDefinitionHandle> MethodDefinitionHandles();

        ref MethodBodyBlock Read(MethodDefinition src, ref MethodBodyBlock dst);

        MethodDefinition Read(MethodDefinitionHandle src);

        ref MethodDefinition Read(MethodDefinitionHandle src, ref MethodDefinition dst);

        void Read(ReadOnlySpan<MethodDefinitionHandle> src, Span<MethodDefinition> dst);

        MethodImplementation Read(MethodImplementationHandle src);

        ref MethodImplementation Read(MethodImplementationHandle src, ref MethodImplementation dst);

        void Read(ReadOnlySpan<MethodImplementationHandle> src, Span<MethodImplementation> dst);

        string Read(StringHandle src);

        ref string Read(StringHandle src, ref string dst);

        void Read(TypeDefinitionHandle src, Receiver<TypeDefinition> dst);

        void Read(TableSpan<TypeDefinitionHandle> src, Receiver<TypeDefinition> dst);
    }
}