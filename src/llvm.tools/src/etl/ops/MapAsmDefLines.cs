//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.llvm
{
    using static core;

    using SQ = SymbolicQuery;

    partial class EtlWorkflow
    {
        public LineMap<AsmId> MapAsmDefLines()
        {
            const uint BufferLength = 256;
            var result = Outcome.Success;
            var records = Sources.Instructions.View;
            var linecount = records.Length;
            var defs = Defs(LlvmDatasetKind.Instructions);
            var count = defs.Length;
            var buffer = span<TextLine>(BufferLength);
            var intervals = list<LineInterval<AsmId>>();
            for(var i=0;i<count; i++)
            {
                ref readonly var d0 = ref skip(defs,i);
                if(!Enums.parse(d0.Name, out AsmId id))
                    continue;

                var k=0;
                buffer.Clear();
                var index = d0.Offset.Value;
                for(var j=index; j<linecount && k<BufferLength; j++)
                {
                    ref readonly var line = ref skip(records,j);
                    ref readonly var content = ref line.Content;
                    if(SQ.index(content, Chars.RBrace) != 0)
                    {
                        seek(buffer,k++) = line;
                    }
                    else
                        break;
                }

                if(k>0)
                {
                    ref readonly var l0 = ref first(buffer);
                    ref readonly var l1 = ref skip(buffer,k-1);
                    var interval = LineMaps.interval(id, l0.LineNumber, l1.LineNumber);
                    intervals.Add(interval);
                }
            }

            var map = LineMaps.map(intervals.ToArray());
            var dst = LlvmPaths.LineMapPath("x86.instructions");
            var emitting = EmittingFile(dst);
            using var writer = dst.AsciWriter();
            var _intervals = map.Intervals;
            for(var i=0; i<_intervals.Length; i++)
            {
                ref readonly var ix = ref skip(_intervals,i);
                writer.WriteLine(string.Format("{0:D5} {1}", (ushort)ix.Id, ix));
            }

            EmittedFile(emitting, _intervals.Length);
            return map;
        }
    }
}