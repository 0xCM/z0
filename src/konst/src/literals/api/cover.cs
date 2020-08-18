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
    using static z;

    partial struct Literals
    {
        [MethodImpl(Inline), Op]
        public static LiteralCover cover(ValueType src, FieldInfo[] fields)
            => new LiteralCover(src,fields);


    }
}