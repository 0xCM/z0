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
    using System.IO;
    using System.Linq;

    using static Konst;
    using static z;

    partial struct Cil
    {
        public static ReadOnlySpan<CilMethodData> data(FS.FilePath src)
        {
            var dst = list<CilMethodData>();

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
        [MethodImpl(Inline), Op]
        public static CilOpCodeSymbol symbol(ILOpCode id)
            => new CilOpCodeSymbol(id);

        [MethodImpl(Inline)]
        public static CilOpCodeSymbol symbol<K>(K k = default)
            where K : unmanaged, ICilOpCode<K>
                => new CilOpCodeSymbol((ILOpCode)(default(K).Id));
    }
}