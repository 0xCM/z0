//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection.Metadata;
    using System.Linq;

    using static Part;
    using static memory;
    using static Images;

    partial class ImageMetaReader
    {
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
                            Token = Clr.token(method),
                            ImageName = Source.FileName,
                            BodySize = body.Size,
                            LocalInit = body.LocalVariablesInitialized,
                            MaxStack = body.MaxStack,
                            MethodName = Clr.membername(MetadataReader.GetString(definition.Name)),
                            Code = body.GetILBytes(),
                        });
                    }
                 }
            }
            return dst.ToArray();
        }
    }
}