//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;
    using System.Runtime.CompilerServices;
 
    using static Konst;
    using static Projectors;

    readonly struct ProjectorProxy<T> : IValueProjector<T>
        where T : struct
    {
        readonly Func<object,T> f;

        readonly T[] Dst;

        [MethodImpl(Inline)]
        public ProjectorProxy(Func<object,T> f)
        {
            this.f = f;
            Dst = sys.alloc<T>(1);
        }
        
        [MethodImpl(Inline)]
        public ref T Project(object src)
        {
            ref var dst = ref Dst[0];
            dst = f(src);
            return ref dst;                        
        }

        [MethodImpl(Inline)]
        public ref T Project(in ValueType src)
        {
            ref var dst = ref Dst[0];
            dst = f(src);
            return ref dst;                        
        }

        public ValueFunc<T> F 
        {
            [MethodImpl(Inline)]
            get => Project;
        }

        [MethodImpl(Inline)]
        public ValueType Untyped(ValueType src)
            => f(src);    
        
        ValueFunc IValueProjector.F         
            => Untyped;
    }
}