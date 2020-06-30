//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;
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
            for(var i=0; i<results.Length; i++)
            {
                var result = results[i];
                Claim.yea(result.IsNonEmpty);
                Trace(result);
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

        public void search()
        {
            var src = typeof(Konst).Assembly;

            var xRef = MemRef.memref(SymbolKonst.UpperHexCodes);            

            var xProp = src.Properties().WithName("UpperHexCodes").Single();
            
            var xMethod = xProp.GetGetMethod();
            Trace(xMethod.Name);

            var xBody = xMethod.GetMethodBody();
            var xCil = xBody.GetILAsByteArray();
            Trace($"{xMethod.Name} {xRef} {xCil.FormatHexBytes()}");            

        }

        public void emit_data()
        {
                                
            var refs = Digits.HexRefs.ToArray();   
            for(var i=0; i<refs.Length; i++)
            {
                var r = refs[i];
                var data = Addresses.cover(r.Address, r.Length);
                using var dst = CasePath($"Symbolic{i}").Writer();
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