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
        public ValueFunc F {get;}

        [MethodImpl(Inline)]
        public ValueProjector(ValueFunc f)
        {
            F = f;
        }
        
        [MethodImpl(Inline)]
        public object Project(object src)
            => F((ValueType)src);

        [MethodImpl(Inline)]
        public ValueType Project(ValueType src)
            => F(src);

        [MethodImpl(Inline)]
        public ref T Project<T>(object src)
            where T : struct
                => ref sys.unbox<T>(F((ValueType)src));
    }
}
