//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Rules
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct api
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Literal<T> literal<T>(Label label, T value)
            => new Literal<T>(label,value);
    }
}