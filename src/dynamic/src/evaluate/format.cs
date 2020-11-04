//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct Eval
    {
        [Op]
        public static string format(in EvalResult src, char delimiter = FieldDelimiter)
        {
            var dst = Table.formatter(delimiter, src.FieldKind);
            emit(src,dst);
            return dst.Format();
        }
    }
}