//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Konst;

    [ApiHost]
    public readonly struct LiteralCovers
    {
        [MethodImpl(Inline), Op]
        public static LiteralCover from(ValueType src)
            => new LiteralCover(src, src.GetType().Fields());

        [MethodImpl(Inline)]
        public static LiteralCover<C> from<C>(C src)
            where C : struct, ILiteralCover<C>
                => new LiteralCover<C>(src, typeof(C).Fields());
    }
}