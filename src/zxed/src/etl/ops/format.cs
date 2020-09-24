//-----------------------------------------------------------------------------
// Copyright   : (c) 2019 Intel Corporation
// Copyright   : (c) Chris Moore, 2020
// License     : Apache
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    partial struct XedOps
    {
        [Op]
        public static string format(in XedPattern src, char delimiter)
        {
            var dst = Table.formatter<XedPatternField>(delimiter);
            render(src,dst);
            return dst.Format();
        }

        [Op]
        public static string format(in XedPatternSummary src, char delimiter)
        {
            var dst = Table.formatter<XedPatternField>(delimiter);
            render(src, dst);
            return dst.Format();
        }

        [MethodImpl(Inline), Op]
        public static string format(in XedInstructionRow src, in DatasetFormatter<XedInstructionField> dst)
            => render(src, dst).Render();
    }
}