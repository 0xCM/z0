//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;
    using System.Runtime.CompilerServices;
 
    using static Konst;

    public readonly struct ProjectorProxy
    {
        [MethodImpl(Inline)]
        public static ValueFunc<T> valuefunc<T>(Func<object,T> f)
            where T : struct
                => new ProjectorProxy<T>(f).F;
    }
    
    readonly struct ProjectorProxy<T> : IValueProjector<T>
        where T : struct
    {          
        readonly Func<object,T> f;

        readonly T[] Target;

        [MethodImpl(Inline)]
        public ProjectorProxy(Func<object,T> f)
        {
            this.f = f;
            Target = sys.alloc<T>(1);
        }

        [MethodImpl(Inline)]
        public ref T Project(object src)
        {
            ref var dst = ref Target[0];
            dst = f(src);
            return ref dst;                        
        }

        [MethodImpl(Inline)]
        public ref T Project(in ValueType src)
        {
            ref var dst = ref Target[0];
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