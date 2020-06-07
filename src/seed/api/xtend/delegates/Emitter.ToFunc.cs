//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Seed;

    partial class XTend
    {
        [MethodImpl(Inline)]
        public static System.Func<T> ToFunc<T>(this Emitter<T> f)
            => Extend.func(f);

        [MethodImpl(Inline)]
        public static System.Func<T> ToFunc<T,C>(this Emitter<T,C> f)
            where T : unmanaged
            where C : unmanaged
                => Extend.func(f);
    }
}