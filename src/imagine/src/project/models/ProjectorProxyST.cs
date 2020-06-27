//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;
    using System.Runtime.CompilerServices;
 
    using static Konst;

    readonly struct ProjectorProxy<S,T> : IValueProjector<S,T>
        where S : struct
        where T : struct
    {
        readonly Func<S,T> f;

        readonly T[] Dst;

        [MethodImpl(Inline)]
        public ProjectorProxy(Func<S,T> f)
        {
            this.f = f;
            Dst = sys.alloc<T>(1);
        }
        
        [MethodImpl(Inline)]
        public ref T Project(in S src)
        {
            ref var dst = ref Dst[0];
            dst = f(src);
            return ref dst;                        
        }

        [MethodImpl(Inline)]
        public T map(object src)
            => Project(sys.unbox<S>(src));

        [MethodImpl(Inline)]
        public T map(ValueType src)
            => Project(sys.unbox<S>(src));

        public ValueFunc<S,T> F 
        {
            [MethodImpl(Inline)]
            get => Project;
        }

        public ValueProjector<T> Reduced
        {
            [MethodImpl(Inline)]
            get => Projectors.define(map);
        }

        ValueFunc<T> IValueProjector<T>.F 
            => Reduced.F;
    }
}