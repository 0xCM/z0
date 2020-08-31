//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;
    using System.Reflection.Metadata;
    using System.Reflection.PortableExecutable;
    using System.Reflection.Metadata.Ecma335;
    using System.IO;
    using System.Linq;

    using static Konst;
    using static z;

    partial class PeTableReader
    {
        public static ReadOnlySpan<MethodDetail> methods(in ReaderState state)
        {
            var details = list<MethodDetail>();
            var reader = state.Reader;
            var typedefs = reader.TypeDefinitions.ToReadOnlySpan();
            var kTypes = typedefs.Length;
            for(var i=0u; i<kTypes; i++)
            {
                ref readonly var hType = ref skip(typedefs,i);
                var tDef = reader.GetTypeDefinition(hType);
                var implementations = tDef.GetMethodImplementations().ToReadOnlySpan().Map(h => reader.GetMethodImplementation(h));
                var definitions = tDef.GetMethods().ToReadOnlySpan().Map(h => reader.GetMethodDefinition(h));
                var hMethods = tDef.GetMethods().ToReadOnlySpan();
                var mCount = hMethods.Length;
                for(var j=0; j<mCount; j++)
                {
                    var def = reader.GetMethodDefinition(skip(hMethods,j));
                    var dst = default(MethodDetail);
                    dst.Rva = (Address32)def.RelativeVirtualAddress;
                    dst.Sig = data(reader,def.Signature);
                    dst.Attribs = def.Attributes;
                    dst.ImplAttribs = def.ImplAttributes;
                    dst.Name = data(reader, def.Name);
                    details.Add(dst);
                }
            }

            return details.ToArray();
        }

        public static ReadOnlySpan<ImageMethodBody> methods(FS.FilePath src)
        {
            var dst = list<ImageMethodBody>();

            using var stream = File.OpenRead(src.Name);
            using var pe = new PEReader(stream);

            var reader = pe.GetMetadataReader();
            var types = @readonly(reader.TypeDefinitions.ToArray());
            var typeCount = types.Length;
            for(var k=0u; k<typeCount; k++)
            {
                 var handle = skip(types, k);
                 var methodDefs = map(reader.GetTypeDefinition(handle).GetMethods(), m => reader.GetMethodDefinition(m));
                 var methodCount = methodDefs.Length;
                 var view = @readonly(methodDefs);
                 var buffer = alloc<ImageMethodBody>(methodCount);
                 var target = span(buffer);
                 for(var i=0u; i<methodCount; i++)
                 {
                    ref readonly var def = ref skip(view,i);
                    var rva = def.RelativeVirtualAddress;
                    if(rva != 0)
                    {
                        var body = pe.GetMethodBody(rva);
                        var sig = data(reader, def.Signature);
                        var name = reader.GetString(def.Name);
                        var il = body.GetILBytes();
                        dst.Add(new ImageMethodBody{Sig = sig, Name = name, Rva = (uint)rva, Cil = il});
                    }
                 }
            }

            return dst.ToArray();
        }
    }
}