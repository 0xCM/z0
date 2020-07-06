//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;
    using System.Runtime.CompilerServices;
 
    using static Konst;

    public readonly struct ValueProjector : IValueProjector
    {        

        [MethodImpl(Inline)]
        public static ValueProjector<T> from<T>(Func<object,T> f)
            where T : struct
                => new ValueProjector<T>(ProjectorProxy.valuefunc(f));

        readonly ValueFunc f;
        
        public ValueFunc F 
        {
            [MethodImpl(Inline)]
            get => f;
        }

        [MethodImpl(Inline)]
        public ValueProjector(ValueFunc f)
            => this.f = f;
        
        [MethodImpl(Inline)]
        public object Project(object src)
            => f((ValueType)src);

        [MethodImpl(Inline)]
        public ValueType Project(ValueType src)
            => f(src);

        [MethodImpl(Inline)]
        public ref T Project<T>(object src)
            where T : struct
                => ref core.unbox<T>(f((ValueType)src));
    }
}
