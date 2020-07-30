//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct Primitive
    {
        [MethodImpl(Inline)]
        public static bool test(Type src)
            => kind(src) != 0;            
    }
}