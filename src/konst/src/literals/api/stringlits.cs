//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;
    using System.Collections.Generic;
    using System.Linq;

    using static Konst;

    partial struct Literals
    {
        [MethodImpl(Inline), Op]
        public static FieldInfo[] stringlits(Type src)
            => search(src).Where(f => f.IsStringLiteral());
    }
}