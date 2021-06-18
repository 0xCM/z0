//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static core;

    public class XedFormPipe
    {
        public static XedFormPipe create(IWfRuntime wf)
            => new XedFormPipe(wf);

        readonly IWfRuntime Wf;

        readonly IEnvPaths Paths;

        public XedFormPipe(IWfRuntime wf)
        {
            Wf = wf;
            Paths = wf.Db();
        }

        public Index<XedFormAspect> EmitFormAspects()
        {
            var duplicates = dict<Hash32,uint>();
            var aspects = Wf.IntelXed().ComputeFormAspects();
            var count = (uint)aspects.Length;
            var buffer = alloc<XedFormAspect>(count);
            var paths = new AsmCatalogArchive(Paths.AsmCatalogRoot());
            var path = paths.XedFormAspectPath();
            var formatter = Tables.formatter<XedFormAspect>();
            var emitting = Wf.EmittingTable<XedFormAspect>(path);
            using var writer = path.Writer();
            writer.WriteLine(formatter.FormatHeader());
            for(var i=0u; i<count; i++)
            {
                ref var record = ref seek(buffer,i);
                ref readonly var aspect = ref skip(aspects,i);
                record.Index = i;
                record.Value = aspect.Value;
                record.Hash = aspect.GetHashCode();
                if(duplicates.TryGetValue(record.Hash, out var c))
                    duplicates[record.Hash] = ++c;
                else
                    duplicates.Add(record.Hash, 0);
                writer.WriteLine(formatter.Format(record));
            }

            var perfect = !duplicates.Values.Any(x => x > 0);
            if(perfect)
                Wf.Status($"Hash Perfect");
            else
                Wf.Warn("Hash Imperfect");

            Wf.EmittedTable(emitting, count);
            return buffer;
        }
    }
}