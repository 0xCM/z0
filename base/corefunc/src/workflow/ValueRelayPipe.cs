//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static zfunc;

   public interface IValueRelayPipe<T> : IValuePipe<T>
        where T : struct
    {
        ref readonly T Relay(in T src);

        [MethodImpl(Inline)]
        object IPipe.Flow(object src)
            => Relay(in Unsafe.As<object,T>(ref src));
    }

    readonly struct FunctionalRelay<T> : IValueRelayPipe<T>
        where T : struct
    {
        readonly ValueRelay<T> f;
        
        [MethodImpl(Inline)]
        public FunctionalRelay(ValueRelay<T> f)
            => this.f = f;

        [MethodImpl(Inline)]
        public ref readonly T Relay(in T src)
            => ref f(in src);
    }

}