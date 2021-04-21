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
    using static Images;

    [ApiHost]
    public partial class ImageMetaReader : IDisposable
    {
        public static ImageMetaReader create(FS.FilePath src)
            => new ImageMetaReader(src);

        [Op]
        public static bool HasMetadata(FS.FilePath src)
        {
            using var stream = File.OpenRead(src.Name);
            using var reader = new PEReader(stream);
            return reader.HasMetadata;
        }

        readonly FS.FilePath Source;

        readonly FileStream Stream;

        public PEReader PeReader {get;}

        public MetadataReader MetadataReader {get;}

        public PEMemoryBlock MetadataBlock {get;}

        public ImageMetaReader(FS.FilePath src)
        {
            Source = src;
            Stream = File.OpenRead(src.Name);
            PeReader = new PEReader(Stream);
            MetadataReader = PeReader.GetMetadataReader();
            MetadataBlock = PeReader.GetMetadata();
        }

        public void Dispose()
        {
            PeReader?.Dispose();
            Stream?.Dispose();
        }

        [MethodImpl(Inline), Op]
        public ReadOnlySpan<MethodDefinitionHandle> MethodDefHandles()
            => MetadataReader.MethodDefinitions.ToReadOnlySpan();

        [MethodImpl(Inline), Op]
        public ref MethodBodyBlock Read(MethodDefinition src, ref MethodBodyBlock dst)
        {
            dst = PeReader.GetMethodBody(src.RelativeVirtualAddress);
            return ref dst;
        }

        [MethodImpl(Inline), Op]
        public MethodDefinition ReadMethodDef(MethodDefinitionHandle src)
            => MetadataReader.GetMethodDefinition(src);

        [MethodImpl(Inline), Op]
        public ref MethodDefinition ReadMethodDef(MethodDefinitionHandle src, ref MethodDefinition dst)
        {
            dst = ReadMethodDef(src);
            return ref dst;
        }

        [MethodImpl(Inline), Op]
        public void ReadMeathodDefs(ReadOnlySpan<MethodDefinitionHandle> src, Span<MethodDefinition> dst)
        {
            var count = src.Length;
            for(var i=0u; i<count; i++)
                 ReadMethodDef(skip(src,i), ref seek(dst,i));
        }

        [MethodImpl(Inline), Op]
        public MethodImplementation ReadMethodImpl(MethodImplementationHandle src)
            => MetadataReader.GetMethodImplementation(src);

        [MethodImpl(Inline), Op]
        public ref MethodImplementation ReadMethodImpl(MethodImplementationHandle src, ref MethodImplementation dst)
        {
            dst = ReadMethodImpl(src);
            return ref dst;
        }

        [MethodImpl(Inline), Op]
        public void ReadMethodImpls(ReadOnlySpan<MethodImplementationHandle> src, Span<MethodImplementation> dst)
        {
            var count = src.Length;
            for(var i=0u; i<count; i++)
                ReadMethodImpl(skip(src,i), ref seek(dst,i));
        }

        [MethodImpl(Inline), Op]
        public void ReadAttributes(TableSpan<CustomAttributeHandle> src, Receiver<CustomAttribute> dst)
            => src.Iter(handle => dst(MetadataReader.GetCustomAttribute(handle)));

        public Index<MsilMetadata> ReadMsil()
        {
            var dst = sys.list<MsilMetadata>();
            var types = @readonly(MetadataReader.TypeDefinitions.ToArray());
            var typeCount = types.Length;
            for(var k=0u; k<typeCount; k++)
            {
                 var hType = skip(types, k);
                 var methods = @readonly(MetadataReader.GetTypeDefinition(hType).GetMethods().Array());
                 var methodCount = methods.Length;
                 var definitions = @readonly(root.map(methods, m=> MetadataReader.GetMethodDefinition(m)));
                 for(var i=0u; i<methodCount; i++)
                 {
                    ref readonly var method = ref skip(methods,i);
                    ref readonly var definition = ref skip(definitions,i);
                    var rva = definition.RelativeVirtualAddress;
                    if(rva != 0)
                    {
                        var body = PeReader.GetMethodBody(rva);
                        dst.Add(new MsilMetadata
                        {
                            MethodRva = (Address32)rva,
                            ImageName = Source.FileName,
                            BodySize = body.Size,
                            LocalInit = body.LocalVariablesInitialized,
                            MaxStack = body.MaxStack,
                            MethodName = MetadataReader.GetString(definition.Name),
                            Code = body.GetILBytes(),
                        });
                    }
                 }
            }
            return dst.ToArray();
        }
    }
}