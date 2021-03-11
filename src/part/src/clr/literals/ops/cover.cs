//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Part;

    partial struct ClrLiterals
    {
        [MethodImpl(Inline), Op]
        public static LiteralCover cover(ValueType src)
            => new LiteralCover(src, src.GetType().Fields());

        [MethodImpl(Inline), Op]
        public static LiteralCover cover(ValueType src, FieldInfo[] fields)
            => new LiteralCover(src,fields);

        [MethodImpl(Inline)]
        public static LiteralCover<C> cover<C>(C src)
            where C : struct, ILiteralCover<C>
                => new LiteralCover<C>(src, typeof(C).Fields());
    }
}