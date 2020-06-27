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
        public readonly ValueFunc<S,T> F {get;}

        [MethodImpl(Inline)]
        public ValueProjector(ValueFunc<S,T> f)
        {
            F = f;
        }

        [MethodImpl(Inline)]
        public T map(object src)
            => Project(sys.unbox<S>(src));

        [MethodImpl(Inline)]
        public T map(ValueType src)
            => Project(sys.unbox<S>(src));

        [MethodImpl(Inline)]
        public ref T Project(in S src)
            => ref F(src);

        public ValueProjector<T> Reduced
        {
            [MethodImpl(Inline)]
            get => Projectors.define(map);
        }

        ValueFunc<T> IValueProjector<T>.F 
            => Reduced.F;
    }
}