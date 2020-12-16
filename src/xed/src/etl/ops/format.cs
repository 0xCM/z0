//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct XedWfOps
    {
        [Op]
        public static string format(in XedPattern src, char delimiter)
        {
            var dst = Table.formatter<XedPatternField>(delimiter);
            render(src,dst);
            return dst.Format();
        }

        [Op]
        public static string format(in XedPatternRow src, char delimiter)
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