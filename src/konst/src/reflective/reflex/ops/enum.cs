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

    partial struct Reflex
    {
        [MethodImpl(Inline), Op]
        public static bool @enum(Type src)
            => src.IsEnum;
    }
}