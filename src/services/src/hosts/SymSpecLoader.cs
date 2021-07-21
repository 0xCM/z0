//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    public class SymSpecLoader : AppService<SymSpecLoader>
    {

        // Index    | Kind         | Name | Expression | Value | Description
        // Name     | Description
        // Name     | Expression   | Description
        public Outcome Load(FS.FilePath src, out SymSeqSpec dst)
        {
            var outcome = Outcome.Success;
            dst = default;
            outcome = TextGrids.load(src, out var grid);

            if(!outcome)
                return outcome;

            if(!grid.HasHeader)
                return (false, "Source has no header");

            var header = grid.Header;
            var cols = header.Labels.View;
            var kind = SymSpecs.kind(cols);
            if(kind == 0)
                return (false, "Source headers do not conform");

            var rows = grid.Rows;
            var count = rows.Length;
            var buffer = alloc<SymSpec>(count);
            ref var spec = ref first(buffer);
            var n = cols.Length;
            for(var i=0; i<count; i++)
            {
                spec = seek(spec,i);
                var cells = skip(rows,i).Cells;

                for(var j=0; j<n; j++)
                {
                    ref readonly var col = ref skip(cells,j);
                }



            }


            return outcome;
        }

    }

}