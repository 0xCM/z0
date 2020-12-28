//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct Adjacent<T>
    {
        public T A {get;}

        public T B {get;}

        [MethodImpl(Inline)]
        public Adjacent(T a, T b)
        {
            A = a;
            B = b;
        }
    }
}