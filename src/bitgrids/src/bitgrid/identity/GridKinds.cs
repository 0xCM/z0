// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using static Konst;

    public class GridKinds
    {
        [MethodImpl(Inline)]
        public static bool closed(Type src)
            => src.GridKind().MapValueOrDefault(k => src.OpenTypeParameterCount() == 0);

        [MethodImpl(Inline)]
        public static bool open(Type src)
            => src.GridKind().MapValueOrDefault(k => src.OpenTypeParameterCount() != 0);
    }
}