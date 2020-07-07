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

    partial struct LiteralFields
    {
        [MethodImpl(Inline), Op]
        public static string @string(FieldInfo f)
            => core.constant<string>(f);
    }
}