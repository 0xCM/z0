//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;
    using System.Collections.Generic;
    using System.Linq;
    
    using static Memories;
 
    using Z0.Asm.Data;

    public class t_memstore : t_asmd<t_memstore>
    {
        public  void run_it()
        {
            var svc = ResStoreModels.Service;
            var store = svc.store();
            var results = svc.locations(store);
            var dst = CaseWriter(FileExtensions.Csv);
            for(var i=0; i<results.Length; i++)
            {
                var result = results[i];
                Claim.yea(result.IsNonEmpty);
                dst.WriteLine(result);

                //Trace(result);
            }
        }

        unsafe void Process(in MemRef src, in MemStore store)
        {
            var reader = PointedReader.create(src.Address.Pointer<byte>(), src.Length);
            var dstA = Spans.alloc<byte>(src.Length);            
            var count = reader.ReadAll(dstA);            
            Claim.eq(count,src.Length);

            var dstB = MemStores.Service.load(src);
            Claim.eq(count, dstB.Length);

            for(var i=0; i<count; i++)
            {
                ref readonly var a = ref skip(dstA,i);
                ref readonly var b = ref skip(dstB,i);
                Claim.Eq(a,b);
            }
        }

        public void Resource_Prop_Cil()
        {
            var summary = CaseWriter(FileExtensions.Csv);
            var header = text.concat("Type".PadRight(20), "| ", "Property".PadRight(30), "| ", "Cil Bytes");
            summary.WriteLine(header);

            var types = array(typeof(SymbolKonst), typeof(VectorKonst));
            var mod = types[0].Module;
            var props = types.StaticProperties().Where(p => p.GetGetMethod() != null && p.PropertyType == typeof(ReadOnlySpan<byte>));

            foreach(var p in props)
            {
                var m = p.GetGetMethod();
                var body = m.GetMethodBody();
                var cil = body.GetILAsByteArray();
                var line = string.Concat(m.DeclaringType.Name.PadRight(20), "| ", m.Name.PadRight(30), "| ", cil.FormatHexBytes());
                summary.WriteLine(line);
            }

            var decoded = CilServices.decode(mod,props.Select(x => x.GetGetMethod())).ToArray();
            var cilwriter = new CilFunctionWriter(CasePath(FileExtensions.Il));
            cilwriter.Write(decoded);        
        }

        public void emit_data()
        {
                                
            var refs = Digits.HexRefs.ToArray();   
            using var dst = CasePath($"Symbolic").Writer();
            for(var i=0; i<refs.Length; i++)
            {
                var r = refs[i];
                var data = Addresses.cover(r.Address, r.Length);
                dst.WriteLine(data.FormatHexBytes(Chars.Space));

            }
        }

        public void run_2()
        {
            var svc = ResStoreModels.Service;
            var store = svc.store();
            var sources = store.Sources;
            for(var i=0; i<sources.Length; i++)
                Process(skip(sources,i), store);
        }
    }
}