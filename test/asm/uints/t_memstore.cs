//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;

    using static z;
    using static Cil;

    using Z0.Asm;

    public class t_memstore : t_asmd<t_memstore>
    {
        public void read_ref_1()
        {
            var src = array(3u,5u,6u,7u);
            var r = MemRefs.from(src);
            var z = r.As<uint>();

            Claim.eq(16, r.DataSize);
            Claim.eq(4, r.CellCount);
            for(var i=0; i<src.Length; i++)
                base.Claim.eq(r[i], (BitVector32)src[i]);
        }


        public void read_models()
        {
            var svc = Resources.stores(n256);
            var store = svc.store();
            var results = svc.locations(store);
            var dst = CaseWriter(FileExtensions.Csv);
            for(var i=0; i<results.Length; i++)
            {
                var result = results[i];
                Claim.yea(result.IsNonEmpty);
                dst.WriteLine(result);
            }
        }

        unsafe void Process(in MemorySegment src, in MemorySegments store)
        {
            var reader = MemoryReader.create(src.Address.Pointer<byte>(), (int)src.DataSize);
            var dstA = Spans.alloc<byte>(src.DataSize);
            var count = reader.ReadAll(dstA);
            Claim.eq(count,src.DataSize);

            var dstB = MemoryStore.Service.load(src);
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
            var summary = CaseWriter(FileExtensions.Csv);
            var header = text.concat("Type".PadRight(20), "| ", "Property".PadRight(30), "| ", "Cil Bytes");
            summary.WriteLine(header);

            var types = array(typeof(HexSymData), typeof(KonstBytes));
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

            var decoded = Cil.decode(mod,props.Select(x => x.GetGetMethod())).ToArray();
            var path = FS.path(CasePath(FileExtensions.Il).Name);
            var cilWriter = new FunctionWriter(path);
            cilWriter.Write(decoded);
        }

        public void emit_data()
        {

            var refs = Hex.HexRefs;
            using var dst = CasePath($"Symbolic").Writer();
            for(var i=0; i<refs.Length; i++)
            {
                var r = refs[i];
                var data = MemoryView.view(r.Address, r.DataSize);
                dst.WriteLine(data.FormatHexBytes(Chars.Space));

            }
        }

        public void run_2()
        {
            var svc = Resources.stores(n256);
            var store = svc.store();
            var sources = store.View;
            for(var i=0u; i<sources.Length; i++)
                Process(skip(sources,i), store);
        }
    }
}