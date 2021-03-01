//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial class text
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static TextProcessor<T> processor<T>(ParseFunction<T> parseFx, RenderFunction<T> renderFx)
            => new TextProcessor<T>(parseFx, renderFx);
    }
}