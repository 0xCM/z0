//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    partial class Control
    {
        [MethodImpl(Inline)]
        public static ref T edit<T>(in T src)
            => ref Unsafe.AsRef(in src);
    }
}