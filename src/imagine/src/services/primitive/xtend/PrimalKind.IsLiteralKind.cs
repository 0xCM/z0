//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial class XTend
    {
        [MethodImpl(Inline)]
        public static bool IsLiteralKind(this PrimalKind src)
            => Primitive.literal(src);
    }
}