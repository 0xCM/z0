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
        public static FieldInfo[] stringlits(Type src)
            => search(src).Where(f => f.IsStringLiteral());
    }
}