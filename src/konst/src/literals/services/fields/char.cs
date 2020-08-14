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

    partial struct LiteralFieldApi
    {
        [MethodImpl(Inline), Op]
        public static char @char(FieldInfo f)
            => sys.constant<char>(f);
    }
}