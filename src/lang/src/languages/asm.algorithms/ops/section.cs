//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct AsmAlgorithms
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Section<T> section<T>(T min, T max)
            => new Section<T>(min,max);
    }
}