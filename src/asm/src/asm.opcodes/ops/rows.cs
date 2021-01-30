//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static z;

    partial struct AsmOpCodes
    {
        [Op, MethodImpl(Inline)]
        public static Span<AsmOpCodeRowLegacy> rows(in AppResDoc specs)
        {
            var dst = Spans.alloc<AsmOpCodeRowLegacy>(specs.Rows.Length);
            parse(specs, dst);
            return dst;
        }
    }
}