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

    public class CliDataReader : IDisposable
    {
        public static CliDataReader create(FS.FilePath src)
            => new CliDataReader(src);

        readonly FS.FilePath Source;

        readonly FileStream Stream;

        public PEReader PeReader {get;}

        public MetadataReader MetadataReader {get;}

        public PEMemoryBlock MetadataBlock {get;}


        public CliDataReader(FS.FilePath src)
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

        public Index<MsilRow> ReadMsil()
        {
            var dst = sys.list<MsilRow>();
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
                        dst.Add(new MsilRow
                        {
                            MethodRva = (Address32)rva,
                            ImageName = Source.FileName,
                            BodySize = body.Size,
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