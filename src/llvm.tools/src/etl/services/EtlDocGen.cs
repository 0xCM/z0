//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.llvm
{
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;
    using static EtlNames;

    public ref struct EtlDocGen
    {
        [MethodImpl(Inline)]
        public static EtlDocGen create(IWfRuntime wf, in EtlDatasets src)
            => new EtlDocGen(wf,src);

        readonly EtlDatasets Datasets;

        readonly IWfRuntime Wf;

        [MethodImpl(Inline)]
        internal EtlDocGen(IWfRuntime wf, in EtlDatasets src)
        {
            Wf = wf;
            Datasets = src;
        }

        public uint GenInsructionDocs(FS.FolderPath dst)
        {
            var query = EtlDatasetQuery.create(Datasets);
            var counter = 0u;
            if(query.FindList(Lists.X86Inst, out var items))
            {
                var icount = items.Count;
                for(var i=0; i<icount; i++)
                {
                    ref readonly var item = ref items[i];
                    ref readonly var name = ref item.Content;
                    if(query.FindDefLines(name, out var lines))
                    {
                        var path = dst + FS.file(name,FS.Md);
                        using var writer = path.AsciWriter();
                        writer.WriteLine("# {0}", name);
                        writer.WriteLine();

                        var fcount = lines.Length;
                        for(var j=0; j<fcount; j++)
                        {
                            ref readonly var line = ref skip(lines,j);
                            writer.WriteLine(line.Content);
                        }

                        if(counter != 0 && ++counter % 1000 == 0)
                        {
                            Wf.Status(string.Format("Emitted {0}/{1} instruction documents", counter, icount));
                        }
                    }
                }
            }
            return counter;
        }
    }
}