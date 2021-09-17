//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static System.Runtime.CompilerServices.Unsafe;
    using static Root;

    partial struct minicore
    {
        [MethodImpl(Inline)]
        public static ref T @as<S,T>(in S src)
            => ref As<S,T>(ref Unsafe.AsRef(src));
    }
}