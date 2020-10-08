//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Security;
    using System.Reflection.Metadata;
    using System.Reflection.PortableExecutable;
    using System.IO;
    using System.Linq;

    using static Konst;
    using static z;

    public readonly struct ClrFileReader
    {
        public static ReadOnlySpan<CilMethodData> cil(PartId part, FS.FilePath src)
        {
            var dst = list<CilMethodData>();

            using var stream = File.OpenRead(src.Name);
            using var pe = new PEReader(stream);

            var reader = pe.GetMetadataReader();
            var types = @readonly(reader.TypeDefinitions.ToArray());
            var typeCount = types.Length;
            for(var k=0u; k<typeCount; k++)
            {
                 var hType = skip(types, k);
                 var hMethods = reader.GetTypeDefinition(hType).GetMethods().Array();
                 var methodCount = hMethods.Length;
                 var methodDefs = map(hMethods, m=> reader.GetMethodDefinition(m));
                 var view = @readonly(methodDefs);
                 var buffer = alloc<CilMethodData>(methodCount);
                 var target = span(buffer);
                 for(var i=0u; i<methodCount; i++)
                 {
                    ref readonly var def = ref skip(view,i);
                    var rva = def.RelativeVirtualAddress;
                    if(rva != 0)
                    {
                        var body = pe.GetMethodBody(rva);
                        dst.Add(new CilMethodData
                        {
                            Sig = reader.GetBlobBytes(def.Signature),
                            Name = reader.GetString(def.Name),
                            Rva = (Address32)rva,
                            Cil = body.GetILBytes(),
                            Size = body.Size
                        });
                    }
                 }
            }

            return dst.ToArray();
        }
    }
}