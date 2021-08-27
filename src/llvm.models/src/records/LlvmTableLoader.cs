//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.llvm
{
    using System;

    using static core;

    public class LlvmTableLoader
    {
        public static Outcome load(FS.FilePath path, out Span<LlvmValueType> buffer)
        {
            const byte FieldCount = LlvmValueType.FieldCount;
            var result = TextGrids.load(path, out var doc);
            buffer = default;
            if(result.Fail)
                return result;

            var rows = doc.Rows;
            var count = rows.Length;
            buffer = span<LlvmValueType>(count);
            var counter = 0u;
            for(var i=0; i<count; i++)
            {
                ref var dst = ref seek(buffer,i);
                ref readonly var src = ref skip(rows,i);
                if(src.CellCount != FieldCount)
                {
                    result = (false, AppMsg.FieldCountMismatch.Format(FieldCount,src.CellCount));
                    break;
                }

                var cells = src.Cells;
                var cell = TextBlock.Empty;

                var j=0;
                cell = skip(cells, j++);
                if(!DataParser.block(cell, out dst.Namespace))
                {
                    result = (false, string.Format("Failed to parse field '{0}' from input '{1}'", nameof(dst.Namespace), cell));
                    break;
                }

                cell = skip(cells, j++);
                if(!DataParser.parse(cell, out dst.Size))
                {
                    result = (false, string.Format("Failed to parse field '{0}' from input '{1}'", nameof(dst.Size), cell));
                    break;
                }

                cell = skip(cells, j++);
                if(!DataParser.parse(cell, out dst.Value))
                {
                    result = (false, string.Format("Failed to parse field '{0}' from input '{1}'", nameof(dst.Value), cell));
                    break;
                }

                counter++;
            }

            buffer = slice(buffer, 0, counter);
            return result;
        }
    }
}