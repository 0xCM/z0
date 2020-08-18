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

    partial struct Literals
    {
        [MethodImpl(Inline), Op]
        public static string @string(FieldInfo f)
            => z.constant<string>(f);
    }
}