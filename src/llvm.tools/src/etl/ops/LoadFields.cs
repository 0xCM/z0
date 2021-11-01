//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.llvm
{
    using System;

    using records;

    using static core;

    partial class LlvmEtlServices
    {
        void LoadFields(ReadOnlySpan<TextLine> src, in LineInterval<Identifier> interval, ref int k, Span<TableGenField> dst)
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
                    field.FieldContent.DataType = text.trim(text.left(content,i0));
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

        public Index<TableGenField> LoadFields(ReadOnlySpan<TextLine> records, LineMap<Identifier> map)
        {
            var result = Outcome.Success;
            var icount = map.IntervalCount;
            var lcount = map.LineCount;
            var intervals = map.Intervals;
            var buffer = alloc<TableGenField>(lcount);
            var k = 0;
            for(var i=0u; i<icount; i++)
                LoadFields(records, skip(intervals,i), ref k, buffer);
            return buffer;
        }
    }
}