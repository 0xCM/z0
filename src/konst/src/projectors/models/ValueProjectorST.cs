//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;
    using System.Runtime.CompilerServices;
 
    using static Konst;

    public readonly struct ValueProjector<S,T> : IValueProjector<S,T>
        where S : struct
        where T : struct
    {
        readonly ValueFunc<S,T> f;
        
        public readonly ValueFunc<S,T> F 
        {
            [MethodImpl(Inline)]
            get => f;
        }
        
        [MethodImpl(Inline)]
        public ValueProjector(ValueFunc<S,T> f)
            => this.f = f;

        [MethodImpl(Inline)]
        public T map(object src)
            => f(core.unbox<S>(src));

        [MethodImpl(Inline)]
        public T map(ValueType src)
            => f(core.unbox<S>(src));

        [MethodImpl(Inline)]
        public ref T Project(in S src)
            => ref f(src);

        public ValueProjector<T> Reduced
        {
            [MethodImpl(Inline)]
            get => ValueProjector.from(map);
        }

        ValueFunc<T> IValueProjector<T>.F 
            => Reduced.F;
    }
}