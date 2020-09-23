//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using F = EvalResultField;

    partial struct Eval
    {
        [Op]
        public static ref readonly FieldFormatter<F> emit(in EvalResult src, in FieldFormatter<F> dst)
        {
            dst.Append(F.Sequence, src.Sequence);
            dst.Delimit(F.CaseName, src.CaseName);
            dst.Delimit(F.Status, src.Status);
            dst.Delimit(F.Duration, src.Duration);
            dst.Delimit(F.Timestamp, src.Timestamp);
            dst.Delimit(F.Message, src.Message);
            return ref dst;
        }
    }
}