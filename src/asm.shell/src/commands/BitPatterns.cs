//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Root;
    using static core;

    using K = BitCharKind;

    public readonly struct BitPatterns
    {
        static ReadOnlySpan<BitCharKind> Sym => new BitCharKind[16]{
            K.Off, K.On, K.Space, K.Space, K.Space, K.Space, K.Space, K.Space,
            K.Space, K.Space, K.Space, K.Space, K.Space, K.Space, K.Space, K.Space
                };
    }

}