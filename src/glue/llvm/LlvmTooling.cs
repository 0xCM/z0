//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Tools
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    [ApiHost]
    public sealed class LlvmTooling : AppService<LlvmTooling>
    {
        public LlvmTooling()
        {

        }

        public ReadOnlySpan<LlvmValueType> ValueTypes()
        {
            const byte FieldCount = LlvmValueType.FieldCount;
            var path = FS.FilePath.Empty;
            var outcome = TextGrids.load(path, out var doc);
            if(outcome.Fail)
            {
                Wf.Error(outcome.Message);
                return default;
            }
            var rows = doc.Rows;
            var count = rows.Length;
            var buffer = span<LlvmValueType>(count);
            var counter = 0u;
            var flow = Wf.Running(string.Format("Attempting to parse {0} records", rows.Length));
            for(var i=0; i<count; i++)
            {
                ref var dst = ref seek(buffer,i);
                ref readonly var src = ref skip(rows,i);
                if(src.CellCount != FieldCount)
                {
                    Wf.Error("count");
                    break;
                }

                var cells = src.Cells;
                var cell = TextBlock.Empty;

                var j=0;
                cell = skip(cells,j++);
                if(!DataParser.parse(cell, out dst.Name))
                {
                    Wf.Error(string.Format("Failed to parse field '{0}' from input '{1}'", nameof(dst.Name), cell));
                    Wf.Row(cells.Delimit().Format());
                    break;
                }

                cell = skip(cells,j++);
                if(!DataParser.parse(cell, out dst.Width))
                {
                    Wf.Error(string.Format("Failed to parse field '{0}' from input '{1}'", nameof(dst.Width), cell));
                    Wf.Row(cells.Delimit().Format());
                    break;
                }

                cell = skip(cells,j++);
                if(!DataParser.parse(cell, out dst.Description))
                {
                    Wf.Error(string.Format("Failed to parse field '{0}' from input '{1}'", nameof(dst.Description), cell));
                    Wf.Row(cells.Delimit().Format());
                    break;
                }

                cell = skip(cells,j++);
                if(!DataParser.parse(cell, out dst.Emit))
                {
                    Wf.Error(string.Format("Failed to parse field '{0}' from input '{1}'", nameof(dst.Emit), cell));
                    Wf.Row(cells.Delimit().Format());
                    break;
                }

                counter++;
            }

            Wf.Ran(flow, string.Format("Parsed {0} records", counter));

            return slice(buffer, 0, counter);
        }
    }
}