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

    readonly struct ValueObserverFlow<T> : IValueObserverFlow<T>
        where T : struct
    {


    }

    readonly struct ValueObserverFlow<P, T> : IValueObserverFlow<P, T>
        where T : struct
        where P : IValueObserverPipe<T>
    {


    }
}