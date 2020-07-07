//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Konst;

    partial class XTend
    {     
        [MethodImpl(Inline)]
        public static Emitter<T> ToEmitter<T>(this System.Func<T> f)
            => Delegated.emitter(f);

        [MethodImpl(Inline)]
        public static Emitter<T,C> ToEmitter<T,C>(this System.Func<T> f)
            where T : unmanaged
            where C : unmanaged
                => Delegated.emitter<T,C>(f);
    }
}