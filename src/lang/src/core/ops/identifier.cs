//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct lang
    {
        [MethodImpl(Inline)]
        public static Identifier<T> identifier<T>(T src)
            where T : unmanaged, Enum, IComparable<T>
                => new Identifier<T>(src);

        [MethodImpl(Inline), Op]
        public static Identifier identifier(string src)
            => new Identifier(src);
    }
}