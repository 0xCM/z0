//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Konst;
    using static z;

    partial struct AsmTables
    {
        public static uint emit(IWfShell wf, AsmRowSet<Mnemonic> src)
        {
            var count = src.Count;
            if(count != 0)
            {
                var dst = wf.Db().Table(AsmRow.TableId, src.Key.ToString());
                var records = span(src.Sequenced);
                var formatter = Formatters.dataset<AsmRowField>();
                var header = Table.header53<AsmRowField>();

                wf.EmittingTable<AsmRow>(dst);
                using var writer = dst.Writer();
                writer.WriteLine(header);
                for(var i=0; i<count; i++)
                {
                    ref readonly var record = ref skip(records,i);
                    var line = format(record, formatter).Render();
                    writer.WriteLine(line);
                }
                wf.EmittedTable<AsmRow>(count, dst);
            }
            return count;
        }
    }
}