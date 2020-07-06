//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;
    using System.Runtime.CompilerServices;
 
    using static Konst;

    public readonly struct ValueProjector<T> : IValueProjector<T>
        where T : struct
    {
        public ValueFunc<T> F {get;}

        [MethodImpl(Inline)]
        public ValueProjector(ValueFunc<T> f)
            => F = f;

        [MethodImpl(Inline)]
        public ref T Project(object src)
            => ref core.unbox<T>(F((ValueType)src));

        [MethodImpl(Inline)]
        public ref T Project(ValueType src)
            => ref core.unbox<T>(F(src));
    }
}