//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    using api = Symbols;

    [ApiHost]
    public static partial class XSym
    {
        [MethodImpl(Inline)]
        public static SymLiteral Untyped<E>(this SymLiteral<E> src)
            where E : unmanaged
                => api.untyped(src);
    }
}
