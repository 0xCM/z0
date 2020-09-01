//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    public readonly struct RenderFunctions
    {
        public delegate T RenderArray<S,T>(S[] src);

        public delegate T DelimitArray<S,T>(S[] src, char delimiter);
    }
}