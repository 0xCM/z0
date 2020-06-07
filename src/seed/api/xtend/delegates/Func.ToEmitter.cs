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
        public static Emitter<T> ToEmitter<T>(this System.Func<T> f)
            => Extend.emitter(f);

        [MethodImpl(Inline)]
        public static Emitter<T,C> ToEmitter<T,C>(this System.Func<T> f)
            where T : unmanaged
            where C : unmanaged
                => Extend.emitter<T,C>(f);
    }
}