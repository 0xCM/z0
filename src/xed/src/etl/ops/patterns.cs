//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;
    using static XedSourceMarkers;

    partial struct XedWfOps
    {
        [Op]
        public static ref XedPattern[] map(in XedInstructionDoc src, out XedPattern[] dst)
        {
            var patterns = list<XedPattern>();
            var count = src.RowCount;
            var last = count - 1;
            for(var i=0; i<count; i++)
            {
                if(src.IsProp(i,PATTERN) && i != last)
                {
                    if(src.IsProp(i + 1, OPERANDS))
                    {
                        patterns.Add(new XedPattern(
                            src.Class,
                            src.Category,
                            src.Extension,
                            src.IsaSet,
                            src.ExtractProp(i),
                            src.ExtractProp(i + 1)
                            ));
                    }
                }
            }
            dst = patterns.ToArray();
            return ref dst;
        }

        public static XedPattern[] patterns(in XedInstructionDoc src)
            => map(src, out var _);

    }
}