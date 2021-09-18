//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.llvm
{
    using System;
    using System.Runtime.CompilerServices;

    using static core;

    partial class EtlWorkflow
    {
        void LoadFieldRecords(ReadOnlySpan<TextLine> src, in LineInterval<AsmId> interval, ref int k, Span<AsmRecordField> dst)
        {
            ref readonly var min = ref interval.MinLine;
            ref readonly var max = ref interval.MaxLine;
            var length = interval.LineCount;
            var offset = min - 1;
            for(var j=offset; j<length+offset; j++)
            {
                ref readonly var line = ref skip(src,j);
                var content = line.Content.Trim();
                ref var field = ref seek(dst, k++);
                field.Id = interval.Id;
                if(text.index(content, Chars.Space, out var i0))
                {
                    field.FieldContent.Type = text.left(content,i0);
                    var namedValue = text.right(content,i0);
                    if(text.index(namedValue, Chars.Space, out var i1))
                    {
                        field.FieldContent.Name = text.left(namedValue,i1);
                        if(text.index(namedValue, Chars.Eq, out var i2))
                        {
                            if(text.index(namedValue, Chars.Semicolon, out var i3))
                                field.FieldContent.Value = text.inside(namedValue, i2, i3);
                        }
                    }
                }
            }
        }

        public Index<AsmRecordField> LoadAsmDefFields()
        {
            var result = Outcome.Success;
            var src = LlvmPaths.DataSourcePath(LlvmDatasetKind.Instructions);
            var icount = AsmDefMap.IntervalCount;
            var lcount = AsmDefMap.LineCount;
            var intervals = AsmDefMap.Intervals;
            var lines = Sources.Instructions.View;
            var buffer = alloc<AsmRecordField>(lcount);
            ref var target = ref first(buffer);
            var k = 0;
            for(var i=0u; i<icount; i++)
                LoadFieldRecords(lines, skip(intervals,i), ref k, buffer);

            return buffer;
        }
    }
}