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

    public interface IValueFlow : IFlow
    {
     
        [MethodImpl(Inline)]
        object Flow(object src, IValuePipe pipe)
            => pipe.Flow(src);

        [MethodImpl(Inline)]
        IEnumerable<object> Flow(IEnumerable<object> src, IValuePipe pipe)
            => pipe.Flow(src);
    }

    public interface IValueFlow<T> : IValueFlow
        where T : struct
    {
        IEnumerable<T> Flow(IEnumerable<T> src, IValuePipe<T> dst);
    }

    public interface IValueFlow<P,T> : IValueFlow<T>
        where T : struct
        where P : IValuePipe<T>
    {
        IEnumerable<T> Flow(IEnumerable<T> src, P dst);
    }

    public interface IValueFlow<P,S,T>  : IValueFlow
        where S : struct
        where T : struct
        where P : IValuePipe<S,T>
    {

        IEnumerable<T> Flow(IEnumerable<S> src, P dst);
    }
}