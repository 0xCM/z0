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

    using static Root;

    public interface IValueRelayPipe<T> : IValuePipe<T>
        where T : struct
    {
        ref readonly T Relay(in T src);

        [MethodImpl(Inline)]
        object IPipe.Flow(object src)
            => Relay(in Unsafe.As<object,T>(ref src));
    }
}