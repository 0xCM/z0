//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct lang
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Label<T> label<T>(Identifier name, T value)
            => new Label<T>(name, value);
    }
}