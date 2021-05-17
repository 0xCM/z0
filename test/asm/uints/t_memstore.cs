//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static memory;

    using Z0.Asm;

    public class t_memstore : t_asm<t_memstore>
    {
        public void read_ref_1()
        {
            var src = array(3u,5u,6u,7u);
            var r = memory.segref(src);
            var z = r.As<uint>();

            Claim.eq(16, r.Length);
            Claim.eq(4, r.CellCount);
            for(var i=0; i<src.Length; i++)
                base.Claim.eq(r[i], (BitVector32)src[i]);
        }

        public void read_models()
        {
            var svc = ConstBytes256.reader();
            var store = svc.Segments();
            var results = svc.Locations(store);
            var dst = CaseWriter(FS.Csv);
            for(var i=0; i<results.Length; i++)
            {
                var result = results[i];
                Claim.yea(result.IsNonEmpty);
                dst.WriteLine(result);
            }
        }

        public void emit_data()
        {
            var refs = HexCharData.Segments;
            using var dst = CasePath($"Symbolic").Writer();
            for(var i=0; i<refs.Length; i++)
            {
                var r = refs[i];
                var data = memory.view(r.BaseAddress, r.Length);
                dst.WriteLine(data.FormatHex());
            }
        }

        public void run_2()
        {
            var svc = ConstBytes256.reader();
            var store = svc.Segments();
            var sources = store.View;
            for(var i=0u; i<sources.Length; i++)
                Process(skip(sources,i), store);
        }

        unsafe void Process(in MemorySeg src, Index<MemorySeg> store)
        {
            var reader = MemoryReader.create(src.BaseAddress.Pointer<byte>(), src.Length);
            var dstA = memory.span<byte>(src.Length);
            var count = reader.ReadAll(dstA);
            Claim.eq(count,src.Length);

            var dstB = MemoryStore.Service.Load(src);
            Claim.eq(count, dstB.Length);

            for(var i=0u; i<count; i++)
            {
                ref readonly var a = ref skip(dstA,i);
                ref readonly var b = ref skip(dstB,i);
                Claim.eq(a,b);
            }
        }

        public void Resource_Prop_Cil()
        {
            var summary = CaseWriter(FS.Csv);
            var header = text.concat("Type".PadRight(20), "| ", "Property".PadRight(30), "| ", "Cil Bytes");
            summary.WriteLine(header);

            var types = array(typeof(HexCharData), typeof(CpuBytes));
            var mod = types[0].Module;
            var props = types.StaticProperties().Where(p => p.GetGetMethod() != null && p.PropertyType == typeof(ReadOnlySpan<byte>));

            foreach(var p in props)
            {
                var m = p.GetGetMethod();
                var body = m.GetMethodBody();
                var cil = body.GetILAsByteArray();
                var line = string.Concat(m.DeclaringType.Name.PadRight(20), "| ", m.Name.PadRight(30), "| ", cil.FormatHex());
                summary.WriteLine(line);
            }

            var getters = props.Getters();
            // var decoded = Cil.methods(mod, getters);
            // var path = FS.path(CasePath(FS.Extensions.Il).Name);
            // var cilWriter = new FunctionWriter(path);
            // cilWriter.Write(decoded);
        }
    }
}