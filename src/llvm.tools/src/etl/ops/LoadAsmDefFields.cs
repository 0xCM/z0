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
            {
                ref readonly var interval = ref skip(intervals,i);
                ref readonly var min = ref interval.MinLine;
                ref readonly var max = ref interval.MaxLine;
                var length = interval.LineCount;
                var offset = min - 1;
                for(var j=offset; j<length+offset && k <lcount; j++)
                {
                    ref readonly var line = ref skip(lines,j);
                    ref readonly var content = ref line.Content;
                    ref var dst = ref seek(target,k++);
                    dst.Id = interval.Id;
                    if(text.index(content,Chars.Space, out var i0))
                    {
                        dst.FieldContent.Type = text.left(content,i0);
                        var namedValue = text.right(content,i0);
                        if(text.index(namedValue, Chars.Space, out var i1))
                        {
                            dst.FieldContent.Name = text.left(namedValue,i1);
                            if(text.index(namedValue, Chars.Eq, out var i2))
                            {
                                if(text.index(namedValue, Chars.Semicolon, out var i3))
                                {
                                    dst.FieldContent.Value = text.between(namedValue, i2,i3);
                                }
                            }
                        }
                    }
                }
            }

            return buffer;
        }
    }
}