//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.llvm
{
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    public ref struct EtlDocGen
    {
        [MethodImpl(Inline)]
        public static EtlDocGen create(in EtlDatasets src)
            => new EtlDocGen(src);

        readonly EtlDatasets Datasets;

        [MethodImpl(Inline)]
        internal EtlDocGen(in EtlDatasets src)
        {
            Datasets = src;
        }

        public uint GenInsructionDocs(FS.FolderPath dst)
        {
            var query = EtlDatasetQuery.create(Datasets);
            var counter = 0u;
            if(query.FindList(EtlListNames.X86Inst, out var items))
            {
                var icount = items.Count;
                for(var i=0; i<icount; i++)
                {
                    ref readonly var item = ref items[i];
                    ref readonly var name = ref item.Content;
                    var path = dst + FS.file(name,FS.Md);
                    using var writer = path.AsciWriter();
                    writer.WriteLine("# {0}", name);
                    writer.WriteLine();
                    if(query.FindDefLines(name, out var lines))
                    {
                        var fcount = lines.Length;
                        for(var j=0; j<fcount; j++)
                        {
                            ref readonly var line = ref skip(lines,j);
                            writer.WriteLine(line.Content);
                        }
                        counter++;
                    }
                }
            }
            return counter;
        }
    }
}