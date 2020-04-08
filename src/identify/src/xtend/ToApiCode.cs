//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    partial class XTend
    {
        [MethodImpl(Inline)]
        public static IdentifiedCode ToApiCode(this AsmCode src)
            => IdentifiedCode.Define(src.Id, src.Data.Bytes);
    }
}